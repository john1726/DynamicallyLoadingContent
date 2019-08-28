using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicallyLoadingContent.Models;
using DynamicallyLoadingContent.Models.Common;
using DynamicallyLoadingContent.Models.Repositories;

namespace DynamicallyLoadingContent.Controllers
{
    public class HomeController : Controller
    {
        private readonly Entities _db = new Entities();
        private readonly UnitOfWork _unitOfWork = null;

        public HomeController()
        {
            _unitOfWork = new UnitOfWork(_db);
        }

        public ActionResult Index()
        {
            return View(_unitOfWork.EmployeeInfoRepository.GetAll());
        }

        public ActionResult EmployeeInfo(int id)
        {
            List<EmployeeInfo> empInfo = _unitOfWork.EmployeeInfoRepository.GetAll().Where(x => x.Id == id).ToList();
            return View(empInfo);
        }
    }
}