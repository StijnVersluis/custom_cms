using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class PageDAL
    {
        public static DataTable Pages;

        public PageDAL()
        {
            Pages = GlobalFuncs.SelectQueryFrom("pages");
        }

        public static DataTable GetDataTablePagesFromWebsite(int websiteId)
        {
            string[] dbColumns = new string[] { "id", "website_id", "location" };
            DataTable websitePages = new DataTable();
            DataRow NewRow = websitePages.NewRow();
            foreach (string str in dbColumns) websitePages.Columns.Add(new DataColumn(str));

            foreach (DataRow page in Pages.Rows)
            {
                if ((int)page["website_id"] == websiteId)
                {
                    foreach(string str in dbColumns) NewRow[str] = page[str];
                    websitePages.Rows.Add(NewRow);
                }
            }
            return websitePages;
        }
    }
}
