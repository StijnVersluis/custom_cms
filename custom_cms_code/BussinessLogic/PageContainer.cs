using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class PageContainer
    {
        private IPageContainer iPageContainer;
        public PageContainer(IPageContainer pageContainer)
        {
            iPageContainer = pageContainer;
        }
        public List<Page> GetAll(int websiteId)
        {
            var res = new List<Page>();
            iPageContainer.GetAll(websiteId).ForEach(w=>
            {
                res.Add(new Page(w));
            });
            return res;
        }
        public Page FindPageById(int id)
        {
            return new Page(iPageContainer.FindById(id));
        }
        public void SavePages()
        {
            throw new NotImplementedException();
        }
    }
}
