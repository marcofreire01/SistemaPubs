namespace SistemaPubs
{
    partial class FrmPubInfo
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
            txtPubId = new TextBox();
            picLogo = new PictureBox();
            rtbPrInfo = new RichTextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnSalir = new Button();
            dgvPubInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPubInfo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Publisher ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Logo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 164);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Información:";
            // 
            // txtPubId
            // 
            txtPubId.Location = new Point(134, 6);
            txtPubId.Name = "txtPubId";
            txtPubId.Size = new Size(100, 23);
            txtPubId.TabIndex = 3;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(134, 35);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(150, 120);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 4;
            picLogo.TabStop = false;
            // 
            // rtbPrInfo
            // 
            rtbPrInfo.Location = new Point(134, 164);
            rtbPrInfo.Name = "rtbPrInfo";
            rtbPrInfo.Size = new Size(100, 96);
            rtbPrInfo.TabIndex = 5;
            rtbPrInfo.Text = "";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 285);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(150, 285);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(273, 285);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 330);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(150, 330);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(273, 330);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvPubInfo
            // 
            dgvPubInfo.AllowUserToAddRows = false;
            dgvPubInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPubInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPubInfo.Location = new Point(12, 359);
            dgvPubInfo.MultiSelect = false;
            dgvPubInfo.Name = "dgvPubInfo";
            dgvPubInfo.ReadOnly = true;
            dgvPubInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPubInfo.Size = new Size(336, 132);
            dgvPubInfo.TabIndex = 12;
            // 
            // FrmPubInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 493);
            Controls.Add(dgvPubInfo);
            Controls.Add(btnSalir);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(rtbPrInfo);
            Controls.Add(picLogo);
            Controls.Add(txtPubId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPubInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Información de Editoriales";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPubInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPubId;
        private PictureBox picLogo;
        private RichTextBox rtbPrInfo;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnSalir;
        private DataGridView dgvPubInfo;
    }
}