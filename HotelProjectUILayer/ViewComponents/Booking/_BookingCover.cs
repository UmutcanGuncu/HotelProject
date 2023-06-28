using System;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Booking
{
	public class _BookingCover:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
		
	}
}

