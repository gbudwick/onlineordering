using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineOrdering.Data.DbContexts;

namespace OnlineOrdering.Tests
{
    public static class TestingSetup
    {
		public static OOContext GetContext()
		{
			DbContextOptions<OOContext> options;
			var builder = new DbContextOptionsBuilder<OOContext>();
			builder.UseInMemoryDatabase("OnlineOrdering");
			options = builder.Options;
			var dataContext = new OOContext(options);
			dataContext.Database.EnsureDeleted();
			dataContext.Database.EnsureCreated();
			return dataContext;
		}
	}
}
