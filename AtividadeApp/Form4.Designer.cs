namespace AtividadeApp
{
    partial class frmsq3n
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
            lbln1 = new Label();
            lbln2 = new Label();
            lbln3 = new Label();
            lblr = new Label();
            txtn1 = new TextBox();
            txtn2 = new TextBox();
            txtn3 = new TextBox();
            txtr = new TextBox();
            btnc = new Button();
            btnv = new Button();
            btnl = new Button();
            SuspendLayout();
            // 
            // lbln1
            // 
            lbln1.AutoSize = true;
            lbln1.Location = new Point(75, 61);
            lbln1.Name = "lbln1";
            lbln1.Size = new Size(140, 15);
            lbln1.TabIndex = 0;
            lbln1.Text = "digite o primeiro número";
            // 
            // lbln2
            // 
            lbln2.AutoSize = true;
            lbln2.Location = new Point(75, 96);
            lbln2.Name = "lbln2";
            lbln2.Size = new Size(141, 15);
            lbln2.TabIndex = 1;
            lbln2.Text = "digite o segundo número";
            // 
            // lbln3
            // 
            lbln3.AutoSize = true;
            lbln3.Location = new Point(75, 136);
            lbln3.Name = "lbln3";
            lbln3.Size = new Size(135, 15);
            lbln3.TabIndex = 2;
            lbln3.Text = "digite o terceiro número";
            // 
            // lblr
            // 
            lblr.AutoSize = true;
            lblr.Location = new Point(75, 175);
            lblr.Name = "lblr";
            lblr.Size = new Size(56, 15);
            lblr.TabIndex = 3;
            lblr.Text = "resultado";
            // 
            // txtn1
            // 
            txtn1.Location = new Point(237, 61);
            txtn1.Name = "txtn1";
            txtn1.Size = new Size(100, 23);
            txtn1.TabIndex = 4;
            // 
            // txtn2
            // 
            txtn2.Location = new Point(237, 96);
            txtn2.Name = "txtn2";
            txtn2.Size = new Size(100, 23);
            txtn2.TabIndex = 5;
            // 
            // txtn3
            // 
            txtn3.Location = new Point(237, 136);
            txtn3.Name = "txtn3";
            txtn3.Size = new Size(100, 23);
            txtn3.TabIndex = 6;
            // 
            // txtr
            // 
            txtr.Location = new Point(237, 175);
            txtr.Name = "txtr";
            txtr.ReadOnly = true;
            txtr.Size = new Size(100, 23);
            txtr.TabIndex = 7;
            // 
            // btnc
            // 
            btnc.Location = new Point(120, 265);
            btnc.Name = "btnc";
            btnc.Size = new Size(75, 23);
            btnc.TabIndex = 8;
            btnc.Text = "calcular";
            btnc.UseVisualStyleBackColor = true;
            btnc.Click += btnc_Click;
            // 
            // btnv
            // 
            btnv.Location = new Point(418, 265);
            btnv.Name = "btnv";
            btnv.Size = new Size(75, 23);
            btnv.TabIndex = 9;
            btnv.Text = "voltar";
            btnv.UseVisualStyleBackColor = true;
            btnv.Click += btnv_Click;
            // 
            // btnl
            // 
            btnl.Location = new Point(262, 265);
            btnl.Name = "btnl";
            btnl.Size = new Size(75, 23);
            btnl.TabIndex = 10;
            btnl.Text = "limpar";
            btnl.UseVisualStyleBackColor = true;
            btnl.Click += btnl_Click;
            // 
            // frmsq3n
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnl);
            Controls.Add(btnv);
            Controls.Add(btnc);
            Controls.Add(txtr);
            Controls.Add(txtn3);
            Controls.Add(txtn2);
            Controls.Add(txtn1);
            Controls.Add(lblr);
            Controls.Add(lbln3);
            Controls.Add(lbln2);
            Controls.Add(lbln1);
            Name = "frmsq3n";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Soma do quadrado de 3 números";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbln1;
        private Label lbln2;
        private Label lbln3;
        private Label lblr;
        private TextBox txtn1;
        private TextBox txtn2;
        private TextBox txtn3;
        private TextBox txtr;
        private Button btnc;
        private Button btnv;
        private Button btnl;
    }
}