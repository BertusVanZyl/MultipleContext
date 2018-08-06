using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Repositories;
using TwoContexts.EntityFrameworkCore.SecondContext.Models;

namespace TwoContexts.TEST
{
    public class TESTAppService : ITESTAppservice
    {
        private IRepository<MyTable> MyTableRepo;

        public TESTAppService(IRepository<MyTable> myTableRepo)
        {
            MyTableRepo = myTableRepo;
        }

        public string Test()
        {
            return this.MyTableRepo.GetAll().ToList().Count().ToString();
        }
    }
}
