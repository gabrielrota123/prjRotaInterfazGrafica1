namespace prjRotaInterfazGrafica1
{
    partial class frmProductosFarmacia
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
            lblprfocufarma = new Label();
            llblcantidad = new Label();
            lblnombre = new Label();
            lblquienregistra = new Label();
            lblcarrera = new Label();
            lblprecio = new Label();
            label7 = new Label();
            txtnombre = new TextBox();
            txtquienregistra = new TextBox();
            txtcantidad = new TextBox();
            txtprecio = new TextBox();
            txtcarrera = new TextBox();
            txtiva = new TextBox();
            btnalmacenar = new Button();
            SuspendLayout();
            // 
            // lblprfocufarma
            // 
            lblprfocufarma.AutoSize = true;
            lblprfocufarma.Location = new Point(164, 12);
            lblprfocufarma.Name = "lblprfocufarma";
            lblprfocufarma.Size = new Size(128, 15);
            lblprfocufarma.TabIndex = 0;
            lblprfocufarma.Text = "Productos de Farmacia";
            // 
            // llblcantidad
            // 
            llblcantidad.AutoSize = true;
            llblcantidad.Location = new Point(50, 85);
            llblcantidad.Name = "llblcantidad";
            llblcantidad.Size = new Size(61, 15);
            llblcantidad.TabIndex = 1;
            llblcantidad.Text = "Cantidad :";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(50, 34);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(57, 15);
            lblnombre.TabIndex = 2;
            lblnombre.Text = "Nombre :";
            // 
            // lblquienregistra
            // 
            lblquienregistra.AutoSize = true;
            lblquienregistra.Location = new Point(50, 61);
            lblquienregistra.Name = "lblquienregistra";
            lblquienregistra.Size = new Size(90, 15);
            lblquienregistra.TabIndex = 3;
            lblquienregistra.Text = "Quien Registra :";
            // 
            // lblcarrera
            // 
            lblcarrera.AutoSize = true;
            lblcarrera.Location = new Point(50, 111);
            lblcarrera.Name = "lblcarrera";
            lblcarrera.Size = new Size(51, 15);
            lblcarrera.TabIndex = 4;
            lblcarrera.Text = "Carrera :";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Location = new Point(50, 140);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(46, 15);
            lblprecio.TabIndex = 5;
            lblprecio.Text = "Precio :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 169);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 6;
            label7.Text = "Precio con iva : ";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(173, 26);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 8;
            // 
            // txtquienregistra
            // 
            txtquienregistra.Location = new Point(173, 53);
            txtquienregistra.Name = "txtquienregistra";
            txtquienregistra.Size = new Size(100, 23);
            txtquienregistra.TabIndex = 9;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(173, 77);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(100, 23);
            txtcantidad.TabIndex = 10;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(173, 132);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(100, 23);
            txtprecio.TabIndex = 11;
            // 
            // txtcarrera
            // 
            txtcarrera.Location = new Point(173, 103);
            txtcarrera.Name = "txtcarrera";
            txtcarrera.Size = new Size(100, 23);
            txtcarrera.TabIndex = 12;
            // 
            // txtiva
            // 
            txtiva.Location = new Point(173, 161);
            txtiva.Name = "txtiva";
            txtiva.Size = new Size(100, 23);
            txtiva.TabIndex = 13;
            // 
            // btnalmacenar
            // 
            btnalmacenar.Location = new Point(185, 204);
            btnalmacenar.Name = "btnalmacenar";
            btnalmacenar.Size = new Size(75, 23);
            btnalmacenar.TabIndex = 14;
            btnalmacenar.Text = "Almacenar";
            btnalmacenar.UseVisualStyleBackColor = true;
            // 
            // frmProductosFarmacia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnalmacenar);
            Controls.Add(txtiva);
            Controls.Add(txtcarrera);
            Controls.Add(txtprecio);
            Controls.Add(txtcantidad);
            Controls.Add(txtquienregistra);
            Controls.Add(txtnombre);
            Controls.Add(label7);
            Controls.Add(lblprecio);
            Controls.Add(lblcarrera);
            Controls.Add(lblquienregistra);
            Controls.Add(lblnombre);
            Controls.Add(llblcantidad);
            Controls.Add(lblprfocufarma);
            Name = "frmProductosFarmacia";
            Text = "frmProductosFarmacia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblprfocufarma;
        private Label llblcantidad;
        private Label lblnombre;
        private Label lblquienregistra;
        private Label lblcarrera;
        private Label lblprecio;
        private Label label7;
        private TextBox txtnombre;
        private TextBox txtquienregistra;
        private TextBox txtcantidad;
        private TextBox txtprecio;
        private TextBox txtcarrera;
        private TextBox txtiva;
        private Button btnalmacenar;
    }
}