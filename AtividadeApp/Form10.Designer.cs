namespace AtividadeApp
{
    partial class frmcvl
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
            lbllivro = new Label();
            lblvp = new Label();
            txtlivros = new TextBox();
            txtresultado = new TextBox();
            btncalcular = new Button();
            btnlimpar = new Button();
            btnvoltar = new Button();
            SuspendLayout();
            // 
            // lbllivro
            // 
            lbllivro.AutoSize = true;
            lbllivro.Location = new Point(95, 65);
            lbllivro.Name = "lbllivro";
            lbllivro.Size = new Size(38, 15);
            lbllivro.TabIndex = 0;
            lbllivro.Text = "Livros";
            // 
            // lblvp
            // 
            lblvp.AutoSize = true;
            lblvp.Location = new Point(95, 111);
            lblvp.Name = "lblvp";
            lblvp.Size = new Size(90, 15);
            lblvp.TabIndex = 1;
            lblvp.Text = "Valor a ser pago";
            // 
            // txtlivros
            // 
            txtlivros.Location = new Point(237, 57);
            txtlivros.Name = "txtlivros";
            txtlivros.Size = new Size(100, 23);
            txtlivros.TabIndex = 2;
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(237, 103);
            txtresultado.Name = "txtresultado";
            txtresultado.ReadOnly = true;
            txtresultado.Size = new Size(100, 23);
            txtresultado.TabIndex = 3;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(95, 190);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(237, 190);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 5;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(386, 190);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 6;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            // 
            // frmcvl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(btncalcular);
            Controls.Add(txtresultado);
            Controls.Add(txtlivros);
            Controls.Add(lblvp);
            Controls.Add(lbllivro);
            Name = "frmcvl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo venda livro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllivro;
        private Label lblvp;
        private TextBox txtlivros;
        private TextBox txtresultado;
        private Button btncalcular;
        private Button btnlimpar;
        private Button btnvoltar;
    }
}