using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Proje.Models.Entities;

namespace Casgem_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            ViewBag.FeatureTitle = db.TblFeature.Select(x => x.FeatureTitle).FirstOrDefault();
            ViewBag.FeatureDescription = db.TblFeature.Select(x => x.FeatureDescription).FirstOrDefault();
            ViewBag.FeatureImageURl = db.TblFeature.Select(x => x.FeatureImageURl).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult MyResume()
        {
            var values = db.TblResume.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            ViewBag.totalService = db.TblService.Count();
            ViewBag.totalMessage = db.TblMessage.Count();
            ViewBag.totalThanksMessage = db.TblMessage.Where(x => x.MessageSubject == "Teşekkür").Count();
            ViewBag.happyCustomer = 12;
            return PartialView();
        }
        public PartialViewResult PartialWhoAmI()
        {
            ViewBag.AboutTitle = db.TblAbout.Select(x => x.AboutTitle).FirstOrDefault();
            ViewBag.AboutDescription = db.TblAbout.Select(x => x.AboutDescription).FirstOrDefault();
            ViewBag.AboutImageURl = db.TblAbout.Select(x => x.AboutImageUrl).FirstOrDefault();
            ViewBag.dosya = db.TblAbout.Select(x => x.AboutFile).FirstOrDefault();
            return PartialView();
        }
        [HttpGet]
        public ActionResult Download()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(this.Server.MapPath("\\Templates\\SelviSümeyraYıdırımCv.pdf"));
            string fileName = "SelviSümeyraYıdırımCv.pdf";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
        public PartialViewResult PartialService()
        { var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialScript()
        {
           
            return PartialView();
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = db.TblReference.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialVideo()
        {
            var values = db.TblVideo.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFreelance()
        {
            return PartialView();
        }
    }
}