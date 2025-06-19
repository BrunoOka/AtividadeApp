namespace AtividadeApp
{
    partial class frmmedia
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
            lblnota1 = new Label();
            lblnota2 = new Label();
            lblnota3 = new Label();
            lblresultado = new Label();
            txtnota1 = new TextBox();
            txtnota2 = new TextBox();
            txtnota3 = new TextBox();
            txtresultado = new TextBox();
            btncalcular = new Button();
            btnlimpar = new Button();
            btnvoltar = new Button();
            SuspendLayout();
            // 
            // lblnota1
            // 
            lblnota1.AutoSize = true;
            lblnota1.Location = new Point(95, 65);
            lblnota1.Name = "lblnota1";
            lblnota1.Size = new Size(42, 15);
            lblnota1.TabIndex = 0;
            lblnota1.Text = "Nota 1";
            // 
            // lblnota2
            // 
            lblnota2.AutoSize = true;
            lblnota2.Location = new Point(95, 113);
            lblnota2.Name = "lblnota2";
            lblnota2.Size = new Size(42, 15);
            lblnota2.TabIndex = 1;
            lblnota2.Text = "Nota 2";
            // 
            // lblnota3
            // 
            lblnota3.AutoSize = true;
            lblnota3.Location = new Point(95, 156);
            lblnota3.Name = "lblnota3";
            lblnota3.Size = new Size(42, 15);
            lblnota3.TabIndex = 2;
            lblnota3.Text = "Nota 3";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(95, 208);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(59, 15);
            lblresultado.TabIndex = 3;
            lblresultado.Text = "Resultado";
            // 
            // txtnota1
            // 
            txtnota1.Location = new Point(207, 62);
            txtnota1.Name = "txtnota1";
            txtnota1.Size = new Size(100, 23);
            txtnota1.TabIndex = 4;
            // 
            // txtnota2
            // 
            txtnota2.Location = new Point(207, 110);
            txtnota2.Name = "txtnota2";
            txtnota2.Size = new Size(100, 23);
            txtnota2.TabIndex = 5;
            // 
            // txtnota3
            // 
            txtnota3.Location = new Point(207, 156);
            txtnota3.Name = "txtnota3";
            txtnota3.Size = new Size(100, 23);
            txtnota3.TabIndex = 6;
            // 
            // txtresultado
            // 
            txtresultado.Location = new Point(207, 200);
            txtresultado.Name = "txtresultado";
            txtresultado.ReadOnly = true;
            txtresultado.Size = new Size(100, 23);
            txtresultado.TabIndex = 7;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(95, 269);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 8;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(250, 269);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 9;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(409, 269);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 10;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // frmmedia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(btncalcular);
            Controls.Add(txtresultado);
            Controls.Add(txtnota3);
            Controls.Add(txtnota2);
            Controls.Add(txtnota1);
            Controls.Add(lblresultado);
            Controls.Add(lblnota3);
            Controls.Add(lblnota2);
            Controls.Add(lblnota1);
            Name = "frmmedia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "média ponderada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnota1;
        private Label lblnota2;
        private Label lblnota3;
        private Label lblresultado;
        private TextBox txtnota1;
        private TextBox txtnota2;
        private TextBox txtnota3;
        private TextBox txtresultado;
        private Button btncalcular;
        private Button btnlimpar;
        private Button btnvoltar;
    }
}