namespace AtividadeApp
{
    partial class frmccp
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
            btnvoltar = new Button();
            btnlimpar = new Button();
            btncalcular = new Button();
            txtresulnome = new TextBox();
            txtcodigo = new TextBox();
            lblnome = new Label();
            lblcodigo = new Label();
            txtresulpreco = new TextBox();
            lblpreco = new Label();
            SuspendLayout();
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(343, 215);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 19;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(215, 215);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 18;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(96, 215);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 17;
            btncalcular.Text = "Consultar";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtresulnome
            // 
            txtresulnome.Location = new Point(190, 109);
            txtresulnome.Name = "txtresulnome";
            txtresulnome.ReadOnly = true;
            txtresulnome.Size = new Size(228, 23);
            txtresulnome.TabIndex = 16;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(190, 63);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(100, 23);
            txtcodigo.TabIndex = 15;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(96, 117);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(40, 15);
            lblnome.TabIndex = 14;
            lblnome.Text = "Nome";
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Location = new Point(96, 71);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(46, 15);
            lblcodigo.TabIndex = 13;
            lblcodigo.Text = "Código";
            // 
            // txtresulpreco
            // 
            txtresulpreco.Location = new Point(190, 154);
            txtresulpreco.Name = "txtresulpreco";
            txtresulpreco.ReadOnly = true;
            txtresulpreco.Size = new Size(228, 23);
            txtresulpreco.TabIndex = 21;
            // 
            // lblpreco
            // 
            lblpreco.AutoSize = true;
            lblpreco.Location = new Point(96, 162);
            lblpreco.Name = "lblpreco";
            lblpreco.Size = new Size(37, 15);
            lblpreco.TabIndex = 20;
            lblpreco.Text = "Preço";
            // 
            // frmccp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtresulpreco);
            Controls.Add(lblpreco);
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(btncalcular);
            Controls.Add(txtresulnome);
            Controls.Add(txtcodigo);
            Controls.Add(lblnome);
            Controls.Add(lblcodigo);
            Name = "frmccp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de codigo de produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvoltar;
        private Button btnlimpar;
        private Button btncalcular;
        private TextBox txtresulnome;
        private TextBox txtcodigo;
        private Label lblnome;
        private Label lblcodigo;
        private TextBox txtresulpreco;
        private Label lblpreco;
    }
}