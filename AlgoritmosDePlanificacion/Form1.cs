namespace AlgoritmosDePlanificacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnNoExpropiativo_Click(object sender, EventArgs e)
        {
            //Redirigir al SubMen� No Expropiativos
            SubMenuNoExpropiativos nuevoForm = new SubMenuNoExpropiativos();
            this.Hide();
            nuevoForm.Show();
        }

        private void btnExpropiativo_Click(object sender, EventArgs e)
        {
            //Redirigir al SubMen� Expropiativos
            SubMenuExpropiativos nuevoForm = new SubMenuExpropiativos();
            this.Hide();
            nuevoForm.Show();
        }

    }
}
