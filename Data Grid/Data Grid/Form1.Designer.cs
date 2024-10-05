namespace Data_Grid
{
    partial class Form1
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
            lblMin = new Label();
            txtMin = new TextBox();
            txtMax = new TextBox();
            lblMax = new Label();
            txtPrecio = new TextBox();
            lblprecio = new Label();
            btnCalcular = new Button();
            btnBorrar = new Button();
            dataGridView1 = new DataGridView();
            Consumo = new DataGridViewTextBoxColumn();
            CxKm = new DataGridViewTextBoxColumn();
            KmXgalon = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(12, 28);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(100, 20);
            lblMin.TabIndex = 0;
            lblMin.Text = "Consumo Min";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(118, 25);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(125, 27);
            txtMin.TabIndex = 1;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(355, 29);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(125, 27);
            txtMax.TabIndex = 3;
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(249, 32);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(103, 20);
            lblMax.TabIndex = 2;
            lblMax.Text = "Consumo Max";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(552, 32);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 5;
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Location = new Point(488, 35);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(58, 20);
            lblprecio.TabIndex = 4;
            lblprecio.Text = "PRECIO";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 78);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(116, 56);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(149, 78);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 56);
            btnBorrar.TabIndex = 7;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Consumo, CxKm, KmXgalon });
            dataGridView1.Location = new Point(12, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(428, 188);
            dataGridView1.TabIndex = 8;
            // 
            // Consumo
            // 
            Consumo.HeaderText = "Consumo L\\100Km";
            Consumo.MinimumWidth = 6;
            Consumo.Name = "Consumo";
            Consumo.Width = 125;
            // 
            // CxKm
            // 
            CxKm.HeaderText = "Costo x Km";
            CxKm.MinimumWidth = 6;
            CxKm.Name = "CxKm";
            CxKm.Width = 125;
            // 
            // KmXgalon
            // 
            KmXgalon.HeaderText = "Km x Galon";
            KmXgalon.MinimumWidth = 6;
            KmXgalon.Name = "KmXgalon";
            KmXgalon.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 354);
            Controls.Add(dataGridView1);
            Controls.Add(btnBorrar);
            Controls.Add(btnCalcular);
            Controls.Add(txtPrecio);
            Controls.Add(lblprecio);
            Controls.Add(txtMax);
            Controls.Add(lblMax);
            Controls.Add(txtMin);
            Controls.Add(lblMin);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMin;
        private TextBox txtMin;
        private TextBox txtMax;
        private Label lblMax;
        private TextBox txtPrecio;
        private Label lblprecio;
        private Button btnCalcular;
        private Button btnBorrar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Consumo;
        private DataGridViewTextBoxColumn CxKm;
        private DataGridViewTextBoxColumn KmXgalon;
    }
}
