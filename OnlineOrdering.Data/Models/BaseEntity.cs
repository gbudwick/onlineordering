using System;

namespace OnlineOrdering.Data.Models
{
	public abstract class BaseEntity
	{
		public int Id { get; set; } // Auto-increment indentity
		public string ExternalId { get; set; } // Not mapped to db column
		public DateTime Created { get; set; } // Default UTC now
		public DateTime Updated { get; set; } // Default UTC now
		public bool Deleted { get; set; } // Default false
		public OOUser CreatedBy { get; set; } // Not NULL
		public OOUser UpdatedBy { get; set; } // Not NULL
	}
}