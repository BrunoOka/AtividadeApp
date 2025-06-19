namespace AtividadeApp
{
    public partial class frmconversor : Form
    {
        public frmconversor()
        {
            InitializeComponent();
            
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double c, f;
            c = Convert.ToDouble(txtc.Text);
            f = (c * 1.8) + 32;
            txtf.Text = f.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtc.Clear();
            txtf.Clear();
            txtc.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            Hide();
            menu.Show();
        }
    }
}
