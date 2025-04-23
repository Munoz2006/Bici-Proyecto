using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Modelo.Entity;
using Modelo.SqlBD;

namespace Logica.controllers
{
    public class EmpleadoController
    {
        public string GuardarEmpleado(string cedula, string nombre, string telefono, int salario)
        {
            string resultado = "";
            EmpleadoSQL empleadoSQL = new EmpleadoSQL();
            int filasAfectadas = empleadoSQL.GuardarEmpleado(cedula, nombre, telefono, salario);

            if (filasAfectadas >0)
            {
                resultado = "Guardado";
            }
            else
            {
                resultado = "Error al guardar";
            }
                return resultado;
        }
        public string EliminarEmpleado(string cedula)
        {
            string resultado = "";
            EmpleadoSQL empleadoSQL = new EmpleadoSQL();
            int filasAfectadas = empleadoSQL.EliminarEmpleado(cedula);
            if (filasAfectadas > 0)
            {
                resultado = "Eliminado";
            }
            else
            {
                resultado = "Error al eliminar";
            }
            return resultado;
        }
        public string EditarEmpleado(string cedula, string nombre, string telefono, int salario)
        {
            string resultado = "";
            EmpleadoSQL empleadoSQL = new EmpleadoSQL();
            int filasAfectadas = empleadoSQL.EditarEmpleado(cedula, nombre, telefono, salario);
            if (filasAfectadas > 0)
            {
                resultado = "Editado";
            }
            else
            {
                resultado = "Error al editar";
            }
            return resultado;
        }
        public List<EmpleadoEntity> ObtenerEmpleados()
        {
            EmpleadoSQL empleadoSQL = new EmpleadoSQL();
            List<EmpleadoEntity> empleados = empleadoSQL.ObtenerEmpleados();
            return empleados;
        }
    }
}
