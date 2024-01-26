using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace ISMLogin.Models
{
    public class Membership
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}