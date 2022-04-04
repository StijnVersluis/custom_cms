using System;
using custom_cms_code.UI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using custom_cms_code.LogicLayer;

namespace custom_cms_code
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
