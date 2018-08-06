using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TwoContexts.Configuration;

namespace TwoContexts.Web.Host.Startup
{
    [DependsOn(
       typeof(TwoContextsWebCoreModule))]
    public class TwoContextsWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TwoContextsWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TwoContextsWebHostModule).GetAssembly());
        }
    }
}
