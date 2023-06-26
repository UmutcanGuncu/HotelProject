using System;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Default
{
	public class _Script:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
		
	}
}

