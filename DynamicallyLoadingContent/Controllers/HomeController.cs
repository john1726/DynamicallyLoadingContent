using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicallyLoadingContent.Models;
using DynamicallyLoadingContent.Models.Repositories;

namespace DynamicallyLoadingContent.Controllers
{
    public class HomeController : Controller
    {
        private Entities _db = new Entities();
        private IEmployeeInfoRepository _employeeInfoRepository;

        public HomeController()
        {
            _employeeInfoRepository = new EmployeeInfoRepository(_db);
        }

        public ActionResult Index()
        {
            return View(_employeeInfoRepository.GetAll());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}