using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using custom_cms_code.DataLayer;
using System.Data;

namespace custom_cms_code.LogicLayer
{
    class Website
    {
        private int Id;
        public string name { get; }
        private string domain;
        DataRow WebsiteRow;
        public List<Page> Pages;
        public DataTable PagesDataTable;

        public Website(int id)
        {
            Id = id;
            WebsiteRow = GetWebsites.Websites.Rows[id-1];
            name = (string)WebsiteRow["name"];
            domain = (string)WebsiteRow["domain"];

            Pages = GetPagesFromWebsite(id);
            PagesDataTable = GetPages.GetDataTablePagesFromWebsite(id);
        }

        public static List<Page> GetPagesFromWebsite(int websiteId)
        {
            List<Page> resultList = new List<Page>();
            foreach (DataRow Page in GetPages.Pages.Rows) if ((int)Page["website_id"] == websiteId) resultList.Add(new Page((int)Page["id"]));
            return resultList;
        }
    }
}
