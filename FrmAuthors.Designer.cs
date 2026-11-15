namespace SistemaPubs
{
    partial class FrmAuthors
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
            chkContrato = new CheckBox();
            buttonNuevo = new Button();
            buttonGuardar = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            buttonConsultar = new Button();
            buttonSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtId = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // chkContrato
            // 
            chkContrato.AutoSize = true;
            chkContrato.Location = new Point(1, 283);
            chkContrato.Name = "chkContrato";
            chkContrato.Size = new Size(73, 19);
            chkContrato.TabIndex = 8;
            chkContrato.Text = "Contrato";
            chkContrato.UseVisualStyleBackColor = true;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(1, 319);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(75, 23);
            buttonNuevo.TabIndex = 17;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(82, 319);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 18;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(163, 319);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 19;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(1, 348);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 20;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(82, 348);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(75, 23);
            buttonConsultar.TabIndex = 21;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(163, 348);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(75, 23);
            buttonSalir.TabIndex = 22;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += ButtonSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 23;
            label1.Text = "ID Autor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 24;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 25;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 111);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 26;
            label4.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 150);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 27;
            label5.Text = "Dirección";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 187);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 28;
            label6.Text = "Ciudad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 225);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 29;
            label7.Text = "Estado";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 255);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 30;
            label8.Text = "Zip";
            // 
            // txtId
            // 
            txtId.Location = new Point(82, 6);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 31;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(82, 37);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 32;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(82, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 33;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(82, 108);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 34;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(82, 147);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 35;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 36;
            // 
            // FrmAuthors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 392);
            Controls.Add(textBox1);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonConsultar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(chkContrato);
            Name = "FrmAuthors";
            Text = "Mantenimiento de Autores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox chkContrato;
        private Button buttonNuevo;
        private Button buttonGuardar;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Button buttonConsultar;
        private Button buttonSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtId;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox textBox1;
    }
}