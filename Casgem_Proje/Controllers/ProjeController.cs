using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Proje.Models.Entities;

namespace Casgem_Proje.Controllers
{
    public class ProjeController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        public ActionResult Index()
        {
            var value = db.TblProje.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddProje()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProje(TblProje p)
        {
            db.TblProje.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProje(int id)
        {
            var value = db.TblProje.Find(id);
            db.TblProje.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProje(int id)
        {
            var value = db.TblProje.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProje(TblProje p)
        {
            var value = db.TblProje.Find(p.ProjeID);
            value.ProjeTitle = p.ProjeTitle;
            value.ProjeDescription = p.ProjeDescription;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }

}