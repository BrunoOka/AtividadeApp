namespace AtividadeApp
{
    partial class frmdl
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
            lblvelocidade = new Label();
            lbldistancia = new Label();
            lbltg = new Label();
            lbllg = new Label();
            txtvelo = new TextBox();
            txtdist = new TextBox();
            txttemp = new TextBox();
            txtlitros = new TextBox();
            btncalcular = new Button();
            btnlimpar = new Button();
            btnvoltar = new Button();
            SuspendLayout();
            // 
            // lblvelocidade
            // 
            lblvelocidade.AutoSize = true;
            lblvelocidade.Location = new Point(84, 31);
            lblvelocidade.Name = "lblvelocidade";
            lblvelocidade.Size = new Size(100, 15);
            lblvelocidade.TabIndex = 0;
            lblvelocidade.Text = "Velocidade Média";
            // 
            // lbldistancia
            // 
            lbldistancia.AutoSize = true;
            lbldistancia.Location = new Point(84, 127);
            lbldistancia.Name = "lbldistancia";
            lbldistancia.Size = new Size(55, 15);
            lbldistancia.TabIndex = 1;
            lbldistancia.Text = "Distância";
            // 
            // lbltg
            // 
            lbltg.AutoSize = true;
            lbltg.Location = new Point(84, 79);
            lbltg.Name = "lbltg";
            lbltg.Size = new Size(75, 15);
            lbltg.TabIndex = 2;
            lbltg.Text = "Tempo gasto";
            // 
            // lbllg
            // 
            lbllg.AutoSize = true;
            lbllg.Location = new Point(84, 172);
            lbllg.Name = "lbllg";
            lbllg.Size = new Size(73, 15);
            lbllg.TabIndex = 3;
            lbllg.Text = "Litros gastos";
            // 
            // txtvelo
            // 
            txtvelo.Location = new Point(250, 31);
            txtvelo.Name = "txtvelo";
            txtvelo.Size = new Size(100, 23);
            txtvelo.TabIndex = 4;
            // 
            // txtdist
            // 
            txtdist.Location = new Point(250, 119);
            txtdist.Name = "txtdist";
            txtdist.ReadOnly = true;
            txtdist.Size = new Size(100, 23);
            txtdist.TabIndex = 5;
            // 
            // txttemp
            // 
            txttemp.Location = new Point(250, 79);
            txttemp.Name = "txttemp";
            txttemp.Size = new Size(100, 23);
            txttemp.TabIndex = 6;
            // 
            // txtlitros
            // 
            txtlitros.Location = new Point(250, 169);
            txtlitros.Name = "txtlitros";
            txtlitros.ReadOnly = true;
            txtlitros.Size = new Size(100, 23);
            txtlitros.TabIndex = 7;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(109, 285);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 8;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(317, 285);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 9;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(515, 285);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 10;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // frmdl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(btncalcular);
            Controls.Add(txtlitros);
            Controls.Add(txttemp);
            Controls.Add(txtdist);
            Controls.Add(txtvelo);
            Controls.Add(lbllg);
            Controls.Add(lbltg);
            Controls.Add(lbldistancia);
            Controls.Add(lblvelocidade);
            Name = "frmdl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo de distância e litros gastos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblvelocidade;
        private Label lbldistancia;
        private Label lbltg;
        private Label lbllg;
        private TextBox txtvelo;
        private TextBox txtdist;
        private TextBox txttemp;
        private TextBox txtlitros;
        private Button btncalcular;
        private Button btnlimpar;
        private Button btnvoltar;
    }
}