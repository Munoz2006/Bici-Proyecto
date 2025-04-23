using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.controllers;

namespace Bici_Proyecto
{
    public partial class eliminarEmpleado : Form
    {
        public eliminarEmpleado()
        {
            InitializeComponent();
        }

        private void eliminar_E_Click(object sender, EventArgs e)
        {
            EmpleadoController empleado = new EmpleadoController();
            string resultado = empleado.EliminarEmpleado(cedulaEliminar.Text);
            if (resultado == "Eliminado")
            {
                MessageBox.Show("Empleado eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Error al eliminar empleado");
            }
        }
    }
}
