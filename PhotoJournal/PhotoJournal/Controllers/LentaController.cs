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

        PJContext _db = new PJContext();

        public ActionResult Index()
        {
            var phLenta = _db.PhotoLentas;
            return View(phLenta.ToList());
        }

    }
}
