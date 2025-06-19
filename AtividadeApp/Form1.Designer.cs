namespace AtividadeApp
{
    partial class frmconversor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtc = new TextBox();
            txtf = new TextBox();
            btncalcular = new Button();
            btnlimpar = new Button();
            btnvoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 75);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 0;
            label1.Text = "Temperatura em celsius";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 114);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 1;
            label2.Text = "Conversão em fahrenheit";
            // 
            // txtc
            // 
            txtc.Location = new Point(210, 67);
            txtc.Name = "txtc";
            txtc.Size = new Size(100, 23);
            txtc.TabIndex = 2;
            // 
            // txtf
            // 
            txtf.Location = new Point(210, 111);
            txtf.Name = "txtf";
            txtf.ReadOnly = true;
            txtf.Size = new Size(100, 23);
            txtf.TabIndex = 3;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(90, 214);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(293, 214);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 5;
            btnlimpar.Text = "limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(480, 214);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 6;
            btnvoltar.Text = "voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // frmconversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(btncalcular);
            Controls.Add(txtf);
            Controls.Add(txtc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmconversor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor de tempratura";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtc;
        private TextBox txtf;
        private Button btncalcular;
        private Button btnlimpar;
        private Button btnvoltar;
    }
}
