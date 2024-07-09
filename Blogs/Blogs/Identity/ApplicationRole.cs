using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogs.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public string Descripton { get; set; }
        public ApplicationRole()
        {

        }
        public ApplicationRole(string rolename,string description)
        {
            this.Descripton = description;
        }
    }
}