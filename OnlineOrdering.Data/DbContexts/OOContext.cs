using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineOrdering.Data.Models;

namespace OnlineOrdering.Data.DbContexts
{
    public class OOContext : DbContext
    {
	    public OOContext(DbContextOptions<OOContext> options) : base(options)
	    {
		    
	    }
        public DbSet<Person> People { get; set; }
    }
}
