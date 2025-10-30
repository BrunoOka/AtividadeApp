namespace AtividadeApp
{
    partial class frmar
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
            lblac = new Label();
            lblar = new Label();
            txtar = new TextBox();
            txtac = new TextBox();
            btncalcdw = new Button();
            btncalcf = new Button();
            btnlimpar = new Button();
            btnvoltar = new Button();
            txtqc = new TextBox();
            lblqc = new Label();
            btncalcw = new Button();
            SuspendLayout();
            // 
            // lblac
            // 
            lblac.AutoSize = true;
            lblac.Location = new Point(58, 80);
            lblac.Name = "lblac";
            lblac.Size = new Size(94, 15);
            lblac.TabIndex = 2;
            lblac.Text = "área do comodo";
            // 
            // lblar
            // 
            lblar.AutoSize = true;
            lblar.Location = new Point(58, 168);
            lblar.Name = "lblar";
            lblar.Size = new Size(85, 15);
            lblar.TabIndex = 3;
            lblar.Text = "área residência";
            // 
            // txtar
            // 
            txtar.Location = new Point(158, 165);
            txtar.Name = "txtar";
            txtar.ReadOnly = true;
            txtar.Size = new Size(110, 23);
            txtar.TabIndex = 6;
            // 
            // txtac
            // 
            txtac.Location = new Point(158, 72);
            txtac.Multiline = true;
            txtac.Name = "txtac";
            txtac.ReadOnly = true;
            txtac.Size = new Size(128, 78);
            txtac.TabIndex = 7;
            // 
            // btncalcdw
            // 
            btncalcdw.Location = new Point(70, 247);
            btncalcdw.Name = "btncalcdw";
            btncalcdw.Size = new Size(75, 23);
            btncalcdw.TabIndex = 9;
            btncalcdw.Text = "calc dw";
            btncalcdw.UseVisualStyleBackColor = true;
            btncalcdw.Click += btncalcdw_Click;
            // 
            // btncalcf
            // 
            btncalcf.Location = new Point(70, 276);
            btncalcf.Name = "btncalcf";
            btncalcf.Size = new Size(75, 23);
            btncalcf.TabIndex = 10;
            btncalcf.Text = "calc for";
            btncalcf.UseVisualStyleBackColor = true;
            btncalcf.Click += btncalcf_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(193, 218);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 11;
            btnlimpar.Text = "limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(319, 218);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 12;
            btnvoltar.Text = "voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            // 
            // txtqc
            // 
            txtqc.Location = new Point(158, 31);
            txtqc.Name = "txtqc";
            txtqc.Size = new Size(100, 23);
            txtqc.TabIndex = 13;
            // 
            // lblqc
            // 
            lblqc.AutoSize = true;
            lblqc.Location = new Point(58, 34);
            lblqc.Name = "lblqc";
            lblqc.Size = new Size(94, 15);
            lblqc.TabIndex = 14;
            lblqc.Text = "qtd de comodos";
            // 
            // btncalcw
            // 
            btncalcw.Location = new Point(70, 218);
            btncalcw.Name = "btncalcw";
            btncalcw.Size = new Size(75, 23);
            btncalcw.TabIndex = 15;
            btncalcw.Text = "calc w";
            btncalcw.UseVisualStyleBackColor = true;
            btncalcw.Click += btncalcw_Click;
            // 
            // frmar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btncalcw);
            Controls.Add(lblqc);
            Controls.Add(txtqc);
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(btncalcf);
            Controls.Add(btncalcdw);
            Controls.Add(txtac);
            Controls.Add(txtar);
            Controls.Add(lblar);
            Controls.Add(lblac);
            Name = "frmar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Área residência";
            Shown += frmar_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblac;
        private Label lblar;
        private TextBox txtar;
        private TextBox txtac;
        private Button btncalcdw;
        private Button btncalcf;
        private Button btnlimpar;
        private Button btnvoltar;
        private TextBox txtqc;
        private Label lblqc;
        private Button btncalcw;
    }
}