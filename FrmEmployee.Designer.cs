namespace SistemaPubs
{
    partial class FrmEmployee
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
            label7 = new Label();
            label8 = new Label();
            txtEmpId = new TextBox();
            txtFName = new TextBox();
            txtMInit = new TextBox();
            txtLName = new TextBox();
            txtJobId = new TextBox();
            txtJobLvl = new TextBox();
            txtPubId = new TextBox();
            dtpHireDate = new DateTimePicker();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnSalir = new Button();
            dgvEmployee = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Código Empleado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Inicial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 125);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Job ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 154);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 5;
            label6.Text = "Nivel Trabajo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 183);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 6;
            label7.Text = "Publisher ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 216);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 7;
            label8.Text = "Fecha Contratación:";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(168, 6);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(100, 23);
            txtEmpId.TabIndex = 8;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(168, 35);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(100, 23);
            txtFName.TabIndex = 9;
            // 
            // txtMInit
            // 
            txtMInit.Location = new Point(168, 64);
            txtMInit.Name = "txtMInit";
            txtMInit.Size = new Size(100, 23);
            txtMInit.TabIndex = 10;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(168, 93);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(100, 23);
            txtLName.TabIndex = 11;
            // 
            // txtJobId
            // 
            txtJobId.Location = new Point(168, 122);
            txtJobId.Name = "txtJobId";
            txtJobId.Size = new Size(100, 23);
            txtJobId.TabIndex = 12;
            // 
            // txtJobLvl
            // 
            txtJobLvl.Location = new Point(168, 151);
            txtJobLvl.Name = "txtJobLvl";
            txtJobLvl.Size = new Size(100, 23);
            txtJobLvl.TabIndex = 13;
            // 
            // txtPubId
            // 
            txtPubId.Location = new Point(168, 180);
            txtPubId.Name = "txtPubId";
            txtPubId.Size = new Size(100, 23);
            txtPubId.TabIndex = 14;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Format = DateTimePickerFormat.Short;
            dtpHireDate.Location = new Point(168, 210);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(100, 23);
            dtpHireDate.TabIndex = 15;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(15, 266);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 16;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(139, 266);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(259, 266);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(13, 307);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(139, 307);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(259, 307);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToDeleteRows = false;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(3, 336);
            dgvEmployee.MultiSelect = false;
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(351, 150);
            dgvEmployee.TabIndex = 22;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 491);
            Controls.Add(dgvEmployee);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dtpHireDate);
            Controls.Add(txtPubId);
            Controls.Add(txtJobLvl);
            Controls.Add(txtJobId);
            Controls.Add(txtLName);
            Controls.Add(txtMInit);
            Controls.Add(txtFName);
            Controls.Add(txtEmpId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEmployee";
            Text = "Mantenimiento de Empleados";
            Load += FrmEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
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
        private Label label7;
        private Label label8;
        private TextBox txtEmpId;
        private TextBox txtFName;
        private TextBox txtMInit;
        private TextBox txtLName;
        private TextBox txtJobId;
        private TextBox txtJobLvl;
        private TextBox txtPubId;
        private DateTimePicker dtpHireDate;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnSalir;
        private DataGridView dgvEmployee;
    }
}