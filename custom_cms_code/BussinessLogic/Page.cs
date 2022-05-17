using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace LogicLayer
{
    public class Page
    {
        private IPage PageDAL;
        public int Id { private set; get; }
        public int WebsiteId { private set; get; }
        public string Location { private set; get; }
        public Page(IPage page)
        {
            PageDAL = page;
        }
        public Page(int id, int websiteId, string location)
        {
            Id = id;
            WebsiteId = websiteId;
            Location = location;
        }
        public Page(PageDTO pageDTO)
        {
            Id = pageDTO.Id;
            WebsiteId = pageDTO.WebsiteId;
            Location = pageDTO.Location;
        }
        public void EditPage(Page page)
        {
            PageDAL.EditPage(new PageDTO(page.Id, page.WebsiteId, page.Location));
        }
        public void DeletePage(Page page)
        {
            PageDAL.DeletePage(new PageDTO(page.Id, page.WebsiteId, page.Location));
        }
    }
}
