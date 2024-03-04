using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Entities;

namespace KidKinder.Controllers
{
    public class LessonController : Controller
    {
  KidKinderContext context = new KidKinderContext();
        public ActionResult Index()
        {
            var values =context.Lessons.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateLesson()
        {
            List<SelectListItem> values = (from x in context.Lessons.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.LessonName,
                                               Value = x.LessonId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
            [HttpPost]

            public ActionResult CreateLesson(Lesson lesson)
            {
                context.Lessons.Add(lesson);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            public ActionResult DeleteLesson(int id)
            {
                var value = context.Lessons.Find(id);
                context.Lessons.Remove(value);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            [HttpGet]
            public ActionResult UpdateLesson(int id)
            {
                List<SelectListItem> values = (from x in context.Lessons.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.LessonName,
                                                   Value = x.LessonId.ToString()
                                               }).ToList();
                ViewBag.v = values;
                var value = context.Lessons.Find(id);
                return View(value);
            }
            [HttpPost]
            public ActionResult UpdateLesson(Lesson lesson)
            {
                var value = context.Lessons.Find(lesson.LessonId);
                value.LessonDate = lesson.LessonDate;
                value.LessonDateTime = lesson.LessonDateTime;
                value.LessonName = lesson.LessonName;
                value.LessonId = lesson.LessonId;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }