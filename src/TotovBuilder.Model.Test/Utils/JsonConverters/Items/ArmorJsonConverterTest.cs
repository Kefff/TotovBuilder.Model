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
                    CategoryId = "headwear",
                    IconLink = "https://assets.tarkov.dev/5bd073c986f7747f627e796c-icon.jpg",
                    Id = "5bd073c986f7747f627e796c",
                    ImageLink = "https://assets.tarkov.dev/5bd073c986f7747f627e796c-image.jpg",
                    MarketLink = "https://tarkov.dev/item/kotton-beanie",
                    Name = "Kotton beanie",
                    ShortName = "Kotton",
                    Weight = 0.2,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Kotton_beanie"
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
                    RicochetChance = "High",
                    ShortName = "6B43 6A",
                    TurningSpeedPercentageModifier = -0.21,
                    Weight = 20,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/6B43_6A_Zabralo-Sh_body_armor"
                }
            };

            // Act
            string result = Serialize(armors);

            // Assert
            result.Should().Be("[{\"c\":\"headwear\",\"ic\":\"https://assets.tarkov.dev/5bd073c986f7747f627e796c-icon.jpg\",\"i\":\"5bd073c986f7747f627e796c\",\"im\":\"https://assets.tarkov.dev/5bd073c986f7747f627e796c-image.jpg\",\"m\":\"https://tarkov.dev/item/kotton-beanie\",\"n\":\"Kotton beanie\",\"s\":\"Kotton\",\"w\":0.2,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Kotton_beanie\"},{\"ac\":6,\"aa\":[\"LeftArm\",\"RightArm\",\"Thorax\",\"Stomach\"],\"d\":85,\"e\":-0.27,\"ma\":\"CombinedMaterials\",\"ms\":-0.35,\"r\":\"High\",\"t\":-0.21,\"c\":\"armor\",\"ic\":\"https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-icon.jpg\",\"i\":\"545cdb794bdc2d3a198b456a\",\"im\":\"https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-image.jpg\",\"m\":\"https://tarkov.dev/item/6b43-6a-zabralo-sh-body-armor\",\"n\":\"6B43 6A Zabralo-Sh body armor\",\"s\":\"6B43 6A\",\"w\":20,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/6B43_6A_Zabralo-Sh_body_armor\"}]");
        }
    }
}
