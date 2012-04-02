using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChromePRG.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Grid()
		{
			return View();
		}

		public ActionResult RedirectWith302()
		{
			return View("NewSomething");
		}

		[HttpPost]
		public ActionResult RedirectWith302(string someData)
		{
			return RedirectToAction("Grid");
		}


		public ActionResult RedirectWith303()
		{
			return View("NewSomething");
		}

		[HttpPost]
		public ActionResult RedirectWith303(string someData)
		{
			return new SeeOtherRedirectResult(this.HttpContext.Request.RequestContext, "Grid", "Home");
		}
	}
}
