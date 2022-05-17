using System;
using View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using LogicLayer;
using Interfaces;

namespace View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //LoginForm lg = new LoginForm();
            //this.Hide();
            //lg.ShowDialog();
            //this.Show();
            var webbie = new Website(1);
            dataGridView1.DataSource = webbie.PagesDataTable;
            webbie.Pages.ForEach(page => listBox1.Items.Add(page.Location));
        }
    }
}
