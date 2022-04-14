using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class PageDAL : IPage, IPageContainer
    {
        public PageDTO FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PageDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
