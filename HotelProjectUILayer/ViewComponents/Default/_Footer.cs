using System;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Default
{
	public class _Footer:ViewComponent
	{
		public  IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

