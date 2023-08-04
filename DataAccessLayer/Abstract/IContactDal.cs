﻿using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IContactDal:IGenericDal<Contact>
	{
		public int ContactCount();
	}
}

