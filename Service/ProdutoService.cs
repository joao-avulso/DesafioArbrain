using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DesafioArbrain.Enums;
using DesafioArbrain.Models;

namespace DesafioArbrain.Service
{
    public class ProdutoService
    {
        private static SqlConnection _connection;

        public ProdutoService()
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

        public List<ProdutoModel> GetAll()
        {
            List<ProdutoModel> produtos = new List<ProdutoModel>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Produto", _connection);
                _connection.Open();
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["id"];
                        string nome = (string)reader["Nome"];
                        int categoriaValue = (int)reader["Categoria"];
                        CategoriaProduto categoria = (CategoriaProduto)categoriaValue;
                        ProdutoModel produto = new ProdutoModel(id, nome, categoria);
                        produtos.Add(produto);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter produtos: " + ex.Message);
                MessageBox.Show("Erro ao obter produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return produtos;
        }

    }
}
