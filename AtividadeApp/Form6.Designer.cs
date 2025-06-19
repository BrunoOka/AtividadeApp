namespace AtividadeApp
{
    partial class frmcircunferencia
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
            txtraio = new TextBox();
            lblraio = new Label();
            btncalcular = new Button();
            btnlimpar = new Button();
            btnvoltar = new Button();
            lblarea = new Label();
            txtarea = new TextBox();
            SuspendLayout();
            // 
            // txtraio
            // 
            txtraio.Location = new Point(307, 69);
            txtraio.Name = "txtraio";
            txtraio.Size = new Size(100, 23);
            txtraio.TabIndex = 0;
            // 
            // lblraio
            // 
            lblraio.AutoSize = true;
            lblraio.Location = new Point(117, 77);
            lblraio.Name = "lblraio";
            lblraio.Size = new Size(124, 15);
            lblraio.TabIndex = 1;
            lblraio.Text = "Raio da circunferência";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(117, 300);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 2;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(332, 300);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 3;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(528, 300);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(75, 23);
            btnvoltar.TabIndex = 4;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // lblarea
            // 
            lblarea.AutoSize = true;
            lblarea.Location = new Point(117, 170);
            lblarea.Name = "lblarea";
            lblarea.Size = new Size(70, 15);
            lblarea.TabIndex = 5;
            lblarea.Text = "Área gerada";
            // 
            // txtarea
            // 
            txtarea.Location = new Point(307, 162);
            txtarea.Name = "txtarea";
            txtarea.ReadOnly = true;
            txtarea.Size = new Size(100, 23);
            txtarea.TabIndex = 6;
            // 
            // frmcircunferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(txtarea);
            Controls.Add(lblarea);
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(btncalcular);
            Controls.Add(lblraio);
            Controls.Add(txtraio);
            Name = "frmcircunferencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo de área pertecente à uma circunferência";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtraio;
        private Label lblraio;
        private Button btncalcular;
        private Button btnlimpar;
        private Button btnvoltar;
        private Label lblarea;
        private TextBox txtarea;
    }
}