using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace LogicLayer
{
    public class Page
    {
        public int Id { private set; get; }
        public int WebsiteId { private set; get; }
        public string Location { private set; get; }
        public Page(int id, int websiteId, string location)
        {
            Id = id;
            WebsiteId = websiteId;
            Location = location;
        }
        public Page(int websiteId, string location)
        {
            WebsiteId = websiteId;
            Location = location;
        }
        public Page(PageDTO pageDTO)
        {
            Id = pageDTO.Id;
            WebsiteId = pageDTO.WebsiteId;
            Location = pageDTO.Location;
        }
    }
}
