using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Proje.Models.Entities;

namespace Casgem_Proje.Controllers
{
    public class AboutController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
       
        public ActionResult Index()
        {
            return View();
        }
    }
}