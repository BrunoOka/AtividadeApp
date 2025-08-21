namespace AtividadeApp
{
    partial class frmmenu
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
            menuStrip1 = new MenuStrip();
            programasToolStripMenuItem = new ToolStripMenuItem();
            tsmicf = new ToolStripMenuItem();
            tsmidlg = new ToolStripMenuItem();
            tsmidpr = new ToolStripMenuItem();
            tsmisq3n = new ToolStripMenuItem();
            tmsiarea = new ToolStripMenuItem();
            tsmimedia = new ToolStripMenuItem();
            tsmiar = new ToolStripMenuItem();
            tsmirtj = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            tsmicvl = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programasToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            programasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmicf, tsmidlg, tsmidpr, tsmisq3n, tmsiarea, tsmimedia, tsmiar, tsmirtj, tsmicvl });
            programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            programasToolStripMenuItem.Size = new Size(76, 20);
            programasToolStripMenuItem.Text = "Programas";
            // 
            // tsmicf
            // 
            tsmicf.Name = "tsmicf";
            tsmicf.Size = new Size(255, 22);
            tsmicf.Text = "Conversor de temperatura";
            tsmicf.Click += tsmicf_Click;
            // 
            // tsmidlg
            // 
            tsmidlg.Name = "tsmidlg";
            tsmidlg.Size = new Size(255, 22);
            tsmidlg.Text = "Calculo de distância e litros gastos";
            tsmidlg.Click += tsmidlg_Click;
            // 
            // tsmidpr
            // 
            tsmidpr.Name = "tsmidpr";
            tsmidpr.Size = new Size(255, 22);
            tsmidpr.Text = "Conversor de real para dólar";
            tsmidpr.Click += tsmidpr_Click;
            // 
            // tsmisq3n
            // 
            tsmisq3n.Name = "tsmisq3n";
            tsmisq3n.Size = new Size(255, 22);
            tsmisq3n.Text = "Soma do quadrado de 3 números";
            tsmisq3n.Click += tsmisq3n_Click;
            // 
            // tmsiarea
            // 
            tmsiarea.Name = "tmsiarea";
            tmsiarea.Size = new Size(255, 22);
            tmsiarea.Text = "Calculo de área de um círculo";
            tmsiarea.Click += tmsiarea_Click;
            // 
            // tsmimedia
            // 
            tsmimedia.Name = "tsmimedia";
            tsmimedia.Size = new Size(255, 22);
            tsmimedia.Text = "Cálculo da média ponderada";
            tsmimedia.Click += tsmimedia_Click;
            // 
            // tsmiar
            // 
            tsmiar.Name = "tsmiar";
            tsmiar.Size = new Size(255, 22);
            tsmiar.Text = "Cálculo da área de um retãngulo";
            tsmiar.Click += tsmiar_Click;
            // 
            // tsmirtj
            // 
            tsmirtj.Name = "tsmirtj";
            tsmirtj.Size = new Size(255, 22);
            tsmirtj.Text = "Renda total jogo";
            tsmirtj.Click += tsmirtj_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // tsmicvl
            // 
            tsmicvl.Name = "tsmicvl";
            tsmicvl.Size = new Size(255, 22);
            tsmicvl.Text = "Calculo venda de livro";
            tsmicvl.Click += tsmicvl_Click;
            // 
            // frmmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmmenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += frmmenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem programasToolStripMenuItem;
        private ToolStripMenuItem tsmicf;
        private ToolStripMenuItem tsmidlg;
        private ToolStripMenuItem tsmidpr;
        private ToolStripMenuItem tsmisq3n;
        private ToolStripMenuItem tmsiarea;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem tsmimedia;
        private ToolStripMenuItem tsmiar;
        private ToolStripMenuItem tsmirtj;
        private ToolStripMenuItem tsmicvl;
    }
}