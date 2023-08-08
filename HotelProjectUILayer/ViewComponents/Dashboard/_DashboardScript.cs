using System;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Dashboard
{
	public class _DashboardScript:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}	
	}
}

