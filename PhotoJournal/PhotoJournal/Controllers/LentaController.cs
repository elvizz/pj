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

        readonly PJContext _db = new PJContext();
        private const int ItemsOnPage = 5;

        public ActionResult Index(int page=1)
        {
            var phLenta = _db.PhotoLentas.OrderByDescending(l => l.DateTime).Skip((page - 1) * ItemsOnPage).Take(ItemsOnPage);
            ViewBag.Page = page;
            ViewBag.PagesCount = (int)Math.Ceiling((decimal)_db.PhotoLentas.Count() / ItemsOnPage);
            return View(phLenta.ToList());
        }
    }
}
