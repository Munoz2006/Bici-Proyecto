namespace Bici_Proyecto
{
    partial class eliminarEmpleado
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
            cedulaEliminar = new TextBox();
            eliminar_E = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cedulaEliminar
            // 
            cedulaEliminar.Location = new Point(320, 102);
            cedulaEliminar.Name = "cedulaEliminar";
            cedulaEliminar.Size = new Size(200, 23);
            cedulaEliminar.TabIndex = 0;
            // 
            // eliminar_E
            // 
            eliminar_E.Location = new Point(320, 185);
            eliminar_E.Name = "eliminar_E";
            eliminar_E.Size = new Size(195, 32);
            eliminar_E.TabIndex = 1;
            eliminar_E.Text = "Eliminar";
            eliminar_E.UseVisualStyleBackColor = true;
            eliminar_E.Click += eliminar_E_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 66);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 2;
            label1.Text = "Escribir numero de cedula";
            // 
            // eliminarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(eliminar_E);
            Controls.Add(cedulaEliminar);
            Name = "eliminarEmpleado";
            Text = "eliminarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cedulaEliminar;
        private Button eliminar_E;
        private Label label1;
    }
}