namespace Mosler
{
    partial class Gestion_De_Riesgos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_De_Riesgos));
            lblAnalista = new Label();
            textBox1 = new TextBox();
            lblFecha = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            Activos = new DataGridViewTextBoxColumn();
            Riesgo = new DataGridViewTextBoxColumn();
            Daños = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAnalista
            // 
            lblAnalista.AutoSize = true;
            lblAnalista.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnalista.Location = new Point(14, 56);
            lblAnalista.Name = "lblAnalista";
            lblAnalista.Size = new Size(68, 22);
            lblAnalista.TabIndex = 0;
            lblAnalista.Text = "Analista";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 27);
            textBox1.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(217, 55);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(65, 27);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(280, 55);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(136, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Activos, Riesgo, Daños });
            dataGridView1.Location = new Point(12, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(423, 244);
            dataGridView1.TabIndex = 4;
            // 
            // Activos
            // 
            Activos.HeaderText = "Activo/Bien";
            Activos.MinimumWidth = 6;
            Activos.Name = "Activos";
            Activos.Width = 125;
            // 
            // Riesgo
            // 
            Riesgo.HeaderText = "Riesgo";
            Riesgo.MinimumWidth = 6;
            Riesgo.Name = "Riesgo";
            Riesgo.Width = 125;
            // 
            // Daños
            // 
            Daños.HeaderText = "Daños";
            Daños.MinimumWidth = 6;
            Daños.Name = "Daños";
            Daños.Width = 125;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(458, 27);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripLabel1.Image = (Image)resources.GetObject("toolStripLabel1.Image");
            toolStripLabel1.ImageTransparentColor = Color.Magenta;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(129, 24);
            toolStripLabel1.Text = "Análisis de riesgo";
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(162, 24);
            toolStripButton1.Text = "Evaluación del Riesgo ";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(99, 24);
            toolStripButton2.Text = "Valor. Riesgo";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // Gestion_De_Riesgos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 398);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblFecha);
            Controls.Add(textBox1);
            Controls.Add(lblAnalista);
            Name = "Gestion_De_Riesgos";
            Text = "Gestion De Riesgos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnalista;
        private TextBox textBox1;
        private Label lblFecha;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Activos;
        private DataGridViewTextBoxColumn Riesgo;
        private DataGridViewTextBoxColumn Daños;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripLabel1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
    }
}
