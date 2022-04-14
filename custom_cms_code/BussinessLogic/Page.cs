using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace LogicLayer
{
    public class Page
    {
        private IPage iPage;
        public int Id { private set; get; }
        public int WebsiteId { private set; get; }
        public string Location { private set; get; }
        public Page(IPage page)
        {
            iPage = page;
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
        public void EditPage(IPage pageDal)
        {
            //pageDal.Edit();
        }
    }
}
