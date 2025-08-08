using DesafioArbrain.Enums;
using DesafioArbrain.Models;
using DesafioArbrain.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesafioArbrain.Service
{
    public class MetaService
    {
        private static SqlConnection _connection;

        public MetaService()
        {
            try
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ARBRAIN\\Source\\Repos\\DesafioArbrain\\Database1.mdf;Integrated Security=True");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }
                

        public SortableBindingList<MetaModel> GetAll()
        {
            SortableBindingList<MetaModel> metas = new SortableBindingList<MetaModel>();

            try
            {
                string query = @"
                    SELECT 
                        m.*, 
                        v.Nome AS VendedorNome, 
                        p.Nome AS ProdutoNome,
                        p.Categoria AS CategoriaProduto
                    FROM Meta m
                    LEFT JOIN Vendedor v ON m.VendedorId = v.Id
                    LEFT JOIN Produto p ON m.ProdutoId = p.Id";

                SqlCommand sqlCommand = new SqlCommand(query, _connection);
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = Convert.ToInt32(reader["Id"]);
                        var tipo = (TipoMeta)reader["Tipo"];
                        var vendedor = new VendedorModel(
                            Convert.ToInt32(reader["VendedorId"]),
                            reader["VendedorNome"]?.ToString() ?? ""
                        );
                        var produto = new ProdutoModel(
                            Convert.ToInt32(reader["ProdutoId"]),
                            reader["ProdutoNome"]?.ToString() ?? "",
                            (CategoriaProduto)reader["CategoriaProduto"]
                        );
                        var valor = Convert.ToDecimal(reader["Valor"]);
                        var periodicidade = (Periodicidade)Enum.Parse(typeof(Periodicidade), reader["Periodicidade"].ToString());
                        var ativo = Convert.ToBoolean(reader["Ativo"]);

                        var meta = new MetaModel(id, tipo, vendedor, produto, valor, periodicidade, ativo);
                        metas.Add(meta);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter metas: " + ex.Message);
                MessageBox.Show("Erro ao obter metas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return metas;
        }

        public int AddMeta(MetaModel meta)
        {
            try
            {
                string query = "INSERT INTO Meta (Tipo, VendedorId, ProdutoId, Valor, Periodicidade, Ativo) " +
                    "VALUES (@Tipo, @VendedorId, @ProdutoId, @Valor, @Periodicidade, @Ativo)" +
                    "SELECT CAST(SCOPE_IDENTITY() AS int)";
                SqlCommand sqlCommand = new SqlCommand(query, _connection);
                sqlCommand.Parameters.AddWithValue("@Tipo", meta.Tipo);
                sqlCommand.Parameters.AddWithValue("@VendedorId", meta.Vendedor.Id);
                sqlCommand.Parameters.AddWithValue("@ProdutoId", meta.Produto.Id);
                sqlCommand.Parameters.AddWithValue("@Valor", meta.Valor);
                sqlCommand.Parameters.AddWithValue("@Periodicidade", meta.Periodicidade);
                sqlCommand.Parameters.AddWithValue("@Ativo", meta.Ativo);
                _connection.Open();
                return (int)sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar meta: " + ex.Message);
                MessageBox.Show("Erro ao adicionar meta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
            return 0;
        }

        public void DeleteMeta(MetaModel meta)
        {
            try
            {
                string query = "DELETE FROM Meta WHERE Id = @Id";
                SqlCommand sqlCommand = new SqlCommand(query, _connection);
                sqlCommand.Parameters.AddWithValue("@Id", meta.Id);
                _connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir meta: " + ex.Message);
                MessageBox.Show("Erro ao excluir meta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }

        public void UpdateMeta(MetaModel metaEditada)
        {
            try
            {
                string query = "UPDATE Meta SET Tipo = @Tipo, VendedorId = @VendedorId, ProdutoId = @ProdutoId, Valor = @Valor, Periodicidade = @Periodicidade, Ativo = @Ativo WHERE Id = @Id";
                SqlCommand sqlCommand = new SqlCommand(query, _connection);
                sqlCommand.Parameters.AddWithValue("@Id", metaEditada.Id);
                sqlCommand.Parameters.AddWithValue("@Tipo", metaEditada.Tipo);
                sqlCommand.Parameters.AddWithValue("@VendedorId", metaEditada.Vendedor.Id);
                sqlCommand.Parameters.AddWithValue("@ProdutoId", metaEditada.Produto.Id);
                sqlCommand.Parameters.AddWithValue("@Valor", metaEditada.Valor);
                sqlCommand.Parameters.AddWithValue("@Periodicidade", metaEditada.Periodicidade);
                sqlCommand.Parameters.AddWithValue("@Ativo", metaEditada.Ativo);
                _connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar meta: " + ex.Message);
                MessageBox.Show("Erro ao atualizar meta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }
        }
    }
}
