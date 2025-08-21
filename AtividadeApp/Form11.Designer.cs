namespace AtividadeApp
{
    partial class frmabono
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
            lblnome = new Label();
            lblsexo = new Label();
            SuspendLayout();
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(95, 65);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(40, 15);
            lblnome.TabIndex = 0;
            lblnome.Text = "Nome";
            // 
            // lblsexo
            // 
            lblsexo.AutoSize = true;
            lblsexo.Location = new Point(97, 98);
            lblsexo.Name = "lblsexo";
            lblsexo.Size = new Size(32, 15);
            lblsexo.TabIndex = 1;
            lblsexo.Text = "Sexo";
            // 
            // frmabono
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblsexo);
            Controls.Add(lblnome);
            Name = "frmabono";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo de abono";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnome;
        private Label lblsexo;
    }
}