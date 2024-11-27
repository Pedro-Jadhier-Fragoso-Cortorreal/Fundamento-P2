using LiteDB;

namespace GrMosler
{
    public partial class GestionRiesgos : Form
    {
        public GestionRiesgos()
        {
            InitializeComponent();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionRiesgos_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
               
                dataGridViewF4_Clasificacion.Rows.Clear();

               
                foreach (DataGridViewRow row in dataGridViewF3_Calculos.Rows)
                {
                    
                    if (row.Cells["Caracter"].Value != null && row.Cells["Probabilidad"].Value != null)
                    {
                        
                        int C = Convert.ToInt32(row.Cells["Caracter"].Value); 
                        int Pb = Convert.ToInt32(row.Cells["Probabilidad"].Value); 

                       
                        int ER = C * Pb;

                        string clasificacion;
                        if (ER >= 2 && ER <= 250)
                        {
                            clasificacion = "Muy Pequeño";  
                        }
                        else if (ER >= 251 && ER <= 500)
                        {
                            clasificacion = "Pequeño";
                        }
                        else if (ER >= 501 && ER <= 750)
                        {
                            clasificacion = "Normal";
                        }
                        else if (ER >= 751 && ER <= 1000)
                        {
                            clasificacion = "Grande";
                        }
                        else if (ER >= 1001 && ER <= 1250)
                        {
                            clasificacion = "Elevado";
                        }
                        else
                        {
                            clasificacion = "Indeterminado";
                        }
                      
                        dataGridViewF4_Clasificacion.Rows.Add(ER, clasificacion);
                    }
                    else
                    {
                        MessageBox.Show("Hay valores faltantes en los cálculos de Fase 3.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                MessageBox.Show("Datos calculados y clasificados correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSiguienteF2_Click(object sender, EventArgs e)
        {
            try
            {
               
                dataGridViewF3_Calculos.Rows.Clear();

               
                foreach (DataGridViewRow row in dataGridViewF2.Rows)
                {
                   
                    if (row.Cells["Funcion"].Value != null && row.Cells["Sustitucion"].Value != null &&
                        row.Cells["Perturbacion"].Value != null && row.Cells["Extension"].Value != null &&
                        row.Cells["Agresion"].Value != null && row.Cells["Vulnerabilidad"].Value != null)
                    {
                       
                        int F = ParseAndValidate(row.Cells["Funcion"], "Funcion");
                        int S = ParseAndValidate(row.Cells["Sustitucion"], "Sustitucion");
                        int P = ParseAndValidate(row.Cells["Perturbacion"], "Perturbacion");
                        int E = ParseAndValidate(row.Cells["Extension"], "Extension");
                        int A = ParseAndValidate(row.Cells["Agresion"], "Agresion");
                        int V = ParseAndValidate(row.Cells["Vulnerabilidad"], "Vulnerabilidad");

                        
                        int C = (F * S) + (P * E);
                        int Pb = A * V;
                        int ER = C * Pb;

                       
                        dataGridViewF3_Calculos.Rows.Add(C, Pb, ER);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete todos los criterios numericos (F, S, P, E, A, V).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                MessageBox.Show("Datos procesados y transferidos a la siguiente fase correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ParseAndValidate(DataGridViewCell cell, string criterio)
        {
           
            if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
            {
                throw new Exception($"El criterio {criterio} no puede estar vacio.");
            }

           
            if (!int.TryParse(cell.Value.ToString(), out int value))
            {
                throw new Exception($"El criterio {criterio} debe ser un numero entero.");
            }

           
            if (value < 1 || value > 5)
            {
                throw new Exception($"El criterio {criterio} debe estar en el rango de 1 a 5.");
            }

            return value;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LiteDatabase(@"GestionRiesgos.db"))
                {
                    var collection = db.GetCollection<GestionRiesgo>("riesgos");

                   
                    for (int i = 0; i < dataGridViewF3_Calculos.Rows.Count; i++)
                    {
                        if (dataGridViewF3_Calculos.Rows[i].Cells[0].Value != null)
                        {
                            var riesgo = new GestionRiesgo
                            {
                               
                                ActivoBien = dataGridViewF1.Rows[i].Cells["ActivoBien"].Value.ToString(),
                                Riesgo1 = dataGridViewF1.Rows[i].Cells["Riesgo1"].Value.ToString(),
                                Danios = dataGridViewF1.Rows[i].Cells["Danios"].Value.ToString(),
                                F = int.Parse(dataGridViewF2.Rows[i].Cells["Funcion"].Value.ToString()),
                                S = int.Parse(dataGridViewF2.Rows[i].Cells["Sustitucion"].Value.ToString()),
                                P = int.Parse(dataGridViewF2.Rows[i].Cells["Perturbacion"].Value.ToString()),
                                E = int.Parse(dataGridViewF2.Rows[i].Cells["Extension"].Value.ToString()),
                                A = int.Parse(dataGridViewF2.Rows[i].Cells["Agresion"].Value.ToString()),
                                V = int.Parse(dataGridViewF2.Rows[i].Cells["Vulnerabilidad"].Value.ToString()),
                                C = int.Parse(dataGridViewF3_Calculos.Rows[i].Cells["Caracter"].Value.ToString()), 
                                Pb = int.Parse(dataGridViewF3_Calculos.Rows[i].Cells["Probabilidad"].Value.ToString()),
                                ER = int.Parse(dataGridViewF3_Calculos.Rows[i].Cells["Riesgo"].Value.ToString()),
                                Clasificacion = dataGridViewF4_Clasificacion.Rows[i].Cells["Clasificacion"].Value.ToString()
                            };
                            collection.Insert(riesgo);
                        }
                    }
                }

                MessageBox.Show("Datos guardados exitosamente en LiteDB.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }


    }
}
