using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class BulletinController : Controller
    {
        KidKinderContext context= new KidKinderContext();
        public ActionResult Bulletin()
        { 
            var values =context.BookASeats.ToList();
            return View(values);
        }
    }
}