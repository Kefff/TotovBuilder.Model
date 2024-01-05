namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents the configuration of the Totov Builder deployer.
    /// </summary>
    public class DeployerConfiguration
    {
        /// <summary>
        /// Name of the Azure blob containing the Azure Functions configuration.
        /// </summary>
        public string AzureFunctionsConfigurationBlobName { get; set; } = string.Empty;

        /// <summary>
        /// Directory containing all the TotovBuilder configuration files.
        /// </summary>
        public string ConfigurationsDirectory { get; set; } = string.Empty;

        /// <summary>
        /// Name of the configuration file.
        /// </summary>
        public string DeployerConfigurationFileName { get; set; } = string.Empty;

        /// <summary>
        /// Current deployment mode.
        /// </summary>
        public DeploymentMode? DeployerDeploymentMode { get; set; }

        /// <summary>
        /// String to search to dertemine where the items data ends in the Tarkov resources file when extracting items.
        /// </summary>
        public string ItemsExtractionEndSearchString { get; set; } = string.Empty;

        /// <summary>
        /// String to search to dertemine where the items data starts in the Tarkov resources file when extracting items.
        /// </summary>
        public string ItemsExtractionStartSearchString { get; set; } = string.Empty;

        /// <summary>
        /// Directory for archiving previous data extractions.
        /// </summary>
        public string PreviousExtractionsArchiveDirectory { get; set; } = string.Empty;

        /// <summary>
        /// Path to the Tarkov executable file.
        /// </summary>
        public string TarkovExecutableFilePath { get; set; } = string.Empty;

        /// <summary>
        /// Path of the Tarkov file data are extracted from.
        /// </summary>
        public string TarkovResourcesFilePath { get; set; } = string.Empty;

        /// <summary>
        /// Name of the directory containing the TotovBuilder website build result.
        /// </summary>
        public string WebsiteBuildDirectory { get; set; } = string.Empty;

        /// <summary>
        /// Path to the directory containing the TotovBuilder website project.
        /// </summary>
        public string WebsiteDirectoryPath { get; set; } = string.Empty;
    }
}
