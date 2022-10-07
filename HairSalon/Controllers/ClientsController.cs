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

		public ActionResult Index()
		{
			List<Client> model = _db.Clients.ToList();
			return View(model);
		}

		public ActionResult Create(int id)
		{
			ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
			return View();
		}

		[HttpPost]
		public ActionResult Create(Client client)
		{
			_db.Clients.Add(client);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult Details(int id)
		{
			Client model = _db.Clients.Include(client => client.Stylist).FirstOrDefault(client => client.ClientId == id);
			return View(model);
		}
	}
}
