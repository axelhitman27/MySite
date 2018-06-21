using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BetData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = GetData();
            return View(model);
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

        public DataTable GetData()
        {
            DataTable dataDT = new DataTable();

            return dataDT;
        }
    }
}