using Microsoft.AspNetCore.Mvc;

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
	}
}
