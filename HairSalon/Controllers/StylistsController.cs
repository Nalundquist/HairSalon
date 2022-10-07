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
			List<Client> model = _db.Clients.Where(client => client.StylistId == id).Include(client => client.Stylist).ToList();
      ViewBag.StylistName = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id).Name;
      ViewBag.StylistId = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id).StylistId;
			return View(model);
		}
	}
}