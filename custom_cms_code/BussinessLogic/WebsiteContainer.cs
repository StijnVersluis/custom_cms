using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class WebsiteContainer
    {
        private IWebsiteContainer Wb;
        public List<Website> Websites;

        public WebsiteContainer(IWebsiteContainer wb)
        {
            Wb = wb;
            Websites = new List<Website>();
            Websites.Add(new Website(1, "versluisdev.nl", "versluisdev.nl"));
            Websites.Add(new Website(2, "versluisdev.com", "versluisdev.com"));
        }

        public List<Website> GetAllWebsites()
        {
            return Websites;
        }

        public Website FindWebsiteById(int id)
        {
            Website result = new Website(0, "NonExist", "NonExist");
            Websites.ForEach(w => { if (w.Id == id) result = w; });
            return result;
        }

        public PageContainer GetAllWebsitePages(int websiteId)
        {
            Website result = new Website(0, "NonExist", "NonExist");
            Websites.ForEach(w => { if (w.Id == websiteId) result = w; });
            return result.GetPages();
        }
    }
}
