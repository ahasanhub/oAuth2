using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityServer3.Core.Services.InMemory;

namespace Simplest.OAuth.IdSrv
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
                    Subject = "1"
                },
                new InMemoryUser
                {
                    Username = "zayn",
                    Password = "12345678",
                    Subject = "2"
                }
            };
        }
    }
}
