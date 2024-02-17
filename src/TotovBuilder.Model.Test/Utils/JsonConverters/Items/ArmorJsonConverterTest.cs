using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="ArmorJsonConverter"/> class.
    /// </summary>
    public class ArmorJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeArmor()
        {
            // Arrange
            Armor[] armors = new Armor[]
            {
                new Armor()
                {
                    CategoryId = "armor",
                    IconLink = "https://assets.tarkov.dev/unknown-icon.jpg",
                    Id = "unknown",
                    ImageLink = "https://assets.tarkov.dev/unknown-image.jpg",
                    MarketLink = "https://tarkov.dev/item/unknown",
                    Name = "Unknown",
                    ShortName = "Unknown",
                    Weight = 0.2,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Unknown"
                },
                new Armor()
                {
                    ArmorClass = 6,
                    ArmoredAreas = new string[]
                    {
                        "LeftArm",
                        "RightArm",
                        "Thorax",
                        "Stomach"
                    },
                    CategoryId = "armor",
                    Durability = 85,
                    ErgonomicsPercentageModifier = -0.27,
                    IconLink = "https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-icon.jpg",
                    Id = "545cdb794bdc2d3a198b456a",
                    ImageLink = "https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-image.jpg",
                    MarketLink = "https://tarkov.dev/item/6b43-6a-zabralo-sh-body-armor",
                    Material = "CombinedMaterials",
                    MovementSpeedPercentageModifier = -0.35,
                    Name = "6B43 6A Zabralo-Sh body armor",
                    ShortName = "6B43 6A",
                    TurningSpeedPercentageModifier = -0.21,
                    Weight = 20,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/6B43_6A_Zabralo-Sh_body_armor"
                }
            };

            // Act
            string result = Serialize(armors);

            // Assert
            result.Should().Be("[{\"c\":\"armor\",\"ic\":\"https://assets.tarkov.dev/unknown-icon.jpg\",\"i\":\"unknown\",\"im\":\"https://assets.tarkov.dev/unknown-image.jpg\",\"m\":\"https://tarkov.dev/item/unknown\",\"n\":\"Unknown\",\"s\":\"Unknown\",\"w\":0.2,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Unknown\"},{\"ac\":6,\"aa\":[\"LeftArm\",\"RightArm\",\"Thorax\",\"Stomach\"],\"d\":85,\"e\":-0.27,\"ma\":\"CombinedMaterials\",\"ms\":-0.35,\"t\":-0.21,\"c\":\"armor\",\"ic\":\"https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-icon.jpg\",\"i\":\"545cdb794bdc2d3a198b456a\",\"im\":\"https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-image.jpg\",\"m\":\"https://tarkov.dev/item/6b43-6a-zabralo-sh-body-armor\",\"n\":\"6B43 6A Zabralo-Sh body armor\",\"s\":\"6B43 6A\",\"w\":20,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/6B43_6A_Zabralo-Sh_body_armor\"}]");
        }
    }
}
