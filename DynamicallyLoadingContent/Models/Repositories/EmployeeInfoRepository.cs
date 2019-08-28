using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DynamicallyLoadingContent.Models.Common;

namespace DynamicallyLoadingContent.Models.Repositories
{
    public class EmployeeInfoRepository : GenericRepository<EmployeeInfo>, IEmployeeInfoRepository
    {
        public EmployeeInfoRepository(DbContext context)
            : base(context)
        {

        }
        public EmployeeInfo GetById(int id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }
    }
}