using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Proje.Models.Entities;

namespace Casgem_Proje.Controllers
{
    public class ReferenceController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        public ActionResult Index()
        {
            var value = db.TblReference.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult AddReference()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddReference(TblReference p)
        {
            db.TblReference.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteReference(int id)
        {
            var value = db.TblReference.Find(id);
            db.TblReference.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet] 
        public ActionResult UpdateReference(int id)
        {
            var value = db.TblReference.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateReference(TblReference p)
        {
            var value = db.TblReference.Find(p.ReferenceID);
            value.ReferenceNameSurname = p.ReferenceNameSurname;
            value.ReferenceDescription = p.ReferenceDescription;
            value.ReferenceImageUrl = p.ReferenceImageUrl;
            value.ReferenceCity = p.ReferenceCity;
            db.SaveChanges();
            return RedirectToAction("Index"); 
          
        }
    }
}