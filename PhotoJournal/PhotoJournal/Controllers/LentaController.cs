using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PhotoJournal.Models;

namespace PhotoJournal.Controllers
{
    public class LentaController : Controller
    {
        //
        // GET: /PhotoLenta/

        private DataManger _dataManger;
        public LentaController()
        {
            _dataManger = new DataManger();
        }

        private const int ItemsOnPage = 5;
        public ActionResult Index(int page=1)
        {
            var phLenta = _dataManger.Lenta.GetAll().Skip((page - 1)*ItemsOnPage).Take(ItemsOnPage);
            ViewBag.Page = page;
            ViewBag.PagesCount = (int)Math.Ceiling((decimal)_dataManger.Lenta.GetAll().Count() / ItemsOnPage);
            return View(phLenta.ToList());
        }

        public ActionResult Photo(Guid id)
        {
            var photo = _dataManger.Lenta.GetItem(id);
            return View(photo);
        }
    }
}
