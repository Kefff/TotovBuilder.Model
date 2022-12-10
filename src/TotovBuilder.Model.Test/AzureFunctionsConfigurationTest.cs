namespace TotovBuilder.Model.Test
{
    using System.Collections.Generic;
    using FluentAssertions;
    using global::TotovBuilder.Model.Configuration;
    using Xunit;

    namespace TotovBuilder.AzureFunctions.Test
    {
        /// <summary>
        /// Represents tests on the <see cref="AzureFunctionsConfiguration"/> class.
        /// </summary>
        public class AzureFunctionsConfigurationTest
    {
        [Fact]
        public void GetBlobNames_ShouldGetBlobNames()
        {
            // Arrange
            AzureFunctionsConfiguration azureFunctionsConfiguration = new()
            {
                AzureArmorPenetrationsBlobName = "armor-penetrations.json",
                AzureChangelogBlobName = "changelog.json",
                AzureFunctionsConfigurationBlobName = "azure-functions-configuration.json",
                AzureItemCategoriesBlobName = "item-categories.json",
                AzureItemMissingPropertiesBlobName = "item-missing-properties.json",
                AzurePresetsBlobName = "presets.json",
                AzureTarkovValuesBlobName = "tarkov-values.json",
                AzureWebsiteConfigurationBlobName = "website-configuration.json"
            };

            // Act
            IEnumerable<string> blobNames = azureFunctionsConfiguration.GetBlobNames();

            // Assert
            blobNames.Should().BeEquivalentTo(new string[]
            {
                "armor-penetrations.json",
                "changelog.json",
                "azure-functions-configuration.json",
                "item-categories.json",
                "item-missing-properties.json",
                "presets.json",
                "tarkov-values.json",
                "website-configuration.json"
            });
        }
    }
}

}
