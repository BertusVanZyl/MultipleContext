using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TwoContexts.Authorization;

namespace TwoContexts
{
    [DependsOn(
        typeof(TwoContextsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TwoContextsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TwoContextsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TwoContextsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
