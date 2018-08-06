using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TwoContexts.EntityFrameworkCore
{
    public static class TwoContextsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TwoContextsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TwoContextsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
