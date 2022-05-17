using System;
using custom_cms_code.UI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace custom_cms_codeUI
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

            if (!Regex.IsMatch(email, @"^[a-z\.\-]+@[a-z0-9]+\.[a-z]{2,3}$")) return; //email is not an email
            if (email.ToLower() != "stijn.versluis@gmail.com" || pass == "Test123") return; //email and pass not correct

            this.Close();
            
        }
    }
}
