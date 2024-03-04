using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class FamilyController : Controller
    {
        KidKinderContext context=new KidKinderContext();
        public ActionResult FamilyList()
        {
            var values=context.Families.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateFamily()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFamily(Family family)
        {
            context.Families.Add(family);
            context.SaveChanges();
            return RedirectToAction("FamilyList");
        }

        public ActionResult DeleteFamily(int id)
        {
            var value = context.Families.Find(id);
            context.Families.Remove(value);
            context.SaveChanges();
            return RedirectToAction("FamilyList");
        }
        [HttpGet]
        public ActionResult UpdateFamily(int id)
        {

            return View();


        }
        [HttpPost]
        public ActionResult UpdateStudent(Family family)
        {
            var value = context.Families.Find(family.FamilyId);

            value.NameSurname = family.NameSurname;
            value.FamilyId = family.FamilyId;
            value.StudentName = family.StudentName;
            context.SaveChanges();
            return RedirectToAction("FamilyList");
        }
    }
}