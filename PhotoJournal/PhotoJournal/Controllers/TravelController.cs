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
    public class TravelController : Controller
    {
        //
        // GET: /Travel/

        private DataManger _dataManager;
        public TravelController()
        {
            _dataManager = new DataManger();
        }

        public ActionResult Index()
        {
            var art = _dataManager.Article.GetAll();
            return View(art.ToList());
        }

    }
}
