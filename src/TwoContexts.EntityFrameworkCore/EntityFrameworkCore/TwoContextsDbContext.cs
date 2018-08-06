using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TwoContexts.Authorization.Roles;
using TwoContexts.Authorization.Users;
using TwoContexts.MultiTenancy;

namespace TwoContexts.EntityFrameworkCore
{
    public class TwoContextsDbContext : AbpZeroDbContext<Tenant, Role, User, TwoContextsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TwoContextsDbContext(DbContextOptions<TwoContextsDbContext> options)
            : base(options)
        {
        }
    }
}
