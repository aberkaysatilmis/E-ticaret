using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UrunKMVCWebUI.Entity;

namespace UrunKMVCWebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {

        protected override void Seed(IdentityDataContext context)
        {
            //Rolleri

            if(!context.Roles.Any(i=> i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole()
                {
                    Name = "admin",
                    Description = "admin rolü"
                };

                manager.Create(role);
            }


            if(!context.Roles.Any(i=> i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole()
                {
                    Name = "user",
                    Description = "User rolü"
                };
                manager.Create(role);
            }




            //User

            if (!context.Roles.Any(i=> i.Name == "berkaysatilmis"))
            {
                var store = new UserStore <ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    Name = "berkay",
                    SurName = "satılmış",
                    UserName = "berkaysatilmis",
                    Email = "berkaysatilmis@gmail.com"
                };
                manager.Create(user,"123456");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }


            if (!context.Roles.Any(i => i.Name == "osmangultekin"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    Name = "osman",
                    SurName = "gültekin",
                    UserName = "osmangultekin",
                    Email = "osmangultekin@gmail.com"
                };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "user");
                base.Seed(context);
            }
        }
    }
}