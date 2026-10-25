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
        /// Name of the directory containing the TotovBuilder website build result.
        /// </summary>
        public string WebsiteBuildDirectory { get; set; } = string.Empty;

        /// <summary>
        /// Command for compiling the TotovBuilder website project.
        /// </summary>
        public string WebsiteCompilationCommand { get; set; } = string.Empty;

        /// <summary>
        /// Pattern to avoid having website data files being deleted when deploying the website to Azure.
        /// </summary>
        public string WebsiteDeploymentFileNotToDeletePattern { get; set; } = string.Empty;

        /// <summary>
        /// Path to the directory containing the TotovBuilder website project.
        /// </summary>
        public string WebsiteDirectoryPath { get; set; } = string.Empty;
    }
}
