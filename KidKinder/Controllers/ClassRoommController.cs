using KidKinder.Context;
using KidKinder.Entities;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KidKinder.Controllers
{
    public class ClassRoommController : Controller
    {
        KidKinderContext c = new KidKinderContext();
        public ActionResult Class()
        {
            var values = c.ClassRooms.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateClass(int id)
        {
            var values = c.ClassRooms.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateClass(ClassRoom x)
        {
            var value = c.ClassRooms.Find(x.ClassRoomId);
            value.Title = x.Title;
            value.Description = x.Description;
            value.AgeofKids = x.AgeofKids;
            value.TotalSeat = x.TotalSeat;
            value.ClassTime = x.ClassTime;
            value.Price = x.Price;
            value.ImageUrl = x.ImageUrl;
            c.SaveChanges();
            return RedirectToAction("Class");
        }
        [HttpGet]
        public ActionResult AddClassRoom()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddClassRoom(ClassRoom x)
        {
            c.ClassRooms.Add(x);
            c.SaveChanges();
            return RedirectToAction("Class");
        }

        public ActionResult DeleteClassRoom(int id)
        {
            c.ClassRooms.Remove(c.ClassRooms.Find(id));
            c.SaveChanges();
            return RedirectToAction("Class");


        }



    }
}