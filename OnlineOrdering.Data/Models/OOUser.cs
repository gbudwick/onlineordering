using Microsoft.AspNetCore.Identity;

namespace OnlineOrdering.Data.Models
{
    public class OOUser : IdentityUser
    {
	    public string CompanyName { get; set; } // Default empty string
	    public string FirstName { get; set; } // Default empty string
	    public string LastName { get; set; } // Default empty string
    }
}