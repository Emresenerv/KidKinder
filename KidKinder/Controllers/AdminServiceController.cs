using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;


namespace KidKinder.Controllers
{
    public class AdminServiceController : Controller
    {
        KidKinderContext context=new KidKinderContext();
        public ActionResult Index()
        {
            var values = context.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateService()
        {
            List<SelectListItem> values = (from x in context.Services.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Title,
                                               Value = x.ServiceId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public ActionResult CreateService(Service service)
        {
            context.Services.Add(service);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteService(int id)
        {
            var value = context.Services.Find(id);
            context.Services.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            List<SelectListItem> values = (from x in context.Services.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Title,
                                               Value = x.ServiceId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = context.Services.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateService(Service service)
        {
            var value = context.Services.Find(service.ServiceId);
            value.IconUrl = service.IconUrl;
            value.Title = service.Title;
            value.ServiceId = service.ServiceId;
            value.Description = service.Description;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}