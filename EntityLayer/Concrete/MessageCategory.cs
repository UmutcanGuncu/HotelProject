using System;
namespace EntityLayer.Concrete
{
	public class MessageCategory
	{
		public Guid MessageCategoryId { get; set; }
		public string? CategoryName { get; set; }
		public List<Contact>? Contacts { get; set; }
    }
}

