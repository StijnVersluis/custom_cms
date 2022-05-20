using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class Website
    {
        private IWebsite iWebsite;
        public int Id { private set; get; }
        public string Name { private set; get; }
        public string Domain { private set; get; }

        public Website(IWebsite website)
        {
            iWebsite = website;
        }

        public Website(int id, string name, string domain)
        {
            Id = id;
            Name = name;
            Domain = domain;
        }
        public Website(string name, string domain)
        {
            Name = name;
            Domain = domain;
        }

        public Website(WebsiteDTO website)
        {
            Id = website.Id;
            Name = website.Name;
            Domain = website.Domain;
        }
    }
}
