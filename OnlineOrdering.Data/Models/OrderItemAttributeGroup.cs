namespace OnlineOrdering.Data.Models
{
	public class OrderItemAttributeGroup : BaseEntity
	{
		public string Name { get; set; } // Default empty string
		public string Description { get; set; } // Default empty string
		public OrderItem OrderItem { get; set; } // Not NULL
	}
}