using System.Collections.Generic;
using TotovBuilder.Model.Utils;

namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents the Totov Builder Azure functions configuration.
    /// </summary>
    public class AzureFunctionsConfiguration
    {
        /// <summary>
        /// Path of the API file containing barters.
        /// <c>{0}</c> is replaced by the game mode API value.
        /// </summary>
        public string ApiBartersPath { get; set; } = string.Empty;

        /// <summary>
        /// Base URL of the API files.
        /// </summary>
        public string ApiBaseUrl { get; set; } = string.Empty;

        /// <summary>
        /// Path of the API file containing items.
        /// <c>{0}</c> is replaced by the game mode API value.
        /// </summary>
        public string ApiItemsPath { get; set; } = string.Empty;

        /// <summary>
        /// Path of the API file containing items translations.
        /// <c>{0}</c> is replaced by the game mode API value and <c>{1}</c> by the language.
        /// </summary>
        public string ApiItemsTranslationsPath { get; set; } = string.Empty;

        /// <summary>
        /// Path of the API file containing the current season.
        /// </summary>
        public string ApiSeasonPath { get; set; } = string.Empty;

        /// <summary>
        /// Path of the API file containing tasks.
        /// <c>{0}</c> is replaced by the game mode API value.
        /// </summary>
        public string ApiTasksPath { get; set; } = string.Empty;

        /// <summary>
        /// Path of the API file containing tasks translations.
        /// <c>{0}</c> is replaced by the game mode API value and <c>{1}</c> by the language.
        /// </summary>
        public string ApiTasksTranslationsPath { get; set; } = string.Empty;

        /// <summary>
        /// Path of the API file containing traders.
        /// <c>{0}</c> is replaced by the game mode API value.
        /// </summary>
        public string ApiTradersPath { get; set; } = string.Empty;

        /// <summary>
        /// Connection string to the Azure blob storage containing static data.
        /// </summary>
        public string AzureBlobStorageConnectionString { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob storage containing raw data used to generate data used by the website.
        /// </summary>
        public string AzureBlobStorageRawDataContainerName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob storage containing the website.
        /// </summary>
        public string AzureBlobStorageWebsiteContainerName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing Azure Functions configuration data.
        /// Stored in the same container as raw data.
        /// </summary>
        public string AzureFunctionsConfigurationBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Time (in seconds) before an operation is timed out.
        /// </summary>
        public int ExecutionTimeout { get; set; } = 30;

        /// <summary>
        /// Game modes.
        /// </summary>
        public IEnumerable<GameMode> GameModes { get; set; } = [];

        /// <summary>
        /// Game mode API value used to get the items statistics, which are common to all game modes.
        /// </summary>
        public string ItemsGameMode { get; set; } = string.Empty;

        /// <summary>
        /// Languages in which items can be retrieved.
        /// </summary>
        public string[] ItemsLanguages { get; set; } = [];

        /// <summary>
        /// Name of the Azure blob containing raw changelog data.
        /// </summary>
        public string RawChangelogBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing raw item categories data.
        /// </summary>
        public string RawItemCategoriesBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing raw data related to Tarkov gameplay.
        /// </summary>
        public string RawTarkovValuesBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing raw website configuration data.
        /// </summary>
        public string RawWebsiteConfigurationBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Value of the <c>Cache-Control</c> HTTP header to apply to website data.
        /// </summary>
        public string WebsiteDataCacheControl { get; set; } = string.Empty;

        /// <summary>
        /// Value of the <c>Cache-Control</c> HTTP header to apply to website files.
        /// </summary>
        public string WebsiteFileCacheControl { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing changelog data for the website.
        /// </summary>
        public string WebsiteChangelogBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing item categories data for the website.
        /// </summary>
        public string WebsiteItemCategoriesBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing items data for the website.
        /// </summary>
        public string WebsiteItemsBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing presets data for the website.
        /// </summary>
        public string WebsitePresetsBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing prices data for the website.
        /// </summary>
        public string WebsitePricesBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing data related to Tarkov gameplay for the website.
        /// </summary>
        public string WebsiteTarkovValuesBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing website configuration data for the website.
        /// </summary>
        public string WebsiteWebsiteConfigurationBlobName { get; set; } = string.Empty;
    }
}
