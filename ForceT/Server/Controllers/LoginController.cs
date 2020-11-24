using ForceT.Shared;
using ForceT.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ForceT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public LoginController(IConfiguration configuration,
                               SignInManager<ApplicationUser> signInManager)
        {
            _configuration = configuration;
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel login)
        {
            var result = await _signInManager.PasswordSignInAsync(login.Name, login.Password, false, false);

            if (!result.Succeeded) return BadRequest(new LoginResult { Successful = false, Error = "Nom d'utilisateur ou mot de passe incorrect." });

            //var user = await _signInManager.UserManager.FindByEmailAsync(login.Email);
            var user = await _signInManager.UserManager.FindByNameAsync(login.Name);
            var roles = await _signInManager.UserManager.GetRolesAsync(user);
            if (roles.Count == 0 && login.Name == "administrateur")
            {
                await _signInManager.UserManager.AddToRoleAsync(user, "Admin");
                roles = await _signInManager.UserManager.GetRolesAsync(user);
            }

            var claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Name, login.Name));

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtAudience"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );

            return Ok(new LoginResult { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token) });
        }
    }
}
