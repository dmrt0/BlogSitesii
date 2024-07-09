using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace Blogs.Identity
{
    public class IdentityInitializer:CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            if (!context.Roles.Any(i=>i.Name=="admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Descripton = "admin rolü" };
                manager.Create(role);
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Descripton = "user rolü" };
                manager.Create(role);
            }
            if (!context.Users.Any(i=>i.Name=="talhademir"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() 
                { Name = "talha", Surname = "demir", UserName = "talhademir", Email = "talhademir@gmail.com" };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }
            if (!context.Users.Any(i => i.Name == "onurafsin"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                { Name = "onur", Surname = "afsin", UserName = "onurafsin", Email = "onurafsin@gmail.com" };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "user");
            }
            base.Seed(context); 
        }
    }
}