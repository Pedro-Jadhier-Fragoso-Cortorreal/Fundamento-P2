namespace Data_Grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtMin.Text == "" || txtMax.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            double consumoMin = Convert.ToDouble(txtMin.Text);
            double consumoMax = Convert.ToDouble(txtMax.Text);
            double precioPorGalon = Convert.ToDouble(txtPrecio.Text);

            dataGridView1.Rows.Clear();

            for (double consumoActual = consumoMin; consumoActual <= consumoMax; consumoActual++)
            {
                double costoPorKm = (consumoActual / 100) * precioPorGalon;
                double kmPorGalon = 100 / consumoActual;

                dataGridView1.Rows.Add(Math.Round(consumoActual, 1), Math.Round(costoPorKm, 2), Math.Round(kmPorGalon, 2));
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtMin.Text = "";
            txtMax.Text = "";
            txtPrecio.Text = "";
            dataGridView1.Rows.Clear();
        }
    }
}
