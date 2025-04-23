using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo.SqlBD
{
    public class EmpleadoSQL : Conexion
    {
        public int GuardarEmpleado(string cedula, string nombre, string telefono, int salario)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConexion().CreateCommand();
            cmd.CommandText = "INSERT INTO empleado (cedula_empleado, nombre_empleado, telefono_empleado, salario_empleado)" +
                "VALUES ('"+cedula+"', '"+nombre+"', '"+telefono+"', '"+salario+"')";
            
            resultado = cmd.ExecuteNonQuery();
            
            return resultado;
        }
        public int EliminarEmpleado(string cedula)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConexion().CreateCommand();
            cmd.CommandText = "DELETE FROM empleado WHERE cedula_empleado = '" + cedula + "'";

            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }
        public int EditarEmpleado(string cedula, string nombre, string telefono, int salario)
        {
            int resultado = 0;
            MySqlCommand cmd = GetConexion().CreateCommand();
            cmd.CommandText = "UPDATE empleado SET nombre_empleado = '" + nombre +
                              "', telefono_empleado = '" + telefono +
                              "', salario_empleado = '" + salario +
                              "' WHERE cedula_empleado = '" + cedula + "'";

            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }
    }
}
