using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace custom_cms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static WebsiteContainer wbC = new WebsiteContainer(new WebsiteDAL());
        [STAThread]
        static void Main()
        {
            wbC.Websites;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
