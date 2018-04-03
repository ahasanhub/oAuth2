using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace SimpleIdentityServer4.Configurations
{
    public class Scopes
    {
        public static List<Scope> GetScopes()
        {
            return new List<Scope>
            {
                new Scope{Name = "MyAPI",Description = "My sample api"}
            };
        }
    }
}
