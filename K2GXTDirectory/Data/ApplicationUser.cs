using Microsoft.AspNetCore.Identity;
using System;

namespace K2GXT_Directory_2.Data
{
    public class ApplicationUser: IdentityUser
    {
        public string Callsign { get; set; }

        public DateTime LastAccess {get; set; }  
    }
}