namespace Bici_Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnA_em_Click(object sender, EventArgs e)
        {
            AgregarEmpleado agregar = new AgregarEmpleado();
            agregar.ShowDialog();
        }
    }
}
