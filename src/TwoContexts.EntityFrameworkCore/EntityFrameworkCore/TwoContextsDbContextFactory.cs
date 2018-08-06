using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TwoContexts.Configuration;
using TwoContexts.Web;

namespace TwoContexts.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TwoContextsDbContextFactory : IDesignTimeDbContextFactory<TwoContextsDbContext>
    {
        public TwoContextsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TwoContextsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TwoContextsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TwoContextsConsts.ConnectionStringName));

            return new TwoContextsDbContext(builder.Options);
        }
    }
}
