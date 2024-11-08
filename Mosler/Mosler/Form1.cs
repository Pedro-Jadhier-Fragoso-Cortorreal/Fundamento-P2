namespace Mosler
{
    public partial class Gestion_De_Riesgos : Form
    {
        public Gestion_De_Riesgos()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form2 nuevoFormulario = new Form2();
            nuevoFormulario.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form3 nuevoFormulario = new Form3();
            nuevoFormulario.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form4 nuevoFormulario = new Form4();
            nuevoFormulario.Show();
        }
    }
}
