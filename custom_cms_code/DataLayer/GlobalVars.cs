using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class GlobalVars
    {
        public static DataTable Users { get; }
        public static DataTable Websites { get; }

        public static string connectionString = "Server=mssqlstud.fhict.local;Database=dbi482774_customcms;User Id=dbi482774_customcms;Password=KmKl1234!@;";
    }
}
