using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Feature1.Models;

namespace Feature1.Controllers
{
	public class VolunteerController : Controller
	{
		public ActionResult Index()
		{
			VolunteerContext volunteerContext = new VolunteerContext();
			List<Volunteer> volunteers = volunteerContext.Volunteers.ToList();

			return View(volunteers);
		}
		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Create (Volunteer volunteer)
		{
			VolunteerContext volunteerContext = new VolunteerContext();
			volunteerContext.Volunteers.Add(volunteer);
			volunteerContext.SaveChanges();

			return RedirectToAction("Index");
		}
		[HttpGet]
		public ActionResult Edit(int Id)
		{
			VolunteerContext volunteerContext = new VolunteerContext();
			Volunteer volunteer = volunteerContext.Volunteers.Single(vol => vol.Id == Id);

			return View(volunteer);
		}
		[HttpPost]
		public ActionResult Edit(Volunteer volunteer)
		{
			VolunteerContext volunteerContext = new VolunteerContext();
			volunteerContext.Entry(volunteer).State = System.Data.Entity.EntityState.Modified;
			volunteerContext.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public ActionResult Delete(int Id)
		{
			VolunteerContext volunteerContext = new VolunteerContext();
			Volunteer volunteer = volunteerContext.Volunteers.Single(vol => vol.Id == Id);

			return View(volunteer);
		}
		[HttpPost, ActionName("Delete")]
		public ActionResult DeleteConfirmed(int Id)
		{
			VolunteerContext volunteerContext = new VolunteerContext();
			Volunteer volunteer = volunteerContext.Volunteers.Single(vol => vol.Id == Id);

			volunteerContext.Volunteers.Remove(volunteer);
			volunteerContext.SaveChanges();

			return RedirectToAction("Index");
		}
		public ActionResult Details(int Id)
		{
			VolunteerContext volunteerContext = new VolunteerContext();
			Volunteer volunteer = volunteerContext.Volunteers.Single(vol => vol.Id == Id);

			return View(volunteer);
		}
	}
}