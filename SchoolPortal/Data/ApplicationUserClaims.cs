using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SchoolPortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SchoolPortal.Data
{
    public class ApplicationUserClaims : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
    {
        public ApplicationUserClaims(
            UserManager<ApplicationUser> userManager, 
            RoleManager<IdentityRole> roleManager, 
            IOptions<IdentityOptions> options
        ) : base(userManager, roleManager, options)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            var roles = await UserManager.GetRolesAsync(user);
            
            identity.AddClaim(new Claim("DisplayName", user.DisplayName));
            identity.AddClaim(new Claim(ClaimTypes.Role, roles.FirstOrDefault()));

            return identity;
        }
    }
}
