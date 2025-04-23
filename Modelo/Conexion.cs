using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Modelo
{
    public  class Conexion
    {
        public MySqlConnection conexion;
        private string cadena;

        public Conexion()
        {
            cadena = "Database=thebigwheel;Datasource=localhost; User Id=root;Password=";
            conexion = new MySqlConnection(cadena);
        }

        public MySqlConnection GetConexion()
        {
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
            }
            catch(Exception e) { 
                Console.WriteLine("Error al conectar a la base de datos: " + e.Message);
            }
            return conexion;
        }
    }
}
