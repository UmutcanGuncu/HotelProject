using System;
namespace EntityLayer.Concrete
{
	public class Contact
	{
        
        public Guid ContactId { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime Date { get; set; }
        public Guid MessageCategoryId { get; set; }
        public MessageCategory? MessageCategory { get; set; }
        
    }
}

