using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TwoContexts.Configuration;
using TwoContexts.EntityFrameworkCore.SecondContext.Models;
using TwoContexts.Web;

namespace TwoContexts.EntityFrameworkCore.SecondContext
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SecondDbContextFactory : IDesignTimeDbContextFactory<TEST1Context>
    {
        public TEST1Context CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TEST1Context>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SecondDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TwoContextsConsts.ConnectionStringName));

            return new TEST1Context(builder.Options);
        }
    }
}
