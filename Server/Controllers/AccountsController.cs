using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proxima.Shared;
using Proxima.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Proxima.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountsController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RegisterModel model)
        {
            var newUser = new ApplicationUser { UserName = model.UserName/*, Email = model.Email*/ };

            var result = await _userManager.CreateAsync(newUser, model.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description);
                return BadRequest(new RegisterResult { Successful = false, Errors = errors });
            }
            //RoleModel roleModel = new RoleModel();
            IEnumerable<string> roles =  model.Roles.GetType().GetProperties().Where(p => (bool)p.GetValue(model.Roles, null)).Select(p => p.Name);
            var resultrole = await _userManager.AddToRolesAsync(newUser, roles);
            if (!resultrole.Succeeded)
            {
                var errors = resultrole.Errors.Select(x => x.Description);
                return BadRequest(new RegisterResult { Successful = false, Errors = errors });
            }

            return Ok(new RegisterResult { Successful = true });
            //return Ok(roles);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> Getuser()
        {
            //return await _userManager.Users.Select(x => new UserModel
            //{
            //    User = x.UserName,
            //}).ToListAsync();
            return await _userManager.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).Select(x => new ApplicationUser
            {
                UserName = x.UserName,
                UserRoles = x.UserRoles,
            }).ToListAsync();
            
        }
    }
}