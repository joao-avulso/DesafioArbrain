using DesafioArbrain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesafioArbrain.Service
{
    public class VendedorService
    {
        private static SqlConnection _connection;
        public VendedorService()
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

        public List<VendedorModel> GetAll()
        {
            List<VendedorModel> vendedores = new List<VendedorModel>();

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Vendedor", _connection);
                _connection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["id"];
                        string nome = (string)reader["Nome"];
                        VendedorModel vendedor = new VendedorModel(id, nome);
                        vendedores.Add(vendedor);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter vendedores: " + ex.Message);
                MessageBox.Show("Erro ao obter vendedores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();
            }

            return vendedores;
        }
    }
}
