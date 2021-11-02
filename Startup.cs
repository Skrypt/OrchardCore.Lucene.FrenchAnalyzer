using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Lucene.Model;
using OrchardCore.Lucene.Services;
using OrchardCore.Modules;
using Lucene.Net.Analysis.Fr;

namespace OrchardCore.Lucene.FrenchAnalyzers
{
    [Feature("OrchardCore.Lucene.FrenchAnalyzers")]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            // Registers Lucene.NET FrenchAnalyzer.
            services.Configure<LuceneOptions>(o =>
                o.Analyzers.Add(new LuceneAnalyzer("frenchanalyzer",
                    new FrenchAnalyzer(LuceneSettings.DefaultVersion))));

            // Registers custom FrenchAnalyzer.
            services.Configure<LuceneOptions>(o =>
                o.Analyzers.Add(new LuceneAnalyzer("customfrenchanalyzer",
                    new CustomFrenchAnalyzer(LuceneSettings.DefaultVersion))));
        }
    }
}
