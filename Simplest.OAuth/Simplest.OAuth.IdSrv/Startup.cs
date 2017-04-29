using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityServer3.Core.Configuration;
using IdentityServer3.Core.Services.InMemory;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Simplest.OAuth.IdSrv.Startup))]

namespace Simplest.OAuth.IdSrv
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var oprions=new IdentityServerOptions
            {
                Factory = new IdentityServerServiceFactory()
                         
                         .UseInMemoryClients(Clients.Get())
                         .UseInMemoryScopes(Scopes.Get())
                         .UseInMemoryUsers(Users.Get()),
                RequireSsl = false
            };
            app.UseIdentityServer(oprions);
        }
    }
}
