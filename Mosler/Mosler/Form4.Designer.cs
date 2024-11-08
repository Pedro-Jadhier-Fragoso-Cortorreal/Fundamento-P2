namespace Mosler
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ValorER = new DataGridViewTextBoxColumn();
            ClasedelRiesgo = new DataGridViewTextBoxColumn();
            lblAna = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(365, 36);
            label1.TabIndex = 0;
            label1.Text = "Clasificacion y Valoracion Del Riesgo";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(36, 33);
            label2.TabIndex = 3;
            label2.Text = "F4";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ValorER, ClasedelRiesgo });
            dataGridView1.Location = new Point(54, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(304, 155);
            dataGridView1.TabIndex = 4;
            // 
            // ValorER
            // 
            ValorER.HeaderText = "Valor ER del Riesgo";
            ValorER.MinimumWidth = 6;
            ValorER.Name = "ValorER";
            ValorER.Width = 125;
            // 
            // ClasedelRiesgo
            // 
            ClasedelRiesgo.HeaderText = "Clase Del Riesgo";
            ClasedelRiesgo.MinimumWidth = 6;
            ClasedelRiesgo.Name = "ClasedelRiesgo";
            ClasedelRiesgo.Width = 125;
            // 
            // lblAna
            // 
            lblAna.AutoSize = true;
            lblAna.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAna.Location = new Point(54, 206);
            lblAna.Name = "lblAna";
            lblAna.Size = new Size(78, 25);
            lblAna.TabIndex = 5;
            lblAna.Text = "Analista:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 206);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(220, 25);
            textBox1.TabIndex = 6;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 237);
            Controls.Add(textBox1);
            Controls.Add(lblAna);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Valoracion de Riesgo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ValorER;
        private DataGridViewTextBoxColumn ClasedelRiesgo;
        private Label lblAna;
        private TextBox textBox1;
    }
}