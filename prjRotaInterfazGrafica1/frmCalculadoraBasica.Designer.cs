namespace prjRotaInterfazGrafica1
{
    partial class frmCalculadoraBasica
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
            lblcalculadora = new Label();
            lblnumero1 = new Label();
            lblnumero2 = new Label();
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            btnmas = new Button();
            btnresta = new Button();
            btnmulti = new Button();
            btndivi = new Button();
            lblresultado = new Label();
            txtresultado = new TextBox();
            SuspendLayout();
            // 
            // lblcalculadora
            // 
            lblcalculadora.AutoSize = true;
            lblcalculadora.Font = new Font("Segoe UI", 11F);
            lblcalculadora.Location = new Point(142, 21);
            lblcalculadora.Name = "lblcalculadora";
            lblcalculadora.Size = new Size(88, 20);
            lblcalculadora.TabIndex = 0;
            lblcalculadora.Text = "Calculadora";
            // 
            // lblnumero1
            // 
            lblnumero1.AutoSize = true;
            lblnumero1.Location = new Point(83, 48);
            lblnumero1.Name = "lblnumero1";
            lblnumero1.Size = new Size(66, 15);
            lblnumero1.TabIndex = 1;
            lblnumero1.Text = "Numero 1 :";
            // 
            // lblnumero2
            // 
            lblnumero2.AutoSize = true;
            lblnumero2.Location = new Point(82, 78);
            lblnumero2.Name = "lblnumero2";
            lblnumero2.Size = new Size(66, 15);
            lblnumero2.TabIndex = 2;
            lblnumero2.Text = "Numero 2 :";
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(155, 44);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(58, 23);
            txtnum1.TabIndex = 3;
            txtnum1.Text = "[________] ";
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(155, 73);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(58, 23);
            txtnum2.TabIndex = 4;
            txtnum2.Text = "[________] ";
            // 
            // btnmas
            // 
            btnmas.Location = new Point(114, 119);
            btnmas.Name = "btnmas";
            btnmas.Size = new Size(43, 23);
            btnmas.TabIndex = 5;
            btnmas.Text = "[ + ]";
            btnmas.UseVisualStyleBackColor = true;
            // 
            // btnresta
            // 
            btnresta.Location = new Point(163, 119);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(36, 23);
            btnresta.TabIndex = 6;
            btnresta.Text = "[ - ]";
            btnresta.UseVisualStyleBackColor = true;
            // 
            // btnmulti
            // 
            btnmulti.Location = new Point(205, 119);
            btnmulti.Name = "btnmulti";
            btnmulti.Size = new Size(42, 23);
            btnmulti.TabIndex = 7;
            btnmulti.Text = "[ × ]";
            btnmulti.UseVisualStyleBackColor = true;
            // 
            // btndivi
            // 
            btndivi.Location = new Point(253, 119);
            btndivi.Name = "btndivi";
            btndivi.Size = new Size(41, 23);
            btndivi.TabIndex = 8;
            btndivi.Text = "[ ÷ ]    ";
            btndivi.UseVisualStyleBackColor = true;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(91, 159);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(65, 15);
            lblresultado.TabIndex = 9;
            lblresultado.Text = "Resultado :";
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(172, 151);
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(58, 23);
            txtresultado.TabIndex = 10;
            txtresultado.Text = "[________] ";
            // 
            // frmCalculadoraBasica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtresultado);
            Controls.Add(lblresultado);
            Controls.Add(btndivi);
            Controls.Add(btnmulti);
            Controls.Add(btnresta);
            Controls.Add(btnmas);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            Controls.Add(lblnumero2);
            Controls.Add(lblnumero1);
            Controls.Add(lblcalculadora);
            Name = "frmCalculadoraBasica";
            Text = "frmCalculadoraBasica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcalculadora;
        private Label lblnumero1;
        private Label lblnumero2;
        private TextBox txtnum1;
        private TextBox txtnum2;
        private Button btnmas;
        private Button btnresta;
        private Button btnmulti;
        private Button btndivi;
        private Label lblresultado;
        private TextBox txtresultado;
    }
}