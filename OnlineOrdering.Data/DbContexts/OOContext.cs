using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineOrdering.Data.Models;

namespace OnlineOrdering.Data.DbContexts
{
    public class OOContext : IdentityDbContext<OOUser>
    {
	    public OOContext(DbContextOptions<OOContext> options) : base(options)
	    { }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
	        base.OnModelCreating(builder);

	        //OOUser user = _userManager;
        }
    }
}
