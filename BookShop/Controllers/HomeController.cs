using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Elmo.Business;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetBooks()
        {
            BookLogic bLogic = new BookLogic();

            var result = bLogic.GetBook(null);
            

            return Json(result);
        }
    }
}