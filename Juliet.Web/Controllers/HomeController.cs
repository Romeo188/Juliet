using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.Mvc;
using Juliet.Web.Repository;

namespace Juliet.Web.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult GetSoloHistoryJsonResult()
        {
            var soloHistory = SoloRepository.GetSoloHistory();
            return Json(soloHistory, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}