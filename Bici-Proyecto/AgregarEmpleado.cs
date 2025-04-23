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
using Modelo.Entity;

namespace Bici_Proyecto
{
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            EmpleadoController empleado = new EmpleadoController();
            int salarioN = Int32.Parse(salario.Text);
            string resultado = empleado.GuardarEmpleado(cedula.Text, nombre.Text, telefono.Text, salarioN);

            MessageBox.Show(resultado);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            EmpleadoController empleado = new EmpleadoController();
            int salarioN = Int32.Parse(salario.Text);
            string resultado = empleado.EditarEmpleado(cedula.Text, nombre.Text, telefono.Text, salarioN);

            MessageBox.Show(resultado);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            eliminarEmpleado eliminar = new eliminarEmpleado();
            eliminar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoController empleado = new EmpleadoController();
            List<EmpleadoEntity> empleados = empleado.ObtenerEmpleados();
            string resultado = "";
            foreach (EmpleadoEntity emp in empleados)
            {
                resultado += "Cedula: " + emp.cedula_empleado + "\n" +
                            "Nombre: " + emp.nombre_empleado + "\n" +
                            "Telefono: " + emp.telefono_empleado + "\n" +
                            "Salario: " + emp.salario_empleado + "\n\n";
            }
            resultadoE.Text = resultado;
        }
    }
}
