using Microsoft.AspNetCore.Identity;
using System;

namespace RepeaterQTH.Data
{
    public class ApplicationUser: IdentityUser
    {
        public string Callsign { get; set; }

        public DateTime LastAccess {get; set; }  
    }
}