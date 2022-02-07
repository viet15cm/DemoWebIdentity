using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Paging.DbContextLayer;

namespace Paging.Areas.Admin.Pages.Role
{
    public class IndexModel : RolePageModel
    {
        public IndexModel(RoleManager<IdentityRole> roleManager, UserDbContext userDbContext) : base(roleManager, userDbContext)
        {
        }
        public class RoleClaimModel : IdentityRole
        {
            public string[] Claims { get; set; }
        }

        //public List<IdentityRoleClaim<string>> RoleClaims { get; set; }
        public ICollection<RoleClaimModel> roles{ get; set; }
        public async Task OnGet()           
        {
         
            var roles = await _roleManager.Roles.ToListAsync();
            var roles1 = new List<RoleClaimModel>();

            foreach (var _r in roles)
            {
                var claims = await _roleManager.GetClaimsAsync(_r);
                var claimString = claims.Select(c => c.Value + "=" + c.Type);
                var r = new RoleClaimModel()
                {
                    Name = _r.Name,
                    Id = _r.Id,
                    Claims = claimString.ToArray()

                };
            }
        }
        public void  OnPost()
        {
             RedirectToPage();
        }
    }
}
