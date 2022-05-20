using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class WebsiteContainer
    {
        private IWebsiteContainer Wb;

        public WebsiteContainer(IWebsiteContainer wb)
        {
            Wb = wb;
        }

        public List<Website> GetAllWebsites()
        {
            List<Website> wbs = new List<Website>();
            Wb.GetAll().ForEach(w =>
                wbs.Add(new Website(w))
            );
            return wbs;
        }

        public Website FindWebsiteById(int id)
        {
            return new Website(Wb.FindById(id));
        }

        public void CreateWebsite(Website website)
        {
            Wb.CreateWebsite(new WebsiteDTO(website.Name, website.Domain));
        }

        public void UpdateWebsite(Website website)
        {
            Wb.UpdateWebsite(new WebsiteDTO(website.Id, website.Name, website.Domain));
        }

        public void DeleteWebsite(int id)
        {
            Wb.DeleteWebsite(id);
        }
    }
}
