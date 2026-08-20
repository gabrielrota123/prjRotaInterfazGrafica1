namespace prjRotaInterfazGrafica1
{
    partial class botondecomando
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
            txtcarrera = new TextBox();
            txtedad = new TextBox();
            txtapellido = new TextBox();
            txtnombre = new TextBox();
            lblcarrera = new Label();
            lbledad = new Label();
            lblapellido = new Label();
            lblnombre = new Label();
            btnpresentar = new Button();
            SuspendLayout();
            // 
            // txtcarrera
            // 
            txtcarrera.Location = new Point(98, 101);
            txtcarrera.Name = "txtcarrera";
            txtcarrera.Size = new Size(100, 23);
            txtcarrera.TabIndex = 15;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(98, 75);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(100, 23);
            txtedad.TabIndex = 14;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(98, 47);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(100, 23);
            txtapellido.TabIndex = 13;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(98, 22);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 12;
            // 
            // lblcarrera
            // 
            lblcarrera.AutoSize = true;
            lblcarrera.Location = new Point(27, 109);
            lblcarrera.Name = "lblcarrera";
            lblcarrera.Size = new Size(45, 15);
            lblcarrera.TabIndex = 11;
            lblcarrera.Text = "Carrera";
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(27, 83);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(33, 15);
            lbledad.TabIndex = 10;
            lbledad.Text = "Edad";
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Location = new Point(27, 55);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(51, 15);
            lblapellido.TabIndex = 9;
            lblapellido.Text = "Apellido";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(27, 30);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(51, 15);
            lblnombre.TabIndex = 8;
            lblnombre.Text = "Nombre";
            // 
            // btnpresentar
            // 
            btnpresentar.Location = new Point(225, 142);
            btnpresentar.Name = "btnpresentar";
            btnpresentar.Size = new Size(75, 23);
            btnpresentar.TabIndex = 16;
            btnpresentar.Text = "Presentar";
            btnpresentar.UseVisualStyleBackColor = true;
            // 
            // botondecomando
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnpresentar);
            Controls.Add(txtcarrera);
            Controls.Add(txtedad);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(lblcarrera);
            Controls.Add(lbledad);
            Controls.Add(lblapellido);
            Controls.Add(lblnombre);
            Name = "botondecomando";
            Text = "caja de texto ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcarrera;
        private TextBox txtedad;
        private TextBox txtapellido;
        private TextBox txtnombre;
        private Label lblcarrera;
        private Label lbledad;
        private Label lblapellido;
        private Label lblnombre;
        private Button btnpresentar;
    }
}