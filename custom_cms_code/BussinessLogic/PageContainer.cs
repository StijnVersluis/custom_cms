using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class PageContainer
    {
        private IPageContainer iPageContainer;
        private List<Page> Pages;
        public PageContainer(IPageContainer pageContainer)
        {
            iPageContainer = pageContainer;
        }
        public PageContainer(int websiteId)
        {

        }
        public List<Page> GetAll()
        {
            return Pages;
        }
        public Page FindPageById(int id)
        {
            return new Page(1, 1, "index.php");
        }
        public void SavePages()
        {
            throw new NotImplementedException();
        }
    }
}
