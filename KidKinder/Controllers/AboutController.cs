using KidKinder.Context;
using KidKinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class AboutController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            
            return View();
        }
        public PartialViewResult AboutHeaderPartial()
        {
            return PartialView();
        }


    }
}