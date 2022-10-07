using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
	public class ClientsController : Controller
	{
		private readonly HairSalonContext _db;
		public ClientsController(HairSalonContext db)
		{
			_db = db;
		}

		public ActionResult Create()
		{
			ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
			return View();
		}

		[HttpPost]
		public ActionResult Create(Client client)
		{
			_db.Clients.Add(client);
			_db.SaveChanges();
			ViewBag.ConfirmMessage = "Your changes have been saved";
			return RedirectToAction("Index", "Home");
		}

		public ActionResult Details(int id)
		{
			Client client = _db.Clients.Include(client => client.Stylist).FirstOrDefault(client => client.ClientId == id);
			return View(client);
		}
	}
}
