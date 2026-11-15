namespace SistemaPubs
{
    partial class FrmStores
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
            txtStorName = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtZip = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnConsultar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Tienda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 43);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Tienda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 89);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 134);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Ciudad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 181);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 226);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 5;
            label6.Text = "ZIP";
            // 
            // txtStorId
            // 
            txtStorId.Location = new Point(128, 0);
            txtStorId.Name = "txtStorId";
            txtStorId.Size = new Size(100, 23);
            txtStorId.TabIndex = 6;
            // 
            // txtStorName
            // 
            txtStorName.Location = new Point(128, 43);
            txtStorName.Name = "txtStorName";
            txtStorName.Size = new Size(100, 23);
            txtStorName.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(128, 89);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(128, 134);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 9;
            // 
            // txtState
            // 
            txtState.Location = new Point(128, 181);
            txtState.Name = "txtState";
            txtState.Size = new Size(100, 23);
            txtState.TabIndex = 10;
            // 
            // txtZip
            // 
            txtZip.Location = new Point(128, 226);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(100, 23);
            txtZip.TabIndex = 11;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 267);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 12;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(137, 267);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(250, 267);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(137, 310);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 16;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(250, 310);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmStores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 359);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtZip);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtStorName);
            Controls.Add(txtStorId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmStores";
            Text = "Mantenimiento de Tiendas";
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
        private TextBox txtStorName;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtZip;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnSalir;
    }
}