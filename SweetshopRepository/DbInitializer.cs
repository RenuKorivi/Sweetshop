using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetshopRepository
{
      public class DbInitializer : IDbInitializer
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SweetShopContext _Context;

        public DbInitializer(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, SweetShopContext context)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _Context = context;
        }

       



        /*public void Initialize()
        { 
            try
            {
                if (_Context.Database.GetPendingMigrations().count()>0)
                {
                    _Context.Database.Migrate();
                }
            }
            catch(Exception)
            {
                throw;

            }
            if (_Context.Roles.Any(X =>X.Name == "Manager")) return;
            {

            }
        }*/

    }
}
