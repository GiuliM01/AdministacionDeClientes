using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LogicaNegocio
{
    public static class AccesoDatos
    {
        private static SqlConnection connection;
        private static SqlCommand command;
         static AccesoDatos()
        {
            connection = new SqlConnection("Server=DESKTOP-N7V99MU ; Database = PROEM;Trusted_Connection=True;");
            command = new SqlCommand();


            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }
        public static List<Cliente> LeerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
           
            try
            {
                connection.Open();
              
                command.CommandText = "SELECT * FROM Clientes";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clientes.Add(new Cliente(int.Parse(reader["Id"].ToString()),
                                                         reader["Nombre"].ToString(),
                                                         reader["Apellido"].ToString(),
                                               int.Parse(reader["Telefono"].ToString()),
                                                         reader["Direccion"].ToString()));
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return clientes;
        }
        public static void InsertarCliente(Cliente cliente)
        {
            

            try
            {
                connection.Open();

                command.CommandText = "INSERT INTO Clientes (Nombre, Apellido, Direccion, Telefono)" +
                                      "VALUES (@nombre,@apellido,@direccion,@telefono)";

                command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@telefono", cliente.Telefono);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
