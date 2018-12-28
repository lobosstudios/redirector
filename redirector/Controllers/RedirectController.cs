using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace redirector.Controllers
{
	public class RedirectController : Controller
	{
		public IActionResult Redirect()
		{
			string RedirectTo = "https://" + Request.Host.Value + Request.Path;
			if (Request.QueryString.Value.Length > 0) RedirectTo += Request.QueryString;
			return Redirect(RedirectTo);
		}
	}
}
