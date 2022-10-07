using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
	public class StylistsController: Controller
	{
		private readonly HairSalonContext _db;

		public StylistsController(HairSalonContext db)
		{
			_db = db;
		}

		public ActionResult Index()
		{
			List<Stylist> model = _db.Stylists.ToList();
			return View(model);
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(Stylist stylist) 
		{
			_db.Stylists.Add(stylist);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult Details(int id)
		{
			Stylist stylist = _db.Stylists.Include(stylist => stylist.Clients).FirstOrDefault(stylist => stylist.StylistId == id);
			return View(stylist);
		}

		public ActionResult Search()
		{
			return View();
		}

		public ActionResult NameResults(string name)
		{
			List<Stylist> model = _db.Stylists.Where(stylist => stylist.Name.Contains(name)).ToList();
			return RedirectToAction("Results", model);
		}

		public ActionResult Results(List<Stylist> model)
		{
			return View(model);
		}
	}
}