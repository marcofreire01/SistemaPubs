namespace SistemaPubs
{
    partial class FrmJobs
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
            txtJobId = new TextBox();
            txtJobDesc = new TextBox();
            txtMinLvl = new TextBox();
            txtMaxLvl = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnSalir = new Button();
            dgvJobs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Trabajo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Nivel Mínimo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "Nivel Máximo:";
            // 
            // txtJobId
            // 
            txtJobId.Location = new Point(137, 16);
            txtJobId.Name = "txtJobId";
            txtJobId.Size = new Size(100, 23);
            txtJobId.TabIndex = 4;
            // 
            // txtJobDesc
            // 
            txtJobDesc.Location = new Point(137, 62);
            txtJobDesc.Name = "txtJobDesc";
            txtJobDesc.Size = new Size(100, 23);
            txtJobDesc.TabIndex = 5;
            // 
            // txtMinLvl
            // 
            txtMinLvl.Location = new Point(137, 105);
            txtMinLvl.Name = "txtMinLvl";
            txtMinLvl.Size = new Size(100, 23);
            txtMinLvl.TabIndex = 6;
            // 
            // txtMaxLvl
            // 
            txtMaxLvl.Location = new Point(137, 155);
            txtMaxLvl.Name = "txtMaxLvl";
            txtMaxLvl.Size = new Size(100, 23);
            txtMaxLvl.TabIndex = 7;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 220);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(137, 220);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(268, 220);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 282);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(137, 282);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(268, 282);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click_1;
            // 
            // dgvJobs
            // 
            dgvJobs.AllowUserToAddRows = false;
            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Location = new Point(12, 324);
            dgvJobs.MultiSelect = false;
            dgvJobs.Name = "dgvJobs";
            dgvJobs.ReadOnly = true;
            dgvJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobs.Size = new Size(340, 150);
            dgvJobs.TabIndex = 14;
            // 
            // FrmJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 475);
            Controls.Add(dgvJobs);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtMaxLvl);
            Controls.Add(txtMinLvl);
            Controls.Add(txtJobDesc);
            Controls.Add(txtJobId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmJobs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Puestos";
            Load += FrmJobs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtJobId;
        private TextBox txtJobDesc;
        private TextBox txtMinLvl;
        private TextBox txtMaxLvl;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnSalir;
        private DataGridView dgvJobs;
    }
}