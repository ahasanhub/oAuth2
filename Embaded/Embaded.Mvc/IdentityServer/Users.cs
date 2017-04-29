using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using IdentityServer3.Core;
using IdentityServer3.Core.Services.InMemory;

namespace Embaded.Mvc.IdentityServer
{
    public static class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>
            {
                new InMemoryUser
                {
                    Username = "ahasan",
                    Password = "123456",
                    Subject = "1",
                    Claims = new []
                    {
                        new Claim(Constants.ClaimTypes.GivenName,"Ahasan"),
                        new Claim(Constants.ClaimTypes.FamilyName,"Habib")
                    }

                }
            };
        }
    }
}