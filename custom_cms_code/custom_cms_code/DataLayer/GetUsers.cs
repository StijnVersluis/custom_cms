using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace custom_cms_code.DataLayer
{
    class GetUsers
    {
        public static DataTable Users;

        public GetUsers()
        {
            Users = GlobalFuncs.SelectQueryFrom("users");
        }
    }
}
