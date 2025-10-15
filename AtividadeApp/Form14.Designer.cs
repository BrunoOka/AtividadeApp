namespace AtividadeApp
{
    partial class frmtabuada
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
            lblnum = new Label();
            lbltabuada = new Label();
            txtnum = new TextBox();
            txtresult = new TextBox();
            btnw = new Button();
            btndw = new Button();
            btnf = new Button();
            btnvoltar = new Button();
            btnlimpar = new Button();
            SuspendLayout();
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Location = new Point(129, 67);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(51, 15);
            lblnum.TabIndex = 0;
            lblnum.Text = "Número";
            // 
            // lbltabuada
            // 
            lbltabuada.AutoSize = true;
            lbltabuada.Location = new Point(129, 107);
            lbltabuada.Name = "lbltabuada";
            lbltabuada.Size = new Size(50, 15);
            lbltabuada.TabIndex = 1;
            lbltabuada.Text = "tabuada";
            // 
            // txtnum
            // 
            txtnum.Location = new Point(198, 59);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(100, 23);
            txtnum.TabIndex = 2;
            // 
            // txtresult
            // 
            txtresult.Location = new Point(198, 99);
            txtresult.Multiline = true;
            txtresult.Name = "txtresult";
            txtresult.ReadOnly = true;
            txtresult.Size = new Size(222, 185);
            txtresult.TabIndex = 3;
            // 
            // btnw
            // 
            btnw.Location = new Point(129, 315);
            btnw.Name = "btnw";
            btnw.Size = new Size(75, 23);
            btnw.TabIndex = 4;
            btnw.Text = "calc w";
            btnw.UseVisualStyleBackColor = true;
            btnw.Click += btnw_Click;
            // 
            // btndw
            // 
            btndw.Location = new Point(129, 363);
            btndw.Name = "btndw";
            btndw.Size = new Size(75, 23);
            btndw.TabIndex = 5;
            btndw.Text = "calc dw";
            btndw.UseVisualStyleBackColor = true;
            btndw.Click += btndw_Click;
            // 
            // btnf
            // 
            btnf.Location = new Point(129, 405);
            btnf.Name = "btnf";
            btnf.Size = new Size(75, 23);
            btnf.TabIndex = 6;
            btnf.Text = "calc f";
            btnf.UseVisualStyleBackColor = true;
            btnf.Click += btnf_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(385, 315);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 7;
            btnvoltar.Text = "voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(249, 315);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 8;
            btnlimpar.Text = "limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // frmtabuada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnlimpar);
            Controls.Add(btnvoltar);
            Controls.Add(btnf);
            Controls.Add(btndw);
            Controls.Add(btnw);
            Controls.Add(txtresult);
            Controls.Add(txtnum);
            Controls.Add(lbltabuada);
            Controls.Add(lblnum);
            Name = "frmtabuada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabuada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnum;
        private Label lbltabuada;
        private TextBox txtnum;
        private TextBox txtresult;
        private Button btnw;
        private Button btndw;
        private Button btnf;
        private Button btnvoltar;
        private Button btnlimpar;
    }
}