namespace SistemaPubs
{
    partial class FrmTitleAuthor
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
            txtAuId = new TextBox();
            txtTitleId = new TextBox();
            txtAuOrd = new TextBox();
            txtRoyaltyPer = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnSalir = new Button();
            dgvTitleAuthor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTitleAuthor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Código Autor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Código Título:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Orden Autor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 3;
            label4.Text = "Porcentaje Regalía:";
            // 
            // txtAuId
            // 
            txtAuId.Location = new Point(165, 6);
            txtAuId.Name = "txtAuId";
            txtAuId.Size = new Size(100, 23);
            txtAuId.TabIndex = 4;
            txtAuId.TextChanged += textBox1_TextChanged;
            // 
            // txtTitleId
            // 
            txtTitleId.Location = new Point(165, 47);
            txtTitleId.Name = "txtTitleId";
            txtTitleId.Size = new Size(100, 23);
            txtTitleId.TabIndex = 5;
            // 
            // txtAuOrd
            // 
            txtAuOrd.Location = new Point(165, 93);
            txtAuOrd.Name = "txtAuOrd";
            txtAuOrd.Size = new Size(100, 23);
            txtAuOrd.TabIndex = 6;
            // 
            // txtRoyaltyPer
            // 
            txtRoyaltyPer.Location = new Point(165, 135);
            txtRoyaltyPer.Name = "txtRoyaltyPer";
            txtRoyaltyPer.Size = new Size(100, 23);
            txtRoyaltyPer.TabIndex = 7;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(19, 199);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(136, 199);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(251, 199);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(19, 254);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(136, 254);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(251, 254);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvTitleAuthor
            // 
            dgvTitleAuthor.AllowUserToAddRows = false;
            dgvTitleAuthor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTitleAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitleAuthor.Location = new Point(12, 294);
            dgvTitleAuthor.MultiSelect = false;
            dgvTitleAuthor.Name = "dgvTitleAuthor";
            dgvTitleAuthor.ReadOnly = true;
            dgvTitleAuthor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTitleAuthor.Size = new Size(329, 176);
            dgvTitleAuthor.TabIndex = 14;
            // 
            // FrmTitleAuthor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 482);
            Controls.Add(dgvTitleAuthor);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtRoyaltyPer);
            Controls.Add(txtAuOrd);
            Controls.Add(txtTitleId);
            Controls.Add(txtAuId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmTitleAuthor";
            Text = "Relación Autor - Título";
            Load += FrmTitleAuthor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTitleAuthor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAuId;
        private TextBox txtTitleId;
        private TextBox txtAuOrd;
        private TextBox txtRoyaltyPer;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnSalir;
        private DataGridView dgvTitleAuthor;
    }
}