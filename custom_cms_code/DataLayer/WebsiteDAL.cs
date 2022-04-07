using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLayer
{
    class WebsiteDAL
    {
        public static DataTable Websites;

        public WebsiteDAL()
        {
            Websites = GlobalFuncs.SelectQueryFrom("websites");
        }
    }
}
