using System;
using System.Collections.Generic;
using System.Linq;

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
        /// API query for getting prices.
        /// </summary>
        public string ApiQuestsQuery { get; set; } = string.Empty;

        /// <summary>
        /// API URL.
        /// </summary>
        public string ApiUrl { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing the armor penetrations.
        /// </summary>
        public string AzureArmorPenetrationsBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Connection string to the Azure blob storage containing static data.
        /// </summary>
        public string AzureBlobStorageConnectionString { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob storage containing static data.
        /// </summary>
        public string AzureBlobStorageContainerName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing the changelog.
        /// </summary>
        public string AzureChangelogBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing the Azure Functions configuration.
        /// </summary>
        public string AzureFunctionsConfigurationBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing the item categories.
        /// </summary>
        public string AzureItemCategoriesBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing items data missing from the API.
        /// </summary>
        public string AzureItemMissingPropertiesBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing the values related to Tarkov gameplay.
        /// </summary>
        public string AzureTarkovValuesBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Name of the Azure blob containing the website configuration.
        /// </summary>
        public string AzureWebsiteConfigurationBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Time (in seconds) fetched API data is kept before needing to refresh it.
        /// </summary>
        public int CacheDuration { get; set; } = 43200;

        /// <summary>
        /// Time (in seconds) before a fetch is timed out.
        /// </summary>
        public int FetchTimeout { get; set; } = 30;

        /// <summary>
        /// Time (in seconds) fetched API prices are kept before needing to refresh them.
        /// </summary>
        public int PriceCacheDuration { get; set; } = 3600;

        /// <summary>
        /// Gets the names of the blobs to upload to Azure.
        /// </summary>
        /// <returns>Names of the blobs to upload.</returns>
        public IEnumerable<string> GetBlobNames()
        {
            Type azureFunctionsConfigurationType = typeof(AzureFunctionsConfiguration);
            IEnumerable<string> blobsToUpload = azureFunctionsConfigurationType.GetProperties()
                .Where(p => p.Name.EndsWith("BlobName"))
                .Select(p => p.GetValue(this) as string ?? string.Empty);

            return blobsToUpload;
        }
    }
}
