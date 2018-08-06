using Abp.Configuration.Startup;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using MultipleDbContextEfCoreDemo.EntityFrameworkCore;
using TwoContexts.EntityFrameworkCore.SecondContext;
using TwoContexts.EntityFrameworkCore.SecondContext.Models;
using TwoContexts.EntityFrameworkCore.Seed;

namespace TwoContexts.EntityFrameworkCore
{
    [DependsOn(
        typeof(TwoContextsCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class TwoContextsEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            Configuration.ReplaceService<IConnectionStringResolver, MyConnectionStringResolver>();


            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<TwoContextsDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        TwoContextsDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        TwoContextsDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }

            // Configure second DbContext
            Configuration.Modules.AbpEfCore().AddDbContext<TEST1Context>(options =>
            {
                if (options.ExistingConnection != null)
                {
                    SecondDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                }
                else
                {
                    SecondDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                }
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TwoContextsEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
