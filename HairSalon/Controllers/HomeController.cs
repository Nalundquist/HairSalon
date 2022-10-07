using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
	public class HomeController : Controllers
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}