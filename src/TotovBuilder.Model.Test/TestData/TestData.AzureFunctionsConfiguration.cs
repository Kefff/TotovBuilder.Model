using TotovBuilder.Model.Configuration;
using TotovBuilder.Model.Utils;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public static AzureFunctionsConfiguration AzureFunctionsConfiguration { get; } = new AzureFunctionsConfiguration()
        {
            ApiBartersPath = "/{0}/barters",
            ApiBaseUrl = "https://localhost",
            ApiItemsPath = "/{0}/items",
            ApiItemsTranslationsPath = "/{0}/items_{1}",
            ApiSeasonPath = "/pvp-season/season",
            ApiTasksPath = "/{0}/tasks",
            ApiTasksTranslationsPath = "/{0}/tasks_{1}",
            ApiTradersPath = "/{0}/traders",
            AzureBlobStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=;AccountKey=;EndpointSuffix=core.windows.net",
            AzureBlobStorageRawDataContainerName = "totov-builder-raw-data",
            AzureBlobStorageWebsiteContainerName = "$web",
            AzureFunctionsConfigurationBlobName = "azure-functions-configuration.json",
            ExecutionTimeout = 30,
            GameModes = [
                new GameMode()
                {
                    ApiQueryValue = "regular",
                    Name = "pvp"
                },
                new GameMode()
                {
                    ApiQueryValue = "pve",
                    Name = "pve"
                },
                new GameMode()
                {
                    ApiQueryValue = "pvp-season",
                    FallbackGameModeName = "pvp",
                    Name = "pvp-season"
                }
            ],
            ItemsGameMode = "regular",
            ItemsLanguages = [
                "en",
                "fr"
            ],
            RawChangelogBlobName = "changelog.json",
            RawItemCategoriesBlobName = "item-categories.json",
            RawTarkovValuesBlobName = "tarkov-values.json",
            RawWebsiteConfigurationBlobName = "website-configuration.json",
            WebsiteChangelogBlobName = "data/changelog.json",
            WebsiteDataCacheControl = "max-age=3600, must-revalidate",
            WebsiteFileCacheControl = "max-age=31536000, must-revalidate",
            WebsiteItemsBlobName = "data/items_{0}.json",
            WebsitePresetsBlobName = "data/presets.json",
            WebsitePricesBlobName = "data/prices_{0}_{1}.json",
            WebsiteTarkovValuesBlobName = "data/tarkov-values.json",
            WebsiteWebsiteConfigurationBlobName = "data/website-configuration.json"
        };
    }
}
