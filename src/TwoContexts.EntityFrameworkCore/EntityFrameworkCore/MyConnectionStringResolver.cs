using System;
using Abp.Configuration.Startup;
using Abp.Domain.Uow;
using Microsoft.Extensions.Configuration;
using TwoContexts.EntityFrameworkCore.SecondContext.Models;

namespace MultipleDbContextEfCoreDemo.EntityFrameworkCore
{
    public class MyConnectionStringResolver : DefaultConnectionStringResolver
    {
        public MyConnectionStringResolver(IAbpStartupConfiguration configuration) 
            : base(configuration)
        {
        }

        public override string GetNameOrConnectionString(ConnectionStringResolveArgs args)
        {
            if (args["DbContextConcreteType"] as Type == typeof(TEST1Context))
            {
                return "Server=localhost; Database=TEST1; Trusted_Connection=True;";
            }

            return base.GetNameOrConnectionString(args);
        }
    }
}