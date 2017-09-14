using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Feature2.Models;

namespace Feature2.Controllers
{
	public class BlogController : Controller
	{
		public ActionResult Index()
		{
			BlogContext blogContext = new BlogContext();
			List<Blog> blogs = blogContext.Blogs.ToList();

			return View(blogs);
		}
		public ActionResult Admin()
		{
			BlogContext blogContext = new BlogContext();
			List<Blog> blogs = blogContext.Blogs.ToList();

			return View(blogs);
		}
		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Create(Blog blog)
		{
			if (ModelState.IsValid)
			{
				BlogContext blogContext = new BlogContext();
				blogContext.Blogs.Add(blog);
				blogContext.SaveChanges();
				return RedirectToAction("Admin");
			}
			return View(blog);
		}
		[HttpGet]
		public ActionResult Edit(int Id)
		{
			BlogContext blogContext = new BlogContext();
			Blog blog = blogContext.Blogs.Single(log => log.Id == Id);

			return View(blog);
		}
		[HttpPost]
		public ActionResult Edit(Blog blog)
		{
			BlogContext blogContext = new BlogContext();
			blogContext.Entry(blog).State = System.Data.Entity.EntityState.Modified;
			blogContext.SaveChanges();
			return RedirectToAction("Admin");
		}
		[HttpGet]
		public ActionResult Delete(int Id)
		{
			BlogContext blogContext = new BlogContext();
			Blog blog = blogContext.Blogs.Single(log => log.Id == Id);

			return View(blog);
		}
		[HttpPost, ActionName("Delete")]
		public ActionResult DeleteConfirmed(int Id)
		{
			BlogContext blogContext = new BlogContext();
			Blog blog = blogContext.Blogs.Single(log => log.Id == Id);

			blogContext.Blogs.Remove(blog);
			blogContext.SaveChanges();

			return RedirectToAction("Admin");
		}
		public ActionResult Details(int Id)
		{
			BlogContext blogContext = new BlogContext();
			Blog blog = blogContext.Blogs.Single(log => log.Id == Id);

			return View(blog);
		}
	}
}