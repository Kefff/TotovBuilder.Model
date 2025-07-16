using FluentAssertions;
using TotovBuilder.Model.Configuration;
using TotovBuilder.Model.Items;
using TotovBuilder.Model.Utils.JsonConverters.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="PriceJsonConverter"/> class.
    /// </summary>
    public class PriceJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializePrice()
        {
            // Arrange
            Price[] prices =
            [
                Price1,
                Price2
            ];

            // Act
            string result = Serialize(prices);

            // Assert
            result.Should().Be("[{\"i\":\"5447a9cd4bdc2dbd208b4567\",\"v\":89934,\"vm\":89934},{\"b\":[{\"i\":\"590c595c86f7747884343ad7\"},{\"i\":\"5e2aedd986f7746d404f3aa4\",\"q\":2}],\"c\":\"barter\",\"i\":\"59c1383d86f774290a37e0ca\",\"m\":\"peacekeeper\",\"ml\":3,\"q\":{\"i\":\"5a27bbf886f774333a418eeb\",\"n\":\"Wet Job - Part 2\",\"w\":\"https://escapefromtarkov.fandom.com/wiki/Wet_Job_-_Part_2\"}}]");
        }

        private static readonly Price Price1 = new()
        {
            CurrencyName = "RUB",
            ItemId = "5447a9cd4bdc2dbd208b4567",
            Merchant = "flea-market",
            MerchantLevel = 0,
            Value = 89934.0,
            ValueInMainCurrency = 89934.0
        };

        private static readonly Price Price2 = new()
        {
            BarterItems =
            [
                new BarterItem()
                {
                    ItemId = "590c595c86f7747884343ad7",
                    Quantity = 1
                },
                new BarterItem()
                {
                    ItemId = "5e2aedd986f7746d404f3aa4",
                    Quantity = 2
                }
            ],
            CurrencyName = "barter",
            ItemId = "59c1383d86f774290a37e0ca",
            Merchant = "peacekeeper",
            MerchantLevel = 3,
            Quest = new Quest()
            {
                Id = "5a27bbf886f774333a418eeb",
                Name = "Wet Job - Part 2",
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/Wet_Job_-_Part_2"
            },
            Value = 0,
            ValueInMainCurrency = 0
        };
    }
}
