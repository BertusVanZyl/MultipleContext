using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TwoContexts.Localization
{
    public static class TwoContextsLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TwoContextsConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TwoContextsLocalizationConfigurer).GetAssembly(),
                        "TwoContexts.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
