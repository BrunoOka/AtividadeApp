namespace AtividadeApp
{
    partial class frmimc
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
            txtresul = new TextBox();
            lblresul = new Label();
            btnvoltar = new Button();
            btnlimpar = new Button();
            btncalcular = new Button();
            txtpeso = new TextBox();
            txtaltura = new TextBox();
            lblpeso = new Label();
            lblaltura = new Label();
            SuspendLayout();
            // 
            // txtresul
            // 
            txtresul.Location = new Point(191, 155);
            txtresul.Name = "txtresul";
            txtresul.ReadOnly = true;
            txtresul.Size = new Size(228, 23);
            txtresul.TabIndex = 30;
            // 
            // lblresul
            // 
            lblresul.AutoSize = true;
            lblresul.Location = new Point(18, 163);
            lblresul.Name = "lblresul";
            lblresul.Size = new Size(116, 15);
            lblresul.TabIndex = 29;
            lblresul.Text = "Classificação de IMC";
            lblresul.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(344, 216);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 28;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(216, 216);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 27;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(97, 216);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 26;
            btncalcular.Text = "Consultar";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtpeso
            // 
            txtpeso.Location = new Point(191, 110);
            txtpeso.Name = "txtpeso";
            txtpeso.Size = new Size(100, 23);
            txtpeso.TabIndex = 25;
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(191, 64);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(100, 23);
            txtaltura.TabIndex = 24;
            // 
            // lblpeso
            // 
            lblpeso.AutoSize = true;
            lblpeso.Location = new Point(47, 118);
            lblpeso.Name = "lblpeso";
            lblpeso.Size = new Size(87, 15);
            lblpeso.TabIndex = 23;
            lblpeso.Text = "Peso em quilos";
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Location = new Point(35, 72);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(99, 15);
            lblaltura.TabIndex = 22;
            lblaltura.Text = "Altura em metros";
            // 
            // frmimc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtresul);
            Controls.Add(lblresul);
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(btncalcular);
            Controls.Add(txtpeso);
            Controls.Add(txtaltura);
            Controls.Add(lblpeso);
            Controls.Add(lblaltura);
            Name = "frmimc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de IMC";
            Load += frmimc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtresul;
        private Label lblresul;
        private Button btnvoltar;
        private Button btnlimpar;
        private Button btncalcular;
        private TextBox txtpeso;
        private TextBox txtaltura;
        private Label lblpeso;
        private Label lblaltura;
    }
}