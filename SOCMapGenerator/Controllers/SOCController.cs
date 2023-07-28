using Microsoft.AspNetCore.Mvc;
using SOCMapGenerator.Models;

namespace SOCMapGenerator.Controllers
{
	public class SOCController : Controller
	{
		private readonly ILogger<SOCController> _logger;

		public SOCController(ILogger<SOCController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(SOCMapTemplateCreate model)
		{
			try
			{
				if (ModelState.IsValid)
				{
					return View("Index");
				}
			}
			catch (Exception ex)
			{
				throw;
			}
			return View("Index");
		}
	}
}
