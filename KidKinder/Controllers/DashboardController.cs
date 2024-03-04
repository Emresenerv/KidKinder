using KidKinder.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class DashboardController : Controller
    {
        KidKinderContext context = new KidKinderContext();
        [Authorize]
        public ActionResult Index()
        {
            
            ViewBag.RobotikKodlamaCount = context.Teachers.Where(x => x.BranchId == context.Branches.Where(z => z.Name == "Yazılım Mühendisi/Eğitmen").Select(y => y.BranchId).FirstOrDefault()).Count(); ViewBag.AvgPrice = context.ClassRooms.Average(x => x.Price).ToString("0.00");
            ViewBag.Testimonial = context.Testimonials.Count();
            ViewBag.Service = context.Services.Count();
            ViewBag.subs = context.MailSubscribes.Count();
            ViewBag.Teacher = context.Teachers.Count();
            ViewBag.BookASeat = context.BookASeats.Count();
            ViewBag.ClassRoom = context.ClassRooms.Count();
            ViewBag.Branch = context.Branches.Count();
            ViewBag.Contact = context.Contacts.Count();
            var values = context.Teachers.ToList();
            return View(values);
        }
      
        public PartialViewResult PartialSocial()
        {
            var values=context.Services.ToList();
            return PartialView(values);
        }
        
    }
}