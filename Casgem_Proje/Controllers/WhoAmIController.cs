using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Proje.Models.Entities;

namespace Casgem_Proje.Controllers
{
    public class WhoAmIController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        public ActionResult Index()
        {
            var values = db.TblAbout.ToList();
            return View(values);
        }
    
        [HttpGet]
        public ActionResult UpdateWhoAmI(int id)
        {
            var values=db.TblAbout.Find(id);
            return View(values);
        } 
        [HttpPost]
        public ActionResult UpdateWhoAmI(TblAbout about)
        {
            var values=db.TblAbout.Find(about.AboutID);
            values.AboutTitle = about.AboutTitle;
            values.AboutDescription = about.AboutDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}