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
            SuspendLayout();
            // 
            // salario
            // 
            salario.Location = new Point(318, 245);
            salario.Name = "salario";
            salario.Size = new Size(187, 23);
            salario.TabIndex = 0;
            salario.Text = "Salario";
            // 
            // telefono
            // 
            telefono.Location = new Point(318, 171);
            telefono.Name = "telefono";
            telefono.Size = new Size(187, 23);
            telefono.TabIndex = 1;
            telefono.Text = "Telefono";
            // 
            // cedula
            // 
            cedula.Location = new Point(318, 31);
            cedula.Name = "cedula";
            cedula.Size = new Size(187, 23);
            cedula.TabIndex = 2;
            cedula.Text = "Cedula";
            // 
            // nombre
            // 
            nombre.Location = new Point(318, 102);
            nombre.Name = "nombre";
            nombre.Size = new Size(187, 23);
            nombre.TabIndex = 3;
            nombre.Text = "Nombre";
            // 
            // btn_enviar
            // 
            btn_enviar.Location = new Point(336, 317);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(142, 39);
            btn_enviar.TabIndex = 4;
            btn_enviar.Text = "Agregar";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(114, 317);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(142, 39);
            btn_editar.TabIndex = 5;
            btn_editar.Text = "Editar Empleado";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(573, 317);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(142, 39);
            btn_eliminar.TabIndex = 6;
            btn_eliminar.Text = "Eliminar Empleado";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // AgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_editar);
            Controls.Add(btn_enviar);
            Controls.Add(nombre);
            Controls.Add(cedula);
            Controls.Add(telefono);
            Controls.Add(salario);
            Name = "AgregarEmpleado";
            Text = "AgregarEmpleado";
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
    }
}