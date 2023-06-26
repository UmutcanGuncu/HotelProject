using System;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Default
{
	public class _Navbar:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

