using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Feature3.Models;

namespace Feature3.Controllers
{
    public class CalendarController : Controller
    {
        public ActionResult Index()
        {
			CalendarContext calendarContext = new CalendarContext();
			List<Calendar> calendars = calendarContext.Calendars.ToList();
			return View(calendars);
		}
		public ActionResult Admin()
		{
			CalendarContext calendarContext = new CalendarContext();
			List<Calendar> calendars = calendarContext.Calendars.ToList();
			return View(calendars);
		}
		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Create(Calendar calendar)
		{
			if (ModelState.IsValid)
			{
				CalendarContext calendarContext = new CalendarContext();
				calendarContext.Calendars.Add(calendar);
				calendarContext.SaveChanges();
				return RedirectToAction("Admin");
			}
			return View(calendar);
		}
		[HttpGet]
		public ActionResult Edit(int Id)
		{
			CalendarContext calendarContext = new CalendarContext();
			Calendar calendar = calendarContext.Calendars.Single(log => log.Id == Id);

			return View(calendar);
		}
		[HttpPost]
		public ActionResult Edit(Calendar calendar)
		{
			CalendarContext calendarContext = new CalendarContext();
			calendarContext.Entry(calendar).State = System.Data.Entity.EntityState.Modified;
			calendarContext.SaveChanges();
			return RedirectToAction("Admin");
		}
		[HttpGet]
		public ActionResult Delete(int Id)
		{
			CalendarContext calendarContext = new CalendarContext();
			Calendar calendar = calendarContext.Calendars.Single(log => log.Id == Id);

			return View(calendar);
		}
		[HttpPost, ActionName("Delete")]
		public ActionResult DeleteConfirmed(int Id)
		{
			CalendarContext calendarContext = new CalendarContext();
			Calendar calendar = calendarContext.Calendars.Single(log => log.Id == Id);

			calendarContext.Calendars.Remove(calendar);
			calendarContext.SaveChanges();

			return RedirectToAction("Admin");
		}
		public ActionResult Details(int Id)
		{
			CalendarContext calendarContext = new CalendarContext();
			Calendar calendar = calendarContext.Calendars.Single(log => log.Id == Id);

			return View(calendar);
		}
		public ActionResult Information(int Id)
		{
			CalendarContext calendarContext = new CalendarContext();
			Calendar calendar = calendarContext.Calendars.Single(log => log.Id == Id);

			return View(calendar);
		}
	}
}