using System;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Default
{
	public class _Head:ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

