using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.Mvc;
using System.Web.Routing;

namespace ChromePRG
{
	/// <summary>
	/// use this to redirect with 303 result
	/// return this when redirecting after a post request
	/// </summary>
	public class SeeOtherRedirectResult : ActionResult
	{
		public string Url { get; set; }

		public SeeOtherRedirectResult(string url)
		{
			this.Url = url;
		}

		public SeeOtherRedirectResult(RequestContext context, string actionName, string controllerName)
		{
			UrlHelper urlHelper = new UrlHelper(context);
			string url = urlHelper.Action(actionName, controllerName);

			this.Url = url;
		}

		public SeeOtherRedirectResult(RequestContext context, string actionName, string controllerName, object values)
		{
			UrlHelper urlHelper = new UrlHelper(context);
			string url = urlHelper.Action(actionName, controllerName, values);

			this.Url = url;
		}

		public SeeOtherRedirectResult(RequestContext context, string actionName, string controllerName, RouteValueDictionary values)
		{
			UrlHelper urlHelper = new UrlHelper(context);
			string url = urlHelper.Action(actionName, controllerName, values);

			this.Url = url;
		}

		public override void ExecuteResult(ControllerContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			context.HttpContext.Response.StatusCode = 303;
			context.HttpContext.Response.RedirectLocation = Url;
			context.HttpContext.Response.End();
		}
	}
   
}
