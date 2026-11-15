namespace SistemaPubs
{
    partial class FrmRoysched
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
            txtTitleId = new TextBox();
            txtLoRange = new TextBox();
            txtHiRange = new TextBox();
            txtRoyalty = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnSalir = new Button();
            dgvRoysched = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRoysched).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Código Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Rango Inferior:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Rango Superior:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Regalía (%):";
            // 
            // txtTitleId
            // 
            txtTitleId.Location = new Point(134, 6);
            txtTitleId.Name = "txtTitleId";
            txtTitleId.Size = new Size(100, 23);
            txtTitleId.TabIndex = 4;
            // 
            // txtLoRange
            // 
            txtLoRange.Location = new Point(134, 53);
            txtLoRange.Name = "txtLoRange";
            txtLoRange.Size = new Size(100, 23);
            txtLoRange.TabIndex = 5;
            // 
            // txtHiRange
            // 
            txtHiRange.Location = new Point(134, 103);
            txtHiRange.Name = "txtHiRange";
            txtHiRange.Size = new Size(100, 23);
            txtHiRange.TabIndex = 6;
            // 
            // txtRoyalty
            // 
            txtRoyalty.Location = new Point(134, 155);
            txtRoyalty.Name = "txtRoyalty";
            txtRoyalty.Size = new Size(100, 23);
            txtRoyalty.TabIndex = 7;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(19, 235);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(144, 235);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(269, 235);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(19, 281);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(144, 281);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(269, 281);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvRoysched
            // 
            dgvRoysched.AllowUserToAddRows = false;
            dgvRoysched.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoysched.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoysched.Location = new Point(12, 320);
            dgvRoysched.MultiSelect = false;
            dgvRoysched.Name = "dgvRoysched";
            dgvRoysched.ReadOnly = true;
            dgvRoysched.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoysched.Size = new Size(344, 150);
            dgvRoysched.TabIndex = 14;
            // 
            // FrmRoysched
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 482);
            Controls.Add(dgvRoysched);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtRoyalty);
            Controls.Add(txtHiRange);
            Controls.Add(txtLoRange);
            Controls.Add(txtTitleId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRoysched";
            Text = "Mantenimiento de Regalías";
            ((System.ComponentModel.ISupportInitialize)dgvRoysched).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTitleId;
        private TextBox txtLoRange;
        private TextBox txtHiRange;
        private TextBox txtRoyalty;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnSalir;
        private DataGridView dgvRoysched;
    }
}