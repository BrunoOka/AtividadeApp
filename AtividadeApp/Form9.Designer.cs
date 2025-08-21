namespace AtividadeApp
{
    partial class frmrtj
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
            lbltotpub = new Label();
            lblrenda = new Label();
            txttotpub = new TextBox();
            txtrenda = new TextBox();
            btncalcular = new Button();
            btnlimpar = new Button();
            btnvoltar = new Button();
            SuspendLayout();
            // 
            // lbltotpub
            // 
            lbltotpub.AutoSize = true;
            lbltotpub.Location = new Point(95, 65);
            lbltotpub.Name = "lbltotpub";
            lbltotpub.Size = new Size(74, 15);
            lbltotpub.TabIndex = 0;
            lbltotpub.Text = "total publico";
            // 
            // lblrenda
            // 
            lblrenda.AutoSize = true;
            lblrenda.Location = new Point(95, 116);
            lblrenda.Name = "lblrenda";
            lblrenda.Size = new Size(37, 15);
            lblrenda.TabIndex = 1;
            lblrenda.Text = "renda";
            // 
            // txttotpub
            // 
            txttotpub.Location = new Point(208, 57);
            txttotpub.Name = "txttotpub";
            txttotpub.Size = new Size(100, 23);
            txttotpub.TabIndex = 2;
            // 
            // txtrenda
            // 
            txtrenda.Location = new Point(208, 108);
            txtrenda.Name = "txtrenda";
            txtrenda.ReadOnly = true;
            txtrenda.Size = new Size(100, 23);
            txtrenda.TabIndex = 3;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(95, 189);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(233, 189);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 5;
            btnlimpar.Text = "limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(371, 189);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 6;
            btnvoltar.Text = "voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // frmrtj
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(btncalcular);
            Controls.Add(txtrenda);
            Controls.Add(txttotpub);
            Controls.Add(lblrenda);
            Controls.Add(lbltotpub);
            Name = "frmrtj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Renda total jogo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltotpub;
        private Label lblrenda;
        private TextBox txttotpub;
        private TextBox txtrenda;
        private Button btncalcular;
        private Button btnlimpar;
        private Button btnvoltar;
    }
}