using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Proxima.Shared;
using Microsoft.EntityFrameworkCore;
using Proxima.Shared.Models;
using System.Reflection;

namespace Proxima.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly RoleManager<ApplicationRole> _RoleManager;
        public RolesController(RoleManager<ApplicationRole> RoleMnanger)
        {
            _RoleManager = RoleMnanger;
        }

        public async Task<ActionResult<IEnumerable<string>>> GetRoles()
        {
            //PropertyInfo[] propertyInfos = typeof(RoleModel).GetProperties(BindingFlags.Public);
            //List<string> propList = new List<string>();
            //foreach (var propertyinfo in propertyInfos)
            //{
            //    propList.Add(propertyinfo.Name);
            //}
            return await _RoleManager.Roles.Select(x=>x.Name).ToListAsync();

        }
    }
}