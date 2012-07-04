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
            //PhotoLenta phL = new PhotoLenta();
            //phL.Title = "dsfsf";
            //phL.Name = "afsdg";
            //phL.DateTime = DateTime.Now;
            //phL.Description = "sdfsdgdsgs";
            //_db.PhotoLentas.Add(phL);
            //_db.SaveChanges();

            var phLenta = _db.PhotoLentas.OrderByDescending(l=>l.DateTime);
            return View(phLenta.ToList());
        }

    }
}
