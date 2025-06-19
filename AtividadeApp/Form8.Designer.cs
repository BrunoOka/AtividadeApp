namespace AtividadeApp
{
    partial class frmretangulo
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
            lblbase = new Label();
            lblaltura = new Label();
            lblresultado = new Label();
            txtbase = new TextBox();
            txtaltura = new TextBox();
            txtresultado = new TextBox();
            btncalcular = new Button();
            btnlimpar = new Button();
            SuspendLayout();
            // 
            // lblbase
            // 
            lblbase.AutoSize = true;
            lblbase.Location = new Point(95, 65);
            lblbase.Name = "lblbase";
            lblbase.Size = new Size(31, 15);
            lblbase.TabIndex = 0;
            lblbase.Text = "Base";
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Location = new Point(95, 112);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(39, 15);
            lblaltura.TabIndex = 1;
            lblaltura.Text = "Altura";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(95, 157);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(59, 15);
            lblresultado.TabIndex = 2;
            lblresultado.Text = "Resultado";
            // 
            // txtbase
            // 
            txtbase.Location = new Point(199, 62);
            txtbase.Name = "txtbase";
            txtbase.Size = new Size(100, 23);
            txtbase.TabIndex = 3;
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(199, 104);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(100, 23);
            txtaltura.TabIndex = 4;
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(199, 154);
            txtresultado.Name = "txtresultado";
            txtresultado.ReadOnly = true;
            txtresultado.Size = new Size(100, 23);
            txtresultado.TabIndex = 5;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(95, 223);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 9;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(258, 223);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 10;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            // 
            // frmretangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnlimpar);
            Controls.Add(btncalcular);
            Controls.Add(txtresultado);
            Controls.Add(txtaltura);
            Controls.Add(txtbase);
            Controls.Add(lblresultado);
            Controls.Add(lblaltura);
            Controls.Add(lblbase);
            Name = "frmretangulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Área do retangulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblbase;
        private Label lblaltura;
        private Label lblresultado;
        private TextBox txtbase;
        private TextBox txtaltura;
        private TextBox txtresultado;
        private Button btncalcular;
        private Button btnlimpar;
    }
}