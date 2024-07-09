using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogs.Identity
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}