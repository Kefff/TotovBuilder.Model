namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public partial class TestData
    {

        public const string AzureFunctionsConfigurationJson = @"{
  ""ApiBartersPath"": ""/{0}/barters"",
  ""ApiBaseUrl"": ""https://localhost"",
  ""ApiItemsPath"": ""/{0}/items"",
  ""ApiItemsTranslationsPath"": ""/{0}/items_{1}"",
  ""ApiSeasonPath"": ""/pvp-season/season"",
  ""ApiTasksPath"": ""/{0}/tasks"",
  ""ApiTasksTranslationsPath"": ""/{0}/tasks_{1}"",
  ""ApiTradersPath"": ""/{0}/traders"",
  ""AzureBlobStorageConnectionString"": ""DefaultEndpointsProtocol=https;AccountName=;AccountKey=;EndpointSuffix=core.windows.net"",
  ""AzureBlobStorageRawDataContainerName"": ""totov-builder-raw-data"",
  ""AzureBlobStorageWebsiteContainerName"": ""$web"",
  ""AzureFunctionsConfigurationBlobName"": ""azure-functions-configuration.json"",
  ""ExecutionTimeout"": 30,
  ""GameModes"": [
    {
      ""name"": ""pvp"",
      ""apiQueryValue"": ""regular""
    },
    {
      ""name"": ""pve"",
      ""apiQueryValue"": ""pve""
    },
    {
      ""name"": ""pvp-season"",
      ""apiQueryValue"": ""pvp-season"",
      ""fallbackGameModeName"": ""pvp""
    }
  ],
  ""ItemsGameMode"": ""regular"",
  ""ItemsLanguages"": [
    ""en"",
    ""fr""
  ],
  ""RawChangelogBlobName"": ""changelog.json"",
  ""RawItemCategoriesBlobName"": ""item-categories.json"",
  ""RawTarkovValuesBlobName"": ""tarkov-values.json"",
  ""RawWebsiteConfigurationBlobName"": ""website-configuration.json"",
  ""WebsiteChangelogBlobName"": ""data/changelog.json"",
  ""WebsiteDataCacheControl"": ""max-age=3600, must-revalidate"",
  ""WebsiteFileCacheControl"": ""max-age=31536000, must-revalidate"",
  ""WebsiteItemsBlobName"": ""data/items_{0}.json"",
  ""WebsitePresetsBlobName"": ""data/presets.json"",
  ""WebsitePricesBlobName"": ""data/prices_{0}_{1}.json"",
  ""WebsiteTarkovValuesBlobName"": ""data/tarkov-values.json"",
  ""WebsiteWebsiteConfigurationBlobName"": ""data/website-configuration.json""
}";
    }
}
