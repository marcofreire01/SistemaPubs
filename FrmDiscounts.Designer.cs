namespace SistemaPubs
{
    partial class FrmDiscounts
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
            txtDiscountType = new TextBox();
            txtStorId = new TextBox();
            txtLowQty = new TextBox();
            txtHighQty = new TextBox();
            txtDiscount = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnSalir = new Button();
            dgvDiscounts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDiscounts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Descuento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Código Tienda:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad Mínima:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad Máxima:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 220);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 4;
            label5.Text = "Porcentaje Descuento:";
            // 
            // txtDiscountType
            // 
            txtDiscountType.Location = new Point(199, 6);
            txtDiscountType.Name = "txtDiscountType";
            txtDiscountType.Size = new Size(100, 23);
            txtDiscountType.TabIndex = 5;
            // 
            // txtStorId
            // 
            txtStorId.Location = new Point(199, 55);
            txtStorId.Name = "txtStorId";
            txtStorId.Size = new Size(100, 23);
            txtStorId.TabIndex = 6;
            // 
            // txtLowQty
            // 
            txtLowQty.Location = new Point(199, 109);
            txtLowQty.Name = "txtLowQty";
            txtLowQty.Size = new Size(100, 23);
            txtLowQty.TabIndex = 7;
            // 
            // txtHighQty
            // 
            txtHighQty.Location = new Point(199, 161);
            txtHighQty.Name = "txtHighQty";
            txtHighQty.Size = new Size(100, 23);
            txtHighQty.TabIndex = 8;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(199, 217);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(100, 23);
            txtDiscount.TabIndex = 9;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 280);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(165, 280);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(318, 280);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 334);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(165, 334);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(318, 334);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvDiscounts
            // 
            dgvDiscounts.AllowUserToAddRows = false;
            dgvDiscounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiscounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscounts.Location = new Point(1, 378);
            dgvDiscounts.MultiSelect = false;
            dgvDiscounts.Name = "dgvDiscounts";
            dgvDiscounts.ReadOnly = true;
            dgvDiscounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiscounts.Size = new Size(419, 157);
            dgvDiscounts.TabIndex = 16;
            // 
            // FrmDiscounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 539);
            Controls.Add(dgvDiscounts);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtDiscount);
            Controls.Add(txtHighQty);
            Controls.Add(txtLowQty);
            Controls.Add(txtStorId);
            Controls.Add(txtDiscountType);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDiscounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Descuentos";
            Load += FrmDiscounts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiscounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDiscountType;
        private TextBox txtStorId;
        private TextBox txtLowQty;
        private TextBox txtHighQty;
        private TextBox txtDiscount;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnSalir;
        private DataGridView dgvDiscounts;
    }
}