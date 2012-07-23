using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoJournal.Models;

namespace PhotoJournal.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        private DataManger _dataManger;

        public HomeController()
        {
            _dataManger = new DataManger();
        }

        [NonAction]
        public ActionResult Index()
        {
            ViewBag.Message = "Фото месяца";
            var phLenta = _dataManger.Lenta.GetAll().Take(4);
            return View(phLenta.ToList());
        }
    }
}
