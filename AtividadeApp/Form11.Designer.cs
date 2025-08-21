namespace AtividadeApp
{
    partial class frmabono
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
            lblnome = new Label();
            lblsexo = new Label();
            lblidade = new Label();
            lblsalario = new Label();
            lblsa = new Label();
            txtnome = new TextBox();
            txtsexo = new TextBox();
            txtidade = new TextBox();
            SuspendLayout();
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(95, 65);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(40, 15);
            lblnome.TabIndex = 0;
            lblnome.Text = "Nome";
            // 
            // lblsexo
            // 
            lblsexo.AutoSize = true;
            lblsexo.Location = new Point(95, 96);
            lblsexo.Name = "lblsexo";
            lblsexo.Size = new Size(32, 15);
            lblsexo.TabIndex = 1;
            lblsexo.Text = "Sexo";
            // 
            // lblidade
            // 
            lblidade.AutoSize = true;
            lblidade.Location = new Point(95, 125);
            lblidade.Name = "lblidade";
            lblidade.Size = new Size(36, 15);
            lblidade.TabIndex = 2;
            lblidade.Text = "Idade";
            // 
            // lblsalario
            // 
            lblsalario.AutoSize = true;
            lblsalario.Location = new Point(95, 160);
            lblsalario.Name = "lblsalario";
            lblsalario.Size = new Size(42, 15);
            lblsalario.TabIndex = 3;
            lblsalario.Text = "Salario";
            // 
            // lblsa
            // 
            lblsa.AutoSize = true;
            lblsa.Location = new Point(95, 193);
            lblsa.Name = "lblsa";
            lblsa.Size = new Size(92, 15);
            lblsa.TabIndex = 4;
            lblsa.Text = "Salario + Abono";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(189, 57);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 5;
            // 
            // txtsexo
            // 
            txtsexo.Location = new Point(189, 88);
            txtsexo.Name = "txtsexo";
            txtsexo.Size = new Size(100, 23);
            txtsexo.TabIndex = 6;
            // 
            // txtidade
            // 
            txtidade.Location = new Point(189, 117);
            txtidade.Name = "txtidade";
            txtidade.Size = new Size(100, 23);
            txtidade.TabIndex = 7;
            // 
            // frmabono
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtidade);
            Controls.Add(txtsexo);
            Controls.Add(txtnome);
            Controls.Add(lblsa);
            Controls.Add(lblsalario);
            Controls.Add(lblidade);
            Controls.Add(lblsexo);
            Controls.Add(lblnome);
            Name = "frmabono";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo de abono";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnome;
        private Label lblsexo;
        private Label lblidade;
        private Label lblsalario;
        private Label lblsa;
        private TextBox txtnome;
        private TextBox txtsexo;
        private TextBox txtidade;
    }
}