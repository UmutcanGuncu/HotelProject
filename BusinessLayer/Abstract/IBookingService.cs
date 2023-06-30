using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IBookingService:IGenericService<Booking>
	{
		public void Approved(Guid id);
		public void Cancelled(Guid id);
		public void Waiting(Guid id);
	}
}

