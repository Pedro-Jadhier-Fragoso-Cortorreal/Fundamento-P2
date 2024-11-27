namespace WinFormsApp1
{
    partial class GestionRiesgos
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
            F3F4 = new TabPage();
            btnGrabar = new Button();
            label8 = new Label();
            label7 = new Label();
            dataGridViewF4_Clasificacion = new DataGridView();
            Valor = new DataGridViewTextBoxColumn();
            clasificacion = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btnCalcular = new Button();
            lblF3 = new Label();
            dataGridViewF3_Calculos = new DataGridView();
            Caracter = new DataGridViewTextBoxColumn();
            Probabilidad = new DataGridViewTextBoxColumn();
            Riesgo = new DataGridViewTextBoxColumn();
            F2 = new TabPage();
            btnborrarf2 = new Button();
            btnSiguienteF2 = new Button();
            label4 = new Label();
            label3 = new Label();
            dataGridViewF2 = new DataGridView();
            Funcion = new DataGridViewTextBoxColumn();
            sustitucion = new DataGridViewTextBoxColumn();
            Perturbacion = new DataGridViewTextBoxColumn();
            extension = new DataGridViewTextBoxColumn();
            Agresion = new DataGridViewTextBoxColumn();
            Vulnerabilidad = new DataGridViewTextBoxColumn();
            F1 = new TabPage();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblFecha = new Label();
            txtAnalista = new TextBox();
            lblAnalista = new Label();
            dataGridViewF1 = new DataGridView();
            ActivoBien = new DataGridViewTextBoxColumn();
            Riesgo1 = new DataGridViewTextBoxColumn();
            Danios = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            F3F4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewF4_Clasificacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewF3_Calculos).BeginInit();
            F2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewF2).BeginInit();
            F1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewF1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // F3F4
            // 
            F3F4.Controls.Add(btnGrabar);
            F3F4.Controls.Add(label8);
            F3F4.Controls.Add(label7);
            F3F4.Controls.Add(dataGridViewF4_Clasificacion);
            F3F4.Controls.Add(button1);
            F3F4.Controls.Add(btnCalcular);
            F3F4.Controls.Add(lblF3);
            F3F4.Controls.Add(dataGridViewF3_Calculos);
            F3F4.Location = new Point(4, 29);
            F3F4.Name = "F3F4";
            F3F4.Padding = new Padding(3);
            F3F4.Size = new Size(883, 300);
            F3F4.TabIndex = 1;
            F3F4.Text = "F3-F4";
            F3F4.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Font = new Font("Segoe Print", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGrabar.Location = new Point(647, 6);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(181, 94);
            btnGrabar.TabIndex = 15;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.Control;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(844, 3);
            label8.Name = "label8";
            label8.Size = new Size(36, 33);
            label8.TabIndex = 14;
            label8.Text = "F4";
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(252, 34);
            label7.Name = "label7";
            label7.Size = new Size(365, 36);
            label7.TabIndex = 13;
            label7.Text = "Clasificacion y Valoracion Del Riesgo";
            // 
            // dataGridViewF4_Clasificacion
            // 
            dataGridViewF4_Clasificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewF4_Clasificacion.Columns.AddRange(new DataGridViewColumn[] { Valor, clasificacion });
            dataGridViewF4_Clasificacion.Location = new Point(435, 117);
            dataGridViewF4_Clasificacion.Name = "dataGridViewF4_Clasificacion";
            dataGridViewF4_Clasificacion.ReadOnly = true;
            dataGridViewF4_Clasificacion.RowHeadersWidth = 51;
            dataGridViewF4_Clasificacion.Size = new Size(445, 180);
            dataGridViewF4_Clasificacion.TabIndex = 12;
            // 
            // Valor
            // 
            Valor.HeaderText = "ValorRiesgo";
            Valor.MinimumWidth = 6;
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Width = 125;
            // 
            // clasificacion
            // 
            clasificacion.HeaderText = "Clasificacion";
            clasificacion.MinimumWidth = 6;
            clasificacion.Name = "clasificacion";
            clasificacion.ReadOnly = true;
            clasificacion.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(67, 6);
            button1.Name = "button1";
            button1.Size = new Size(161, 41);
            button1.TabIndex = 11;
            button1.Text = "Borrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(67, 59);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(161, 41);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblF3
            // 
            lblF3.BorderStyle = BorderStyle.Fixed3D;
            lblF3.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblF3.Location = new Point(7, 3);
            lblF3.Name = "lblF3";
            lblF3.Size = new Size(36, 33);
            lblF3.TabIndex = 9;
            lblF3.Text = "F3";
            // 
            // dataGridViewF3_Calculos
            // 
            dataGridViewF3_Calculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewF3_Calculos.Columns.AddRange(new DataGridViewColumn[] { Caracter, Probabilidad, Riesgo });
            dataGridViewF3_Calculos.Location = new Point(3, 117);
            dataGridViewF3_Calculos.Name = "dataGridViewF3_Calculos";
            dataGridViewF3_Calculos.ReadOnly = true;
            dataGridViewF3_Calculos.RowHeadersWidth = 51;
            dataGridViewF3_Calculos.Size = new Size(429, 180);
            dataGridViewF3_Calculos.TabIndex = 1;
            dataGridViewF3_Calculos.CellContentClick += dataGridView3_CellContentClick;
            // 
            // Caracter
            // 
            Caracter.HeaderText = "C";
            Caracter.MinimumWidth = 6;
            Caracter.Name = "Caracter";
            Caracter.ReadOnly = true;
            Caracter.Width = 125;
            // 
            // Probabilidad
            // 
            Probabilidad.HeaderText = "Pb";
            Probabilidad.MinimumWidth = 6;
            Probabilidad.Name = "Probabilidad";
            Probabilidad.ReadOnly = true;
            Probabilidad.Width = 125;
            // 
            // Riesgo
            // 
            Riesgo.HeaderText = "ER";
            Riesgo.MinimumWidth = 6;
            Riesgo.Name = "Riesgo";
            Riesgo.ReadOnly = true;
            Riesgo.Width = 125;
            // 
            // F2
            // 
            F2.Controls.Add(btnborrarf2);
            F2.Controls.Add(btnSiguienteF2);
            F2.Controls.Add(label4);
            F2.Controls.Add(label3);
            F2.Controls.Add(dataGridViewF2);
            F2.Location = new Point(4, 29);
            F2.Name = "F2";
            F2.Padding = new Padding(3);
            F2.Size = new Size(883, 300);
            F2.TabIndex = 0;
            F2.Text = "F2";
            F2.UseVisualStyleBackColor = true;
            // 
            // btnborrarf2
            // 
            btnborrarf2.Location = new Point(60, 1);
            btnborrarf2.Name = "btnborrarf2";
            btnborrarf2.Size = new Size(161, 41);
            btnborrarf2.TabIndex = 8;
            btnborrarf2.Text = "Borrar";
            btnborrarf2.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteF2
            // 
            btnSiguienteF2.Location = new Point(60, 48);
            btnSiguienteF2.Name = "btnSiguienteF2";
            btnSiguienteF2.Size = new Size(161, 41);
            btnSiguienteF2.TabIndex = 7;
            btnSiguienteF2.Text = "Siguiente";
            btnSiguienteF2.UseVisualStyleBackColor = true;
            btnSiguienteF2.Click += btnSiguienteF2_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(243, 27);
            label4.Name = "label4";
            label4.Size = new Size(365, 36);
            label4.TabIndex = 6;
            label4.Text = "Criterios / valoracion #1-5";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(36, 33);
            label3.TabIndex = 5;
            label3.Text = "F2";
            // 
            // dataGridViewF2
            // 
            dataGridViewF2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewF2.Columns.AddRange(new DataGridViewColumn[] { Funcion, sustitucion, Perturbacion, extension, Agresion, Vulnerabilidad });
            dataGridViewF2.Location = new Point(-3, 95);
            dataGridViewF2.Name = "dataGridViewF2";
            dataGridViewF2.RowHeadersWidth = 51;
            dataGridViewF2.Size = new Size(883, 205);
            dataGridViewF2.TabIndex = 0;
            // 
            // Funcion
            // 
            Funcion.HeaderText = "Funcion";
            Funcion.MinimumWidth = 6;
            Funcion.Name = "Funcion";
            Funcion.Width = 125;
            // 
            // sustitucion
            // 
            sustitucion.HeaderText = "sustitucion";
            sustitucion.MinimumWidth = 6;
            sustitucion.Name = "sustitucion";
            sustitucion.Width = 125;
            // 
            // Perturbacion
            // 
            Perturbacion.HeaderText = "Perturbacion";
            Perturbacion.MinimumWidth = 6;
            Perturbacion.Name = "Perturbacion";
            Perturbacion.Width = 125;
            // 
            // extension
            // 
            extension.HeaderText = "extension";
            extension.MinimumWidth = 6;
            extension.Name = "extension";
            extension.Width = 125;
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
            // F1
            // 
            F1.Controls.Add(label6);
            F1.Controls.Add(label5);
            F1.Controls.Add(dateTimePicker1);
            F1.Controls.Add(lblFecha);
            F1.Controls.Add(txtAnalista);
            F1.Controls.Add(lblAnalista);
            F1.Controls.Add(dataGridViewF1);
            F1.Location = new Point(4, 29);
            F1.Name = "F1";
            F1.Padding = new Padding(3);
            F1.Size = new Size(883, 300);
            F1.TabIndex = 3;
            F1.Text = "F1";
            F1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Control;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(36, 33);
            label6.TabIndex = 11;
            label6.Text = "F1";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(460, 24);
            label5.Name = "label5";
            label5.Size = new Size(365, 36);
            label5.TabIndex = 10;
            label5.Text = "Gestion De riesgos";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(292, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(136, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(221, 23);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(65, 27);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha:";
            // 
            // txtAnalista
            // 
            txtAnalista.Location = new Point(79, 26);
            txtAnalista.Name = "txtAnalista";
            txtAnalista.Size = new Size(136, 27);
            txtAnalista.TabIndex = 7;
            // 
            // lblAnalista
            // 
            lblAnalista.AutoSize = true;
            lblAnalista.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnalista.Location = new Point(5, 28);
            lblAnalista.Name = "lblAnalista";
            lblAnalista.Size = new Size(68, 22);
            lblAnalista.TabIndex = 6;
            lblAnalista.Text = "Analista";
            // 
            // dataGridViewF1
            // 
            dataGridViewF1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewF1.Columns.AddRange(new DataGridViewColumn[] { ActivoBien, Riesgo1, Danios });
            dataGridViewF1.Location = new Point(6, 85);
            dataGridViewF1.Name = "dataGridViewF1";
            dataGridViewF1.RowHeadersWidth = 51;
            dataGridViewF1.Size = new Size(874, 212);
            dataGridViewF1.TabIndex = 5;
            // 
            // ActivoBien
            // 
            ActivoBien.HeaderText = "Activo/Bien";
            ActivoBien.MinimumWidth = 6;
            ActivoBien.Name = "ActivoBien";
            ActivoBien.Width = 125;
            // 
            // Riesgo1
            // 
            Riesgo1.HeaderText = "Riesgo";
            Riesgo1.MinimumWidth = 6;
            Riesgo1.Name = "Riesgo1";
            Riesgo1.Width = 125;
            // 
            // Danios
            // 
            Danios.HeaderText = "Daños";
            Danios.MinimumWidth = 6;
            Danios.Name = "Danios";
            Danios.Width = 125;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(F1);
            tabControl1.Controls.Add(F2);
            tabControl1.Controls.Add(F3F4);
            tabControl1.Location = new Point(1, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(891, 333);
            tabControl1.TabIndex = 0;
            // 
            // GestionRiesgos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 348);
            Controls.Add(tabControl1);
            Name = "GestionRiesgos";
            Text = "Gestion de Riesgos";
            Load += GestionRiesgos_Load;
            F3F4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewF4_Clasificacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewF3_Calculos).EndInit();
            F2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewF2).EndInit();
            F1.ResumeLayout(false);
            F1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewF1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage F3F4;
        private Button btnGrabar;
        private Label label8;
        private Label label7;
        private DataGridView dataGridViewF4_Clasificacion;
        private Button button1;
        private Button btnCalcular;
        private Label lblF3;
        private DataGridView dataGridViewF3_Calculos;
        private TabPage F2;
        private Button btnborrarf2;
        private Button btnSiguienteF2;
        private Label label4;
        private Label label3;
        private DataGridView dataGridViewF2;
        private TabPage F1;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label lblFecha;
        private TextBox txtAnalista;
        private Label lblAnalista;
        private DataGridView dataGridViewF1;
        private TabControl tabControl1;
        private DataGridViewTextBoxColumn Funcion;
        private DataGridViewTextBoxColumn sustitucion;
        private DataGridViewTextBoxColumn Perturbacion;
        private DataGridViewTextBoxColumn extension;
        private DataGridViewTextBoxColumn Agresion;
        private DataGridViewTextBoxColumn Vulnerabilidad;
        private DataGridViewTextBoxColumn Caracter;
        private DataGridViewTextBoxColumn Probabilidad;
        private DataGridViewTextBoxColumn Riesgo;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn clasificacion;
        private DataGridViewTextBoxColumn ActivoBien;
        private DataGridViewTextBoxColumn Riesgo1;
        private DataGridViewTextBoxColumn Danios;
    }
}
