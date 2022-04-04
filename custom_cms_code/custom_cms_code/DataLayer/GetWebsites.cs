using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using custom_cms_code.LogicLayer;

namespace custom_cms_code.DataLayer
{
    class GetWebsites
    {
        public static DataTable Websites;

        public GetWebsites()
        {
            Websites = GlobalFuncs.SelectQueryFrom("websites");
        }
    }
}
