namespace Bici_Proyecto
{
    partial class AgregarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            salario = new TextBox();
            telefono = new TextBox();
            cedula = new TextBox();
            nombre = new TextBox();
            btn_enviar = new Button();
            btn_editar = new Button();
            btn_eliminar = new Button();
            panel1 = new Panel();
            resultadoE = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // salario
            // 
            salario.Location = new Point(110, 289);
            salario.Name = "salario";
            salario.Size = new Size(187, 23);
            salario.TabIndex = 0;
            salario.Text = "Salario";
            // 
            // telefono
            // 
            telefono.Location = new Point(110, 198);
            telefono.Name = "telefono";
            telefono.Size = new Size(187, 23);
            telefono.TabIndex = 1;
            telefono.Text = "Telefono";
            // 
            // cedula
            // 
            cedula.Location = new Point(110, 36);
            cedula.Name = "cedula";
            cedula.Size = new Size(187, 23);
            cedula.TabIndex = 2;
            cedula.Text = "Cedula";
            // 
            // nombre
            // 
            nombre.Location = new Point(110, 117);
            nombre.Name = "nombre";
            nombre.Size = new Size(187, 23);
            nombre.TabIndex = 3;
            nombre.Text = "Nombre";
            // 
            // btn_enviar
            // 
            btn_enviar.Location = new Point(35, 366);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(142, 39);
            btn_enviar.TabIndex = 4;
            btn_enviar.Text = "Agregar";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(225, 366);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(142, 39);
            btn_editar.TabIndex = 5;
            btn_editar.Text = "Editar Empleado";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(632, 27);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(142, 39);
            btn_eliminar.TabIndex = 6;
            btn_eliminar.Text = "Eliminar Empleado";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(resultadoE);
            panel1.Location = new Point(434, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 238);
            panel1.TabIndex = 7;
            // 
            // resultadoE
            // 
            resultadoE.AutoSize = true;
            resultadoE.Location = new Point(138, 27);
            resultadoE.Name = "resultadoE";
            resultadoE.Size = new Size(38, 15);
            resultadoE.TabIndex = 0;
            resultadoE.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(523, 376);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 8;
            button1.Text = "Mostrar Empleados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(btn_enviar);
            Controls.Add(nombre);
            Controls.Add(cedula);
            Controls.Add(telefono);
            Controls.Add(salario);
            Name = "AgregarEmpleado";
            Text = "AgregarEmpleado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox salario;
        private TextBox telefono;
        private TextBox cedula;
        private TextBox nombre;
        private Button btn_enviar;
        private Button btn_editar;
        private Button btn_eliminar;
        private Panel panel1;
        private Label resultadoE;
        private Button button1;
    }
}