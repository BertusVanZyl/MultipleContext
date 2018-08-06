using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using TwoContexts.EntityFrameworkCore.SecondContext.Models;

namespace TwoContexts.EntityFrameworkCore.SecondContext
{
    public static class SecondDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TEST1Context> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TEST1Context> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
