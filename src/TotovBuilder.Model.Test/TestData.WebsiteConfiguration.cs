﻿using TotovBuilder.Model.Configuration;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public static WebsiteConfiguration WebsiteConfiguration { get; } = new()
        {
            BuildSharingUrl = "https://localhost:3000/s/",
            BugReportUrl = "https://discord.gg/bugreport",
            BuildsSortFieldStorageKey = "builds_sort_field",
            BuildsSortOrderStorageKey = "builds_sort_order",
            BuildStorageKeyPrefix = "build_",
            CacheDuration = 3600,
            ChangelogApi = "changelog",
            ContactAddress = "contact@address.com",
            DiscordUrl = "https://discord.gg/server",
            ExportFileExtension = ".ttb",
            ExportFileNamePrefix = "TotovBuilder",
            ExportWarningShowedStoregeKey = "export_warning",
            FetchTimeout = 10,
            GithubUrl = "https://github.com/User/Reposiory",
            ItemCategoriesApi = "itemcategories",
            ItemsApi = "items",
            LanguageStorageKey = "language",
            GlobalFilterStorageKey = "global_filter",
            NotificationErrorDuration = 10,
            NotificationInformationDuration = 5,
            NotificationSuccessDuration = 5,
            NotificationWarningDuration = 10,
            PresetsApi = "presets",
            PricesApi = "prices",
            QuestsApi = "quests",
            VersionStorageKey = "version"
        };
    }
}
