namespace AtividadeApp
{
    partial class frmretangulo
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
            lblbase = new Label();
            lblaltura = new Label();
            lblresultado = new Label();
            txtbase = new TextBox();
            SuspendLayout();
            // 
            // lblbase
            // 
            lblbase.AutoSize = true;
            lblbase.Location = new Point(95, 65);
            lblbase.Name = "lblbase";
            lblbase.Size = new Size(31, 15);
            lblbase.TabIndex = 0;
            lblbase.Text = "Base";
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Location = new Point(95, 112);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(39, 15);
            lblaltura.TabIndex = 1;
            lblaltura.Text = "Altura";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(95, 157);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(59, 15);
            lblresultado.TabIndex = 2;
            lblresultado.Text = "Resultado";
            // 
            // txtbase
            // 
            txtbase.Location = new Point(199, 62);
            txtbase.Name = "txtbase";
            txtbase.Size = new Size(100, 23);
            txtbase.TabIndex = 3;
            // 
            // frmretangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtbase);
            Controls.Add(lblresultado);
            Controls.Add(lblaltura);
            Controls.Add(lblbase);
            Name = "frmretangulo";
            Text = "Área do retangulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblbase;
        private Label lblaltura;
        private Label lblresultado;
        private TextBox txtbase;
    }
}