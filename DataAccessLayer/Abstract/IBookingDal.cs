using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IBookingDal:IGenericDal<Booking>
	{
		public void Aprovved(Guid id);
		public void Cancelled(Guid id);
		public void Waiting(Guid id);
	}
}

