using custom_cms_code.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace custom_cms_code.LogicLayer
{
    class Page
    {
        public static int Id;
        //public static string Name;
        public string Location { get; set; }
        public static int WebsiteId;

        public Page(int id)
        {
            DataRow CurrentPage = GetPages.Pages.Rows[id-1];
            Id = id;
            Location = (string)CurrentPage["location"];
            WebsiteId = (int)CurrentPage["website_id"];
        }
    }
}
