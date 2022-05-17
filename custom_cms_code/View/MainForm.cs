using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Form1 : Form
    {
        WebsiteContainer websites;
        PageContainer pages;
        public Form1()
        {
            InitializeComponent();
            websites = Program.wbC;
            pages = Program.pgC;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            websiteDataGridView.DataSource = websites.GetAllWebsites();
        }

        private void refreshWebsitesBtn_Click(object sender, EventArgs e)
        {
            websiteDataGridView.DataSource = websites.GetAllWebsites();
        }

        private void refreshPagesBtn_Click(object sender, EventArgs e)
        {
            int websitesId = (int)websiteDataGridView.Rows[websiteDataGridView.CurrentRow.Index].Cells[0].Value;
            MessageBox.Show("Website id = " + websitesId.ToString());
            pagesDataGridView.DataSource = pages.GetAll(websitesId);
        }

        private void refreshComponentsBtn_Click(object sender, EventArgs e)
        {

        }

        private void websiteDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int websitesId = (int)websiteDataGridView.Rows[websiteDataGridView.CurrentRow.Index].Cells[0].Value;
            MessageBox.Show("Website id = " + websitesId.ToString());
            pagesDataGridView.DataSource = pages.GetAll(websitesId);
        }
    }
}
