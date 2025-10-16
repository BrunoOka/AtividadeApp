namespace AtividadeApp
{
    partial class frmfc
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
            lblfc = new Label();
            txtfc = new TextBox();
            btnw = new Button();
            btndw = new Button();
            btnf = new Button();
            btnlimpar = new Button();
            btnvoltar = new Button();
            SuspendLayout();
            // 
            // lblfc
            // 
            lblfc.AutoSize = true;
            lblfc.Location = new Point(135, 36);
            lblfc.Name = "lblfc";
            lblfc.Size = new Size(46, 15);
            lblfc.TabIndex = 0;
            lblfc.Text = "f para c";
            // 
            // txtfc
            // 
            txtfc.Location = new Point(209, 33);
            txtfc.Multiline = true;
            txtfc.Name = "txtfc";
            txtfc.ReadOnly = true;
            txtfc.Size = new Size(112, 159);
            txtfc.TabIndex = 1;
            // 
            // btnw
            // 
            btnw.Location = new Point(112, 213);
            btnw.Name = "btnw";
            btnw.Size = new Size(75, 23);
            btnw.TabIndex = 2;
            btnw.Text = "calc w";
            btnw.UseVisualStyleBackColor = true;
            btnw.Click += btnw_Click;
            // 
            // btndw
            // 
            btndw.Location = new Point(112, 255);
            btndw.Name = "btndw";
            btndw.Size = new Size(75, 23);
            btndw.TabIndex = 3;
            btndw.Text = "calc dw";
            btndw.UseVisualStyleBackColor = true;
            btndw.Click += btndw_Click;
            // 
            // btnf
            // 
            btnf.Location = new Point(112, 294);
            btnf.Name = "btnf";
            btnf.Size = new Size(75, 23);
            btnf.TabIndex = 4;
            btnf.Text = "calc f";
            btnf.UseVisualStyleBackColor = true;
            btnf.Click += button3_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(226, 213);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 5;
            btnlimpar.Text = "limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(337, 213);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 6;
            btnvoltar.Text = "voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // frmfc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(btnf);
            Controls.Add(btndw);
            Controls.Add(btnw);
            Controls.Add(txtfc);
            Controls.Add(lblfc);
            Name = "frmfc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "f para c (10 em 10)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblfc;
        private TextBox txtfc;
        private Button btnw;
        private Button btndw;
        private Button btnf;
        private Button btnlimpar;
        private Button btnvoltar;
    }
}