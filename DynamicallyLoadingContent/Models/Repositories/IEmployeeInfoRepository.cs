using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DynamicallyLoadingContent.Models.Common;

namespace DynamicallyLoadingContent.Models.Repositories
{
    public interface IEmployeeInfoRepository : IGenericRepository<EmployeeInfo>
    {
        EmployeeInfo GetById(int id);
    }
}