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
            BugReportUrl = "https://discord.gg/bugreport",
            CacheDuration = 3600,
            ContactAddress = "contact@address.com",
            DiscordUrl = "https://discord.gg/server",
            EndpointChangelog = "data/changelog.json",
            EndpointItemCategories = "data/itemcategories.json",
            EndpointItems = "data/items.json",
            EndpointPresets = "data/presets.json",
            EndpointPrices = "data/prices.json",
            EndpointTarkovValues = "data/tarkov-values.json",
            EndpointUrlShortener = "https://spoo.me/",
            FetchMaxTries = 6,
            FetchTimeout = 10,
            FetchWaitTimeBetweenRetries = 1,
            GithubUrl = "https://github.com/User/Reposiory",
            NotificationErrorDuration = 10,
            NotificationInformationDuration = 5,
            NotificationSuccessDuration = 5,
            NotificationWarningDuration = 10,
            PostUpdatePeriod = true
        };
    }
}
