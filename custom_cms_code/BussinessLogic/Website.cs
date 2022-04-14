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
        private PageContainer Pages;

        public Website(IWebsite website)
        {
            iWebsite = website;
        }

        public Website(int id, string name, string domain)
        {
            Id = id;
            Name = name;
            Domain = domain;
            Pages = new PageContainer(id);
        }

        public PageContainer GetPages()
        {
            return Pages;
        }
    }
}
