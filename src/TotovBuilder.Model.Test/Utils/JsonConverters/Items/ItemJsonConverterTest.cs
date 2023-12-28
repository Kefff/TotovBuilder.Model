using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="ItemJsonConverter"/> class.
    /// </summary>
    public class ItemJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeItem()
        {
            // Arrange
            Item[] items = new Item[]
            {
                new Item()
                {
                    CategoryId = "currency",
                    IconLink = "https://assets.tarkov.dev/569668774bdc2da2298b4568-icon.jpg",
                    Id = "569668774bdc2da2298b4568",
                    ImageLink = "https://assets.tarkov.dev/569668774bdc2da2298b4568-image.jpg",
                    MarketLink = "https://tarkov.dev/item/euros",
                    MaxStackableAmount = 50000,
                    ShortName = "EUR",
                    Name = "Euros",
                    Weight = 0,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Euros"
                },
                new Item()
                {
                    CategoryId = "headphones",
                    ConflictingItemIds = new string[] { "5aa7e276e5b5b000171d0647" },
                    IconLink = "https://assets.tarkov.dev/628e4e576d783146b124c64d-icon.jpg",
                    Id = "628e4e576d783146b124c64d",
                    ImageLink = "https://assets.tarkov.dev/628e4e576d783146b124c64d-image.jpg",
                    MarketLink = "https://tarkov.dev/item/peltor-comtac-4-hybrid-headset",
                    Name = "Peltor ComTac 4 Hybrid headset",
                    ShortName = "ComTac 4",
                    Weight = 0.6,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Peltor_ComTac_4_Hybrid_headset"
                }
            };

            // Act
            string result = Serialize(items);

            // Assert
            result.Should().Be("[{\"c\":\"currency\",\"ic\":\"https://assets.tarkov.dev/569668774bdc2da2298b4568-icon.jpg\",\"i\":\"569668774bdc2da2298b4568\",\"im\":\"https://assets.tarkov.dev/569668774bdc2da2298b4568-image.jpg\",\"a\":50000,\"m\":\"https://tarkov.dev/item/euros\",\"n\":\"Euros\",\"s\":\"EUR\",\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Euros\"},{\"c\":\"headphones\",\"co\":[\"5aa7e276e5b5b000171d0647\"],\"ic\":\"https://assets.tarkov.dev/628e4e576d783146b124c64d-icon.jpg\",\"i\":\"628e4e576d783146b124c64d\",\"im\":\"https://assets.tarkov.dev/628e4e576d783146b124c64d-image.jpg\",\"m\":\"https://tarkov.dev/item/peltor-comtac-4-hybrid-headset\",\"n\":\"Peltor ComTac 4 Hybrid headset\",\"s\":\"ComTac 4\",\"w\":0.6,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Peltor_ComTac_4_Hybrid_headset\"}]");
        }
    }
}
