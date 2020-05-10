using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using OnlineOrdering.Data.Models;

namespace OnlineOrdering.Data.DbContexts
{
    public class OnlineOrderingSeeder
    {
	    public UserManager<OOUser> _userManager { get; }
	    private readonly OOContext _ctx;
	    private readonly IHostingEnvironment _hosting;

	    public OnlineOrderingSeeder(OOContext _ctx, IHostingEnvironment hosting, UserManager<OOUser> userManager)
	    {
		    _userManager = userManager;
		    this._ctx = _ctx;
		    _hosting = hosting;
	    }

	    public async Task SeedAsync()
	    {
		    _ctx.Database.EnsureCreated();

		    var user = await _userManager.FindByEmailAsync("user@onlineordering.com");

		    if( user == null )
		    {
				user = new OOUser()
				{
					FirstName = "Andy",
					LastName = "Jones",
					Email = "user@onlineordering.com",
					UserName = "user@onlineordering.com"
				};

				var result = await _userManager.CreateAsync(user, "P@ssword123");
		    }

	    }
    }
}
