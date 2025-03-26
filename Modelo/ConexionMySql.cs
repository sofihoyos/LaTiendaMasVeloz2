using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    internal class ConexionMySql
    {
        public MySqlConnection connection;
        private string cadenaConexion;

        public ConexionMySql()
        {
            cadenaConexion = "Database = LaTiendaMasVeloz; Datasource = localhost; User id=root; Password = Andrea_12345";
            connection = new MySqlConnection(cadenaConexion);
        }

        public MysqlConnection GetConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return connection;
        }
        }
    }

