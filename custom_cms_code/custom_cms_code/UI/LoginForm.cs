using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace custom_cms_code.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = EmailTxb.Text;
            string pass = PassTxb.Text;

            if (email.ToLower() != "stijn.versluis@gmail.com" || pass == "Test123") return;

            this.Close();
            
        }
    }
}
