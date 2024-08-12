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
            Armor[] armors =
            [
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
                    ArmoredAreas =
                    [
                        "FR. PLATE",
                        "BCK. PLATE",
                        "L. PLATE",
                        "R. PLATE",
                        "Chest",
                        "Stomach",
                        "Stomach, Lower back",
                        "Thorax, Upper back",
                        "Stomach, Left Side",
                        "Stomach, Right Side",
                        "Head, Neck",
                        "Head, Throat",
                        "Left arm, Shoulder",
                        "Right arm, Shoulder",
                        "Stomach, Groin"
                    ],
                    CategoryId = "armor",
                    DefaultPresetId = "65766adc234b9f6e050a431a",
                    Durability = 85,
                    ErgonomicsModifierPercentage = -0.1,
                    IconLink = "https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-icon.webp\"",
                    Id = "545cdb794bdc2d3a198b456a",
                    ImageLink = "https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-image.webp",
                    MarketLink = "https://tarkov.dev/item/6b43-zabralo-sh-body-armor-digital-flora",
                    Material = "Aramid",
                    ModSlots =
                    [
                        new ModSlot()
                        {
                            Name = "Front_plate"
                        },
                        new ModSlot()
                        {
                            Name = "Back_plate"
                        },
                        new ModSlot()
                        {
                            Name = "Left_side_plate"
                        },
                        new ModSlot()
                        {
                            Name = "Right_side_plate"
                        }
                    ],
                    MovementSpeedModifierPercentage = -0.115,
                    Name = "6B43 Zabralo-Sh body armor (Digital Flora)",
                    ShortName = "6B43",
                    TurningSpeedModifierPercentage = -0.055,
                    Weight = 10.8,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/6B43_Zabralo-Sh_body_armor_(Digital_Flora)"
                }
            ];

            // Act
            string result = Serialize(armors);

            // Assert
            result.Should().Be("[{\"c\":\"armor\",\"ic\":\"https://assets.tarkov.dev/unknown-icon.jpg\",\"i\":\"unknown\",\"im\":\"https://assets.tarkov.dev/unknown-image.jpg\",\"m\":\"https://tarkov.dev/item/unknown\",\"n\":\"Unknown\",\"s\":\"Unknown\",\"w\":0.2,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Unknown\"},{\"ac\":6,\"aa\":[\"FR. PLATE\",\"BCK. PLATE\",\"L. PLATE\",\"R. PLATE\",\"Chest\",\"Stomach\",\"Stomach, Lower back\",\"Thorax, Upper back\",\"Stomach, Left Side\",\"Stomach, Right Side\",\"Head, Neck\",\"Head, Throat\",\"Left arm, Shoulder\",\"Right arm, Shoulder\",\"Stomach, Groin\"],\"dp\":\"65766adc234b9f6e050a431a\",\"d\":85,\"e\":-0.1,\"ma\":\"Aramid\",\"mo\":[{\"n\":\"Front_plate\"},{\"n\":\"Back_plate\"},{\"n\":\"Left_side_plate\"},{\"n\":\"Right_side_plate\"}],\"ms\":-0.115,\"t\":-0.055,\"c\":\"armor\",\"ic\":\"https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-icon.webp\\u0022\",\"i\":\"545cdb794bdc2d3a198b456a\",\"im\":\"https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-image.webp\",\"m\":\"https://tarkov.dev/item/6b43-zabralo-sh-body-armor-digital-flora\",\"n\":\"6B43 Zabralo-Sh body armor (Digital Flora)\",\"s\":\"6B43\",\"w\":10.8,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/6B43_Zabralo-Sh_body_armor_(Digital_Flora)\"}]");
        }
    }
}
