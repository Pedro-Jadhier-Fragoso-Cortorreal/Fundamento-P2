namespace Mosler
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            lblimportancia = new Label();
            lbldanos = new Label();
            lblF3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            PbRiesgo = new DataGridViewTextBoxColumn();
            Criesgo = new DataGridViewTextBoxColumn();
            ERriesgo = new DataGridViewTextBoxColumn();
            button1 = new Button();
            lbl3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PbRiesgo, Criesgo, ERriesgo });
            dataGridView1.Location = new Point(12, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(428, 155);
            dataGridView1.TabIndex = 0;
            // 
            // lblimportancia
            // 
            lblimportancia.Location = new Point(12, 48);
            lblimportancia.Name = "lblimportancia";
            lblimportancia.Size = new Size(171, 24);
            lblimportancia.TabIndex = 1;
            lblimportancia.Text = "Importancia Del Suceso:";
            // 
            // lbldanos
            // 
            lbldanos.Location = new Point(12, 87);
            lbldanos.Name = "lbldanos";
            lbldanos.Size = new Size(144, 35);
            lbldanos.TabIndex = 2;
            lbldanos.Text = "Daños Ocasionados:";
            // 
            // lblF3
            // 
            lblF3.BorderStyle = BorderStyle.Fixed3D;
            lblF3.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblF3.Location = new Point(12, 9);
            lblF3.Name = "lblF3";
            lblF3.Size = new Size(36, 33);
            lblF3.TabIndex = 3;
            lblF3.Text = "F3";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 48);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(47, 24);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 87);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(47, 24);
            textBox2.TabIndex = 5;
            // 
            // PbRiesgo
            // 
            PbRiesgo.HeaderText = "Probabilidad del Riesgo";
            PbRiesgo.MinimumWidth = 6;
            PbRiesgo.Name = "PbRiesgo";
            PbRiesgo.Width = 125;
            // 
            // Criesgo
            // 
            Criesgo.HeaderText = "Caracter del Riesgo";
            Criesgo.MinimumWidth = 6;
            Criesgo.Name = "Criesgo";
            Criesgo.Width = 125;
            // 
            // ERriesgo
            // 
            ERriesgo.HeaderText = "Cuantificar el Riesgo";
            ERriesgo.MinimumWidth = 6;
            ERriesgo.Name = "ERriesgo";
            ERriesgo.Width = 125;
            // 
            // button1
            // 
            button1.Font = new Font("Tw Cen MT Condensed Extra Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(324, 48);
            button1.Name = "button1";
            button1.Size = new Size(91, 63);
            button1.TabIndex = 6;
            button1.Text = "Calcular ER";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbl3
            // 
            lbl3.BorderStyle = BorderStyle.Fixed3D;
            lbl3.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(54, 9);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(361, 36);
            lbl3.TabIndex = 7;
            lbl3.Text = "Evaluacion Del Riesgo";
            lbl3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 287);
            Controls.Add(lbl3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblF3);
            Controls.Add(lbldanos);
            Controls.Add(lblimportancia);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Evaluacion de Riesgo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblimportancia;
        private Label lbldanos;
        private Label lblF3;
        private DataGridViewTextBoxColumn PbRiesgo;
        private DataGridViewTextBoxColumn Criesgo;
        private DataGridViewTextBoxColumn ERriesgo;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label lbl3;
    }
}