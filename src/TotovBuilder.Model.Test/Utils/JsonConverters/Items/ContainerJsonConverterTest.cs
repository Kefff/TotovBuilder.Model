using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="ContainerJsonConverter"/> class.
    /// </summary>
    public class ContainerJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeContainer()
        {
            // Arrange
            Container[] containers =
            [
                new Container()
                {
                    Capacity = 4,
                    CategoryId = "container",
                    IconLink = "https://assets.tarkov.dev/5783c43d2459774bbe137486-icon.jpg",
                    Id = "5783c43d2459774bbe137486",
                    ImageLink = "https://assets.tarkov.dev/5783c43d2459774bbe137486-image.jpg",
                    MarketLink = "https://tarkov.dev/item/simple-wallet",
                    Name = "Simple wallet",
                    ShortName = "Wallet",
                    Weight = 0.23,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Simple_wallet"
                },
                new Container()
                {
                    Capacity = 0,
                    CategoryId = "container",
                    IconLink = "https://assets.tarkov.dev/empty-container-icon.jpg",
                    Id = "empty-container",
                    ImageLink = "https://assets.tarkov.dev/empty-container-image.jpg",
                    MarketLink = "https://tarkov.dev/item/empty-container",
                    Name = "Empty container",
                    ShortName = "Empty",
                    Weight = 0.23,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Empty_container"
                }
            ];

            // Act
            string result = Serialize(containers);

            // Assert
            result.Should().Be("[{\"ca\":4,\"c\":\"container\",\"ic\":\"https://assets.tarkov.dev/5783c43d2459774bbe137486-icon.jpg\",\"i\":\"5783c43d2459774bbe137486\",\"im\":\"https://assets.tarkov.dev/5783c43d2459774bbe137486-image.jpg\",\"m\":\"https://tarkov.dev/item/simple-wallet\",\"n\":\"Simple wallet\",\"s\":\"Wallet\",\"w\":0.23,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Simple_wallet\"},{\"c\":\"container\",\"ic\":\"https://assets.tarkov.dev/empty-container-icon.jpg\",\"i\":\"empty-container\",\"im\":\"https://assets.tarkov.dev/empty-container-image.jpg\",\"m\":\"https://tarkov.dev/item/empty-container\",\"n\":\"Empty container\",\"s\":\"Empty\",\"w\":0.23,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Empty_container\"}]");
        }
    }
}
