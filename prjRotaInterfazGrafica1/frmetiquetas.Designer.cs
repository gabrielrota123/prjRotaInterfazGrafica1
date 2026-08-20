namespace prjRotaInterfazGrafica1
{
    partial class frmetiquetas
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
            lblnombre = new Label();
            lblapellido = new Label();
            lbledad = new Label();
            lblcarrera = new Label();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtedad = new TextBox();
            txtcarrera = new TextBox();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(24, 9);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(51, 15);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre";
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(24, 34);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(51, 15);
            lblapellido.TabIndex = 1;
            lblapellido.Text = "Apellido";
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(24, 62);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(33, 15);
            lbledad.TabIndex = 2;
            lbledad.Text = "Edad";
            // 
            // lblcarrera
            // 
            lblcarrera.AutoSize = true;
            lblcarrera.Location = new Point(24, 88);
            lblcarrera.Name = "lblcarrera";
            lblcarrera.Size = new Size(45, 15);
            lblcarrera.TabIndex = 3;
            lblcarrera.Text = "Carrera";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(95, 1);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 4;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(95, 26);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(100, 23);
            txtapellido.TabIndex = 5;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(95, 54);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(100, 23);
            txtedad.TabIndex = 6;
            // 
            // txtcarrera
            // 
            txtcarrera.Location = new Point(95, 80);
            txtcarrera.Name = "txtcarrera";
            txtcarrera.Size = new Size(100, 23);
            txtcarrera.TabIndex = 7;
            // 
            // frmetiquetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtcarrera);
            Controls.Add(txtedad);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(lblcarrera);
            Controls.Add(lbledad);
            Controls.Add(lblapellido);
            Controls.Add(lblnombre);
            Name = "frmetiquetas";
            Text = "frmetiquetas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnombre;
        private Label lblapellido;
        private Label lbledad;
        private Label lblcarrera;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtedad;
        private TextBox txtcarrera;
    }
}