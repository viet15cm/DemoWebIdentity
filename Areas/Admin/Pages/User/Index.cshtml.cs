using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Paging.Models;

namespace Paging.Areas.Admin.Pages.User
{
    [Authorize(Roles = "admin")]
    public class IndexModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;

        public IndexModel (UserManager<AppUser> userManager)
        {
            _userManager = userManager; 
        }
        [TempData]
        public string StatusMessage { get; set; }

        public class AppUserRole : AppUser
        {
            public string RoleName { get; set; }
        }

        public List<AppUserRole> users;
        public async Task OnGet()
        {
            var qr =  _userManager.Users.OrderBy(u => u.UserName);

            var qr1 = qr.Select(u => new AppUserRole
            {
                Id = u.Id,
                UserName = u.UserName,

            });

            users = await qr1.ToListAsync();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
              
                user.RoleName = string.Join(", ", roles);
            }
        }

        public void OnePostAsync()
        {

        }
    }
}
