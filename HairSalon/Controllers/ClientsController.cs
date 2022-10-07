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

		public ActionResult Create()
		{
			ViewBag.Stylist = new SelectList(_db.Stylists, "StylistId", "Name");
			return View();
		}

		[HttpPost]
		public ActionResult Create(Client client)
		{
			_db.Clients.Add(client);
			_db.SaveChanges();
			ViewBag.ConfirmMessage = "Your changes have been saved";
			return RedirectToAction("Index");
		}

		public ActionResult Details(int id)
		{
			Client client = _db.Clients.FirstOrDefault(client => client.ClientId == id);
			return View(client);
		}
	}
}
