using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces

{
    public class PageDTO
    {
        public int Id { private set; get; }
        public int WebsiteId { private set; get; }
        public string Location { private set; get; }
        public PageDTO(int id, int websiteId, string location)
        {
            Id = id;
            WebsiteId = websiteId;
            Location = location;
        }

        public void Save(PageDTO pageDTO)
        {

        }
    }
}
