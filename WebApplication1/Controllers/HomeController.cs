using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		public static int CurrentCount = 0;

		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		/// <summary>
		/// GET: Trang chủ
		/// Bộ đếm sử dụng Blazor
		/// </summary>
		/// <returns></returns>
		public IActionResult Index()
		{
			return View();
		}

		/// <summary>
		/// GET: Trang bộ đếm sử dụng JS
		/// </summary>
		/// <returns></returns>
		public IActionResult Counter()
		{
			return View();
		}

		/// <summary>
		/// GET: Trang tính tiền điện sử dụng Blazor
		/// </summary>
		/// <returns></returns>
		public IActionResult Calculator()
		{
			return View();
		}

		/// <summary>
		/// GET: Tạo API tăng biến đếm với URL tùy chỉnh
		/// </summary>
		/// <returns></returns>
		[HttpGet("api/Increment")]
		public int Increment()
		{
			return ++CurrentCount;
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public IActionResult Blazor()
		{
			return View("_Host");
		}
	}
}
