namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents the Totov Builder Azure functions configuration.
    /// </summary>
    public class AzureFunctionsConfiguration
    {
        /// <summary>
        /// API query for getting barters.
        /// </summary>
        public string ApiBartersQuery { get; set; } = string.Empty;

        /// <summary>
        /// API query for getting items.
        /// </summary>
        public string ApiItemsQuery { get; set; } = string.Empty;

        /// <summary>
        /// API query for getting presets.
        /// </summary>
        public string ApiPresetsQuery { get; set; } = string.Empty;

        /// <summary>
        /// API query for getting prices.
        /// </summary>
        public string ApiPricesQuery { get; set; } = string.Empty;

        /// <summary>
        /// API URL.
        /// </summary>
        public string ApiUrl { get; set; } = string.Empty;

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
        /// Time (in seconds) fetched API data is kept before needing to refresh it.
        /// </summary>
        public int CacheDuration { get; set; } = 43200;

        /// <summary>
        /// Time (in seconds) before an operation is timed out.
        /// </summary>
        public int ExecutionTimeout { get; set; } = 30;

        /// <summary>
        /// Time (in seconds) fetched API prices are kept before needing to refresh them.
        /// </summary>
        public int PriceCacheDuration { get; set; } = 3600;

        /// <summary>
        /// Name of the Azure blob containing raw armor penetrations data.
        /// </summary>
        public string RawArmorPenetrationsBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing raw changelog data.
        /// </summary>
        public string RawChangelogBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing raw item categories data.
        /// </summary>
        public string RawItemCategoriesBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing raw items data missing from the API.
        /// </summary>
        public string RawItemMissingPropertiesBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing raw data related to Tarkov gameplay.
        /// </summary>
        public string RawTarkovValuesBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing raw website configuration data.
        /// </summary>
        public string RawWebsiteConfigurationBlobName { get; set; } = string.Empty;

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
