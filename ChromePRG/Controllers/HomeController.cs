using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChromePRG.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult NewSomething()
		{
			return View();
		}

		[HttpPost]
		public ActionResult NewSomething(string someData)
		{
			return RedirectToAction("index");
		}
	}
}
