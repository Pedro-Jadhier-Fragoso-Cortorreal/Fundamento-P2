namespace Mosler
{
    partial class Form2
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
            Funcion = new DataGridViewTextBoxColumn();
            Sustitucion = new DataGridViewTextBoxColumn();
            Profundidad = new DataGridViewTextBoxColumn();
            Extension = new DataGridViewTextBoxColumn();
            Agresion = new DataGridViewTextBoxColumn();
            Vulnerabilidad = new DataGridViewTextBoxColumn();
            lbl2 = new Label();
            lblF2 = new Label();
            btncalcularf3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Funcion, Sustitucion, Profundidad, Extension, Agresion, Vulnerabilidad });
            dataGridView1.Location = new Point(12, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(792, 240);
            dataGridView1.TabIndex = 0;
            // 
            // Funcion
            // 
            Funcion.HeaderText = "Funcion";
            Funcion.MinimumWidth = 6;
            Funcion.Name = "Funcion";
            Funcion.Width = 125;
            // 
            // Sustitucion
            // 
            Sustitucion.HeaderText = "Sustitucion";
            Sustitucion.MinimumWidth = 6;
            Sustitucion.Name = "Sustitucion";
            Sustitucion.Width = 125;
            // 
            // Profundidad
            // 
            Profundidad.HeaderText = "Profundidad";
            Profundidad.MinimumWidth = 6;
            Profundidad.Name = "Profundidad";
            Profundidad.Width = 125;
            // 
            // Extension
            // 
            Extension.HeaderText = "Extension";
            Extension.MinimumWidth = 6;
            Extension.Name = "Extension";
            Extension.Width = 125;
            // 
            // Agresion
            // 
            Agresion.HeaderText = "Agresion";
            Agresion.MinimumWidth = 6;
            Agresion.Name = "Agresion";
            Agresion.Width = 125;
            // 
            // Vulnerabilidad
            // 
            Vulnerabilidad.HeaderText = "Vulnerabilidad";
            Vulnerabilidad.MinimumWidth = 6;
            Vulnerabilidad.Name = "Vulnerabilidad";
            Vulnerabilidad.Width = 125;
            // 
            // lbl2
            // 
            lbl2.BorderStyle = BorderStyle.Fixed3D;
            lbl2.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(216, 9);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(410, 33);
            lbl2.TabIndex = 1;
            lbl2.Text = "Criterios #1-6  /  Valorar (rango 1-5)";
            // 
            // lblF2
            // 
            lblF2.BackColor = SystemColors.Control;
            lblF2.BorderStyle = BorderStyle.Fixed3D;
            lblF2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblF2.Location = new Point(12, 9);
            lblF2.Name = "lblF2";
            lblF2.Size = new Size(36, 33);
            lblF2.TabIndex = 2;
            lblF2.Text = "F2";
            // 
            // btncalcularf3
            // 
            btncalcularf3.BackColor = SystemColors.Control;
            btncalcularf3.Font = new Font("Tw Cen MT Condensed", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncalcularf3.Location = new Point(684, 9);
            btncalcularf3.Name = "btncalcularf3";
            btncalcularf3.Size = new Size(117, 33);
            btncalcularf3.TabIndex = 3;
            btncalcularf3.Text = "Calcular F3";
            btncalcularf3.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 312);
            Controls.Add(btncalcularf3);
            Controls.Add(lblF2);
            Controls.Add(lbl2);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Analisis de Riesgo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Funcion;
        private DataGridViewTextBoxColumn Sustitucion;
        private DataGridViewTextBoxColumn Profundidad;
        private DataGridViewTextBoxColumn Extension;
        private DataGridViewTextBoxColumn Agresion;
        private DataGridViewTextBoxColumn Vulnerabilidad;
        private Label lbl2;
        private Label lblF2;
        private Button btncalcularf3;
    }
}