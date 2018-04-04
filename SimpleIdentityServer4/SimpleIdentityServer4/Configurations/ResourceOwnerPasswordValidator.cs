using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using IdentityServer4.Models;
using IdentityServer4.Validation;
using SimpleIdentityServer4.Models;

namespace SimpleIdentityServer4.Configurations
{
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        public Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            //throw new NotImplementedException();
            using (IDbConnection db=new SqlConnection(@"Server=ZAYN-PC;Database=IdentityServerDB;UID=sa;PWD=shobuz03"))
            {
                var user = db.Query<Users>("select * from Accounts where UserName=@UserName and Password=@Password",
                    new {UserName = context.UserName, Password = context.Password}).SingleOrDefault();
                if (user==null)
                {
                    context.Result=new GrantValidationResult(TokenRequestErrors.InvalidRequest,"username or password is incorrect.");
                }
                context.Result=new GrantValidationResult(user.Id.ToString(),"password");
                return Task.FromResult(0);
            }
        }
    }
}
