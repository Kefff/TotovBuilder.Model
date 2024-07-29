using TotovBuilder.Model.Configuration;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public static WebsiteConfiguration WebsiteConfiguration { get; } = new WebsiteConfiguration()
        {
            AllowCookiesStorageKey = "allow_cookies",
            BugReportUrl = "https://discord.gg/bugreport",
            BuildSharingUrl = "s/",
            BuildsFilterStorageKey = "builds_filter",
            BuildsSortFieldStorageKey = "builds_sort_field",
            BuildsSortOrderStorageKey = "builds_sort_order",
            BuildStorageKeyPrefix = "build_",
            CacheDuration = 3600,
            ContactAddress = "contact@address.com",
            DiscordUrl = "https://discord.gg/server",
            EndpointChangelog = "data/changelog.json",
            EndpointItemCategories = "data/itemcategories.json",
            EndpointItems = "data/items.json",
            EndpointPresets = "data/presets.json",
            EndpointPrices = "data/prices.json",
            EndpointQuests = "data/quests.json",
            ExportFileExtension = ".ttb",
            ExportFileNamePrefix = "TotovBuilder",
            ExportWarningShowedStorageKey = "export_warning",
            FetchTimeout = 10,
            GithubUrl = "https://github.com/User/Reposiory",
            GlobalFilterStorageKey = "global_filter",
            LanguageStorageKey = "language",
            NotificationErrorDuration = 10,
            NotificationInformationDuration = 5,
            NotificationSuccessDuration = 5,
            NotificationWarningDuration = 10,
            PostUpdatePeriod = false,
            Version = "1.6.0",
            VersionStorageKey = "version"
        };
    }
}
