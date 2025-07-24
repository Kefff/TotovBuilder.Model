namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public partial class TestData
    {

        public const string AzureFunctionsConfigurationJson = @"{
  ""ApiBartersQuery"": ""{ barters { level } }"",
  ""ApiItemsQuery"": ""{ items { id } }"",
  ""ApiPresetsQuery"": ""{ items(type: preset) { id } }"",
  ""ApiPricesQuery"": ""{ items { id }"",
  ""ApiUrl"": ""https://localhost/api"",
  ""AzureBlobStorageConnectionString"": ""DefaultEndpointsProtocol=https;AccountName=;AccountKey=;EndpointSuffix=core.windows.net"",
  ""AzureBlobStorageRawDataContainerName"": ""totov-builder-raw-data"",
  ""AzureBlobStorageWebsiteContainerName"": ""$web"",
  ""AzureFunctionsConfigurationBlobName"": ""azure-functions-configuration.json"",
  ""ExecutionTimeout"": 25,
  ""GameModes"": [
    {
      ""name"": null,
      ""queryValue"": ""regular""
    },
    {
      ""name"": ""pve"",
      ""queryValue"": ""pve""
    }
  ],
  ""Languages"": [
    {
      ""name"": null,
      ""queryValue"": ""en""
    },
    {
      ""name"": ""fr"",
      ""queryValue"": ""fr""
    }
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
