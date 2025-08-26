namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents the Totov Builder website configuration.
    /// </summary>
    public class WebsiteConfiguration
    {
        /// <summary>
        /// Bug report URL.
        /// </summary>
        public string BugReportUrl { get; set; } = string.Empty;

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
        /// Tarkov values endpoint.
        /// </summary>
        public string EndpointTarkovValues { get; set; } = string.Empty;

        /// <summary>
        /// URL shortener endpoint.
        /// </summary>
        public string EndpointUrlShortener { get; set; } = string.Empty;

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
    }
}
