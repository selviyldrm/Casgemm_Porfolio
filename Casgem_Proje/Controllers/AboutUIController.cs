using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Proje.Models.Entities;

namespace Casgem_Proje.Controllers
{
    public class AboutUIController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartialBreadcrumb()
        {
            return PartialView();
        }
        public ActionResult PartialAbout()
        {
            var values = db.TblSocialMedia.ToList();
            ViewBag.Name = db.TblUIAbout.Select(x => x.Name).FirstOrDefault();
            ViewBag.Surname = db.TblUIAbout.Select(x => x.Surname).FirstOrDefault();
            ViewBag.Address = db.TblUIAbout.Select(x => x.Adress).FirstOrDefault();
            ViewBag.Description = db.TblUIAbout.Select(x => x.Description).FirstOrDefault();
            ViewBag.PhoneNumber = db.TblUIAbout.Select(x => x.PhoneNumber).FirstOrDefault();
            ViewBag.ImageUrl = db.TblUIAbout.Select(x => x.Imageurl).FirstOrDefault();
            ViewBag.Mail = db.TblUIAbout.Select(x => x.Mail).FirstOrDefault();

            return PartialView(values);
        }
        public ActionResult PartialAbout2()
        {
            return PartialView();
        }
       
        public ActionResult PartialAbout3()
        {
            return PartialView();
        } 
        public ActionResult PartialNewsletter()
        {
            return PartialView();
        }
        public ActionResult PartialAchievements()
        {
            var values = db.TblProje.ToList();
            return PartialView(values);
        }
    }
}