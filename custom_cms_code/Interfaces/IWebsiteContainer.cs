using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IWebsiteContainer
    {
        public List<WebsiteDTO> GetAll();
        public WebsiteDTO FindById(int id);
        public void CreateWebsite(WebsiteDTO website);
        public void UpdateWebsite(WebsiteDTO website);
        public void DeleteWebsite(int id);
    }
}
