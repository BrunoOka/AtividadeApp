namespace AtividadeApp
{
    partial class frmrealdolar
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
            lblreal = new Label();
            txtvalorreais = new TextBox();
            btncalcular = new Button();
            lblcambio = new Label();
            lblvalor = new Label();
            btnlimpar = new Button();
            btnvoltar = new Button();
            txtcambio = new TextBox();
            txtvalordolares = new TextBox();
            SuspendLayout();
            // 
            // lblreal
            // 
            lblreal.AutoSize = true;
            lblreal.Location = new Point(95, 65);
            lblreal.Name = "lblreal";
            lblreal.Size = new Size(80, 15);
            lblreal.TabIndex = 0;
            lblreal.Text = "Valor em reais";
            // 
            // txtvalorreais
            // 
            txtvalorreais.Location = new Point(282, 62);
            txtvalorreais.Name = "txtvalorreais";
            txtvalorreais.Size = new Size(100, 23);
            txtvalorreais.TabIndex = 1;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(75, 334);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 2;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // lblcambio
            // 
            lblcambio.AutoSize = true;
            lblcambio.Location = new Point(95, 139);
            lblcambio.Name = "lblcambio";
            lblcambio.Size = new Size(96, 15);
            lblcambio.TabIndex = 3;
            lblcambio.Text = "Câmbio do dólar";
            // 
            // lblvalor
            // 
            lblvalor.AutoSize = true;
            lblvalor.Location = new Point(95, 211);
            lblvalor.Name = "lblvalor";
            lblvalor.Size = new Size(94, 15);
            lblvalor.TabIndex = 4;
            lblvalor.Text = "valor em dólares";
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(329, 334);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 5;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(555, 334);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 6;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // txtcambio
            // 
            txtcambio.Location = new Point(282, 136);
            txtcambio.Name = "txtcambio";
            txtcambio.Size = new Size(100, 23);
            txtcambio.TabIndex = 7;
            // 
            // txtvalordolares
            // 
            txtvalordolares.Location = new Point(282, 208);
            txtvalordolares.Name = "txtvalordolares";
            txtvalordolares.ReadOnly = true;
            txtvalordolares.Size = new Size(100, 23);
            txtvalordolares.TabIndex = 8;
            // 
            // frmrealdolar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtvalordolares);
            Controls.Add(txtcambio);
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(lblvalor);
            Controls.Add(lblcambio);
            Controls.Add(btncalcular);
            Controls.Add(txtvalorreais);
            Controls.Add(lblreal);
            Name = "frmrealdolar";
            Text = "Valor em real convertido para dólar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblreal;
        private TextBox txtvalorreais;
        private Button btncalcular;
        private Label lblcambio;
        private Label lblvalor;
        private Button btnlimpar;
        private Button btnvoltar;
        private TextBox txtcambio;
        private TextBox txtvalordolares;
    }
}