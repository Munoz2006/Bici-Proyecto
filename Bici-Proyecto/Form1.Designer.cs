namespace Bici_Proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            btnA_em = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(69, 169);
            button1.Name = "button1";
            button1.Size = new Size(167, 51);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnA_em
            // 
            btnA_em.Location = new Point(309, 262);
            btnA_em.Name = "btnA_em";
            btnA_em.Size = new Size(167, 51);
            btnA_em.TabIndex = 1;
            btnA_em.Text = "Agregar Empleado";
            btnA_em.UseVisualStyleBackColor = true;
            btnA_em.Click += btnA_em_Click;
            // 
            // button3
            // 
            button3.Location = new Point(569, 169);
            button3.Name = "button3";
            button3.Size = new Size(167, 51);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(btnA_em);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnA_em;
        private Button button3;
    }
}
