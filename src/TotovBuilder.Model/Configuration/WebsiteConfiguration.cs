namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents the Totov Builder website configuration.
    /// </summary>
    public class WebsiteConfiguration
    {
        /// <summary>
        /// Storage key for the allow cookies indicator.
        /// </summary>
        public string AllowCookiesStorageKey { get; set; } = string.Empty;

        /// <summary>
        /// Bug report URL.
        /// </summary>
        public string BugReportUrl { get; set; } = string.Empty;

        /// <summary>
        /// URL for sharing builds.
        /// </summary>
        public string BuildSharingUrl { get; set; } = string.Empty;

        /// <summary>
        /// Storage key for the current build sorting colum.
        /// </summary>
        public string BuildsSortFieldStorageKey { get; set; } = string.Empty;

        /// <summary>
        /// Storage key for the current build sort order.
        /// </summary>
        public string BuildsSortOrderStorageKey { get; set; } = string.Empty;

        /// <summary>
        /// Storage key prefix for builds.
        /// </summary>
        public string BuildStorageKeyPrefix { get; set; } = string.Empty;

        /// <summary>
        /// Cache duration (in seconds).
        /// </summary>
        public int CacheDuration { get; set; }

        /// <summary>
        /// Contact mail address.
        /// </summary>
        public string ContactAddress { get; set; } = string.Empty;

        /// <summary>
        /// Discord server URL.
        /// </summary>
        public string DiscordUrl { get; set; } = string.Empty;

        /// <summary>
        /// Changelog endpoint.
        /// </summary>
        public string EndpointChangelog { get; set; } = string.Empty;

        /// <summary>
        /// Item categories endpoint.
        /// </summary>
        public string EndpointItemCategories { get; set; } = string.Empty;

        /// <summary>
        /// Items endpoint.
        /// </summary>
        public string EndpointItems { get; set; } = string.Empty;

        /// <summary>
        /// Presets endpoint.
        /// </summary>
        public string EndpointPresets { get; set; } = string.Empty;

        /// <summary>
        /// Prices endpoint.
        /// </summary>
        public string EndpointPrices { get; set; } = string.Empty;

        /// <summary>
        /// Quests endpoint.
        /// </summary>
        public string EndpointQuests { get; set; } = string.Empty;

        /// <summary>
        /// Tarkov values endpoint.
        /// </summary>
        public string EndpointTarkovValues { get; set; } = string.Empty;

        /// <summary>
        /// Export file extension.
        /// </summary>
        public string ExportFileExtension { get; set; } = string.Empty;

        /// <summary>
        /// Export file prefix.
        /// </summary>
        public string ExportFileNamePrefix { get; set; } = string.Empty;

        /// <summary>
        /// Storage key for the value indicating whether the warning about builds not exported has been displayed.
        /// </summary>
        public string ExportWarningShowedStorageKey { get; set; } = string.Empty;

        /// <summary>
        /// Maximum number of tries when an error occurs when fetching data.
        /// </summary>
        public int FetchMaxTries { get; set; }

        /// <summary>
        /// Fetch timeout (in seconds).
        /// </summary>
        public int FetchTimeout { get; set; }

        /// <summary>
        /// Time to wait between retries when an error occurs whent fetching data (in seconds).
        /// </summary>
        public int FetchWaitTimeBetweenRetries { get; set; }

        /// <summary>
        /// Github project URL.
        /// </summary>
        public string GithubUrl { get; set; } = string.Empty;

        /// <summary>
        /// Storage key for the current global filter.
        /// </summary>
        public string GlobalFilterStorageKey { get; set; } = string.Empty;

        /// <summary>
        /// Storage key for the current language.
        /// </summary>
        public string LanguageStorageKey { get; set; } = string.Empty;

        /// <summary>
        /// Error notifications duration (in seconds).
        /// </summary>
        public int NotificationErrorDuration { get; set; }

        /// <summary>
        /// Information notifications duration (in seconds).
        /// </summary>
        public int NotificationInformationDuration { get; set; }

        /// <summary>
        /// Success notifications duration (in seconds).
        /// </summary>
        public int NotificationSuccessDuration { get; set; }

        /// <summary>
        /// Warning notifications duration (in seconds).
        /// </summary>
        public int NotificationWarningDuration { get; set; }

        /// <summary>
        /// Indicates whether we are in a post-update period and items and prices are being updated.
        /// </summary>
        public bool PostUpdatePeriod { get; set; } = false;

        /// <summary>
        /// Version of the website.
        /// </summary>
        public string Version { get; set; } = string.Empty;

        /// <summary>
        /// Storage key for the current version.
        /// </summary>
        public string VersionStorageKey { get; set; } = string.Empty;
    }
}
