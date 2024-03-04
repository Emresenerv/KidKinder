using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class AdminContactController : Controller
    {
     KidKinderContext contex=new KidKinderContext();
        public ActionResult Index()
        {
            var values = contex.Communications.ToList();
            return View(values);
        }
    }
}