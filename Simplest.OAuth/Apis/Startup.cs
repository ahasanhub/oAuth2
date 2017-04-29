using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using IdentityServer3.AccessTokenValidation;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Apis.Startup))]

namespace Apis
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // accept access tokens from identityserver and require a scope of 'api1'
            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = "http://localhost:5000",
                ValidationMode = ValidationMode.ValidationEndpoint,
                RequiredScopes = new[]
                {
                    "api1"
                }
            });
            //Configure web api
            var config=new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            //require authentication for all controller
            config.Filters.Add(new AuthorizeAttribute());

            app.UseWebApi(config);
        }
    }
}
