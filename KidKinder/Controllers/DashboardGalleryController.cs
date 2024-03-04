using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;
using Microsoft.Ajax.Utilities;

namespace KidKinder.Controllers
{
    public class DashboardGalleryController : Controller
    {
   KidKinderContext context=new KidKinderContext();
        public ActionResult GalleryList()
        {
            var values =context.Gallery.ToList();
            return View(values);
        }
        public ActionResult ActiveGallery(int id)
        {
            var values = context.Gallery.Find(id);
          
            context.SaveChanges();
            return RedirectToAction("GalleryList");
        }
        public ActionResult PassiveGallery(int id)
        {
            var values = context.Gallery.Find(id);
            
            context.SaveChanges();
            return RedirectToAction("GalleryList");
        }
        [HttpGet]
        public ActionResult CreateGalleryAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateGallery(Gallery gallery)
        {
            var values = context.Gallery.Add(gallery);
           
            context.SaveChanges();
            return RedirectToAction("GalleryList");
        }
    }
}
    
