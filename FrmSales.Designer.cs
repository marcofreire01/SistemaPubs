namespace SistemaPubs
{
    partial class FrmSales
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtStorId = new TextBox();
            txtOrdNum = new TextBox();
            txtQty = new TextBox();
            txtPayTerms = new TextBox();
            txtTitleId = new TextBox();
            dtpOrdDate = new DateTimePicker();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnSalir = new Button();
            dgvSales = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Código Tienda:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Número Orden:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha Orden:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 150);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 4;
            label5.Text = "Forma de Pago:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 188);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 5;
            label6.Text = "Código Título:";
            // 
            // txtStorId
            // 
            txtStorId.Location = new Point(136, 6);
            txtStorId.Name = "txtStorId";
            txtStorId.Size = new Size(100, 23);
            txtStorId.TabIndex = 6;
            // 
            // txtOrdNum
            // 
            txtOrdNum.Location = new Point(136, 43);
            txtOrdNum.Name = "txtOrdNum";
            txtOrdNum.Size = new Size(100, 23);
            txtOrdNum.TabIndex = 7;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(136, 112);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(100, 23);
            txtQty.TabIndex = 9;
            // 
            // txtPayTerms
            // 
            txtPayTerms.Location = new Point(136, 147);
            txtPayTerms.Name = "txtPayTerms";
            txtPayTerms.Size = new Size(100, 23);
            txtPayTerms.TabIndex = 10;
            txtPayTerms.TextChanged += textBox5_TextChanged;
            // 
            // txtTitleId
            // 
            txtTitleId.Location = new Point(136, 185);
            txtTitleId.Name = "txtTitleId";
            txtTitleId.Size = new Size(100, 23);
            txtTitleId.TabIndex = 11;
            // 
            // dtpOrdDate
            // 
            dtpOrdDate.Format = DateTimePickerFormat.Short;
            dtpOrdDate.Location = new Point(134, 76);
            dtpOrdDate.Name = "dtpOrdDate";
            dtpOrdDate.Size = new Size(102, 23);
            dtpOrdDate.TabIndex = 12;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(14, 246);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(145, 246);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(269, 246);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 293);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(145, 293);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(269, 293);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(12, 322);
            dgvSales.MultiSelect = false;
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(332, 150);
            dgvSales.TabIndex = 19;
            // 
            // FrmSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 476);
            Controls.Add(dgvSales);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dtpOrdDate);
            Controls.Add(txtTitleId);
            Controls.Add(txtPayTerms);
            Controls.Add(txtQty);
            Controls.Add(txtOrdNum);
            Controls.Add(txtStorId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmSales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtStorId;
        private TextBox txtOrdNum;
        private TextBox txtQty;
        private TextBox txtTitleId;
        private DateTimePicker dtpOrdDate;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnSalir;
        private DataGridView dgvSales;
        private TextBox txtPayTerms;
    }
}