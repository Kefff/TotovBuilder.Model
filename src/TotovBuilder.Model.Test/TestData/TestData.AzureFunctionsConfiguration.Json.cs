namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public partial class TestData
    {

        public const string AzureFunctionsConfigurationJson = @"{
  ""ApiBartersQuery"": ""{ barters(gameMode: {0}, lang: {1}) { level } }"",
  ""ApiItemsQuery"": ""{ items(lang: {0}) { id } }"",
  ""ApiPresetsQuery"": ""{ items(type: preset) { id } }"",
  ""ApiPricesQuery"": ""{ items(gameMode: {0}, lang: {1}) { id }"",
  ""ApiUrl"": ""https://localhost/api"",
  ""AzureBlobStorageConnectionString"": ""DefaultEndpointsProtocol=https;AccountName=;AccountKey=;EndpointSuffix=core.windows.net"",
  ""AzureBlobStorageRawDataContainerName"": ""totov-builder-raw-data"",
  ""AzureBlobStorageWebsiteContainerName"": ""$web"",
  ""AzureFunctionsConfigurationBlobName"": ""azure-functions-configuration.json"",
  ""ExecutionTimeout"": 25,
  ""GameModes"": {
    ""pvp"": ""regular"",
    ""pve"": ""pve""
  },
  ""Languages"": [
    ""en"",
    ""fr""
  ],
  ""RawChangelogBlobName"": ""changelog.json"",
  ""RawItemCategoriesBlobName"": ""item-categories.json"",
  ""RawItemMissingPropertiesBlobName"": ""item-missing-properties.json"",
  ""RawTarkovValuesBlobName"": ""tarkov-values.json"",
  ""RawWebsiteConfigurationBlobName"": ""website-configuration.json"",
  ""WebsiteDataCacheControl"": ""max-age=3600, must-revalidate"",
  ""WebsiteFileCacheControl"": ""max-age=31536000, must-revalidate"",
  ""WebsiteChangelogBlobName"": ""data/changelog.json"",
  ""WebsiteItemsBlobName"": ""data/items.json"",
  ""WebsitePresetsBlobName"": ""data/presets.json"",
  ""WebsitePricesBlobName"": ""data/prices.json"",
  ""WebsiteTarkovValuesBlobName"": ""data/tarkov-values.json"",
  ""WebsiteWebsiteConfigurationBlobName"": ""data/website-configuration.json""
}";
    }
}
