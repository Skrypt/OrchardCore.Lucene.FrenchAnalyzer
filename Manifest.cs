using OrchardCore.Modules.Manifest;

[assembly: Feature(
    Id = "OrchardCore.Lucene.FrenchAnalyzers",
    Name = "Lucene French Analyzers",
    Description = "Adds Lucene french analyzer and a custom one that supports sorting diacritics",
    Dependencies = new[]
    {
        "OrchardCore.Lucene"
    },
    Category = "Content Management"
)]
