namespace SistemaPubs
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            autoresToolStripMenuItem = new ToolStripMenuItem();
            editorialesToolStripMenuItem = new ToolStripMenuItem();
            títulosToolStripMenuItem = new ToolStripMenuItem();
            tiendasToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            trabajosToolStripMenuItem = new ToolStripMenuItem();
            descuentosToolStripMenuItem = new ToolStripMenuItem();
            informaciónToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { autoresToolStripMenuItem, editorialesToolStripMenuItem, títulosToolStripMenuItem, tiendasToolStripMenuItem, ventasToolStripMenuItem, empleadosToolStripMenuItem, trabajosToolStripMenuItem, descuentosToolStripMenuItem, informaciónToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(686, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // autoresToolStripMenuItem
            // 
            autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            autoresToolStripMenuItem.Size = new Size(60, 20);
            autoresToolStripMenuItem.Text = "Autores";
            autoresToolStripMenuItem.Click += autoresToolStripMenuItem_Click;
            // 
            // editorialesToolStripMenuItem
            // 
            editorialesToolStripMenuItem.Name = "editorialesToolStripMenuItem";
            editorialesToolStripMenuItem.Size = new Size(73, 20);
            editorialesToolStripMenuItem.Text = "Editoriales";
            editorialesToolStripMenuItem.Click += editorialesToolStripMenuItem_Click;
            // 
            // títulosToolStripMenuItem
            // 
            títulosToolStripMenuItem.Name = "títulosToolStripMenuItem";
            títulosToolStripMenuItem.Size = new Size(54, 20);
            títulosToolStripMenuItem.Text = "Títulos";
            títulosToolStripMenuItem.Click += títulosToolStripMenuItem_Click;
            // 
            // tiendasToolStripMenuItem
            // 
            tiendasToolStripMenuItem.Name = "tiendasToolStripMenuItem";
            tiendasToolStripMenuItem.Size = new Size(59, 20);
            tiendasToolStripMenuItem.Text = "Tiendas";
            tiendasToolStripMenuItem.Click += tiendasToolStripMenuItem_Click_1;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(53, 20);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(77, 20);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // trabajosToolStripMenuItem
            // 
            trabajosToolStripMenuItem.Name = "trabajosToolStripMenuItem";
            trabajosToolStripMenuItem.Size = new Size(62, 20);
            trabajosToolStripMenuItem.Text = "Trabajos";
            trabajosToolStripMenuItem.Click += trabajosToolStripMenuItem_Click;
            // 
            // descuentosToolStripMenuItem
            // 
            descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            descuentosToolStripMenuItem.Size = new Size(80, 20);
            descuentosToolStripMenuItem.Text = "Descuentos";
            descuentosToolStripMenuItem.Click += descuentosToolStripMenuItem_Click;
            // 
            // informaciónToolStripMenuItem
            // 
            informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            informaciónToolStripMenuItem.Size = new Size(84, 20);
            informaciónToolStripMenuItem.Text = "Información";
            informaciónToolStripMenuItem.Click += informaciónToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 211);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Menú Principal";
            Load += FrmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem autoresToolStripMenuItem;
        private ToolStripMenuItem editorialesToolStripMenuItem;
        private ToolStripMenuItem títulosToolStripMenuItem;
        private ToolStripMenuItem tiendasToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem trabajosToolStripMenuItem;
        private ToolStripMenuItem descuentosToolStripMenuItem;
        private ToolStripMenuItem informaciónToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}