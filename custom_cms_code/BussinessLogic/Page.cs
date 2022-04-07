using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    class Page
    {
        public static int Id { get; private set; }
        public string Location { get; private set; }
        public static int WebsiteId { get; private set; }

        public Page(int id, int websiteId, string location)
        {
            Id = id;
            WebsiteId = websiteId;
            Location = location;
        }
    }
}
