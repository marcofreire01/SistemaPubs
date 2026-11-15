namespace SistemaPubs
{
    partial class FrmPublishers
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
            txtPubId = new TextBox();
            txtPubName = new TextBox();
            txtCityy = new TextBox();
            txtState = new TextBox();
            txtCountry = new TextBox();
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
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Editorial\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 40);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Editorial\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 90);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Ciudad\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 133);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 175);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "País";
            // 
            // txtPubId
            // 
            txtPubId.Location = new Point(118, 0);
            txtPubId.Name = "txtPubId";
            txtPubId.Size = new Size(100, 23);
            txtPubId.TabIndex = 5;
            // 
            // txtPubName
            // 
            txtPubName.Location = new Point(118, 40);
            txtPubName.Name = "txtPubName";
            txtPubName.Size = new Size(100, 23);
            txtPubName.TabIndex = 6;
            // 
            // txtCityy
            // 
            txtCityy.Location = new Point(118, 90);
            txtCityy.Name = "txtCityy";
            txtCityy.Size = new Size(100, 23);
            txtCityy.TabIndex = 7;
            // 
            // txtState
            // 
            txtState.Location = new Point(118, 133);
            txtState.Name = "txtState";
            txtState.Size = new Size(100, 23);
            txtState.TabIndex = 8;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(118, 175);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(100, 23);
            txtCountry.TabIndex = 9;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(0, 228);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(118, 228);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(234, 228);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(0, 292);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar\n";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(118, 292);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 14;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(234, 292);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += BtnSalir_Click;
            // 
            // FrmPublishers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 365);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtCountry);
            Controls.Add(txtState);
            Controls.Add(txtCityy);
            Controls.Add(txtPubName);
            Controls.Add(txtPubId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmPublishers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Editoriales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPubId;
        private TextBox txtPubName;
        private TextBox txtCityy;
        private TextBox txtState;
        private TextBox txtCountry;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnConsultar;
        private Button btnSalir;
    }
}