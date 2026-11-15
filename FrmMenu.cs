using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaPubs
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
        private void RoyschedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRoysched frm = new FrmRoysched();
            frm.ShowDialog();
        }
        private void TitleAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTitleAuthor frm = new FrmTitleAuthor();
            frm.ShowDialog();
        }
          private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAuthors frm = new FrmAuthors();
            frm.ShowDialog();
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPublishers frm = new FrmPublishers();
            frm.ShowDialog();
        }

        private void títulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTitles frm = new FrmTitles();
            frm.ShowDialog();
        }

        private void tiendasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmStores frm = new FrmStores();
            frm.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSales frm = new FrmSales();
            frm.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployee frm = new FrmEmployee();
            frm.ShowDialog();
        }

        private void trabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJobs frm = new FrmJobs();
            frm.ShowDialog();
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiscounts frm = new FrmDiscounts();
            frm.ShowDialog();
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPubInfo frm = new FrmPubInfo();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
