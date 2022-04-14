using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class WebsiteDTO
    {
        public int Id { private set; get; }
        public string Name { private set; get; }
        public string Domain { private set; get; }
        public WebsiteDTO(int id, string name, string domain)
        {
            Id = id;
            Name = name;
            Domain = domain;
        }
    }
}
