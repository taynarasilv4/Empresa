namespace Cadastro_Empresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroEmpresa c = new CadastroEmpresa();
            c.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}