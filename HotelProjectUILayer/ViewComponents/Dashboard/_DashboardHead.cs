using System;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Dashboard
{
	public class _DashboardHead:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			return View();
		}
	}
}

