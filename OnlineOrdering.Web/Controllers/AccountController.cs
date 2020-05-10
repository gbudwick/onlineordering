using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using OnlineOrdering.Data.Models;
using OnlineOrdering.Models.ViewModels;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace OnlineOrdering.Web.Controllers
{
	[Route("account")]
    public class AccountController : Controller
    {
	    private readonly UserManager<OOUser> _userManager;
	    private readonly IConfiguration _config;
	    public ILogger<AccountController> Logger { get; }
	    public SignInManager<OOUser> _signInManager { get; }

	    public AccountController(ILogger<AccountController> logger,
		    SignInManager<OOUser> signManager, UserManager<OOUser> userManager,
		    IConfiguration config)
	    {
		    _userManager = userManager;
		    _config = config;
		    Logger = logger;
		    _signInManager = signManager;
	    }

	    public async Task<IActionResult> Login(LoginViewModel model)
	    {
		    var result = _signInManager.PasswordSignInAsync(model.UserName, model.Password,
			    model.RememberMe, false);

		    return null;
	    }

	    [HttpPost]
		[Route("createtoken")]
	    public async Task<IActionResult> CreateToken([FromBody] LoginViewModel model)
	    {
		    var user = await _userManager.FindByNameAsync(model.UserName);

		    if( user != null )
		    {
			    var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);

			    if( result.Succeeded )
			    {
				    var claims = new[]
				    {
					    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
						new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
						new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName) 
				    };

				    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));

				    var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

				    var token = new JwtSecurityToken(
					    _config["Tokens:Issuer"],
					    _config["Tokens:Audience"],
					    claims,
					    expires: DateTime.UtcNow.AddMinutes(30),
					    signingCredentials: credentials);

				    var results = new
				    {
					    token = new JwtSecurityTokenHandler().WriteToken(token),
					    expiration = token.ValidTo
				    };

				    return Created(string.Empty, results);

			    }
		    }

		    return BadRequest();
	    }
    }
}
