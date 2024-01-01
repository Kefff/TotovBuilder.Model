using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="VestJsonConverter"/> class.
    /// </summary>
    public class VestJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeVest()
        {
            // Arrange
            Vest[] containers = new Vest[]
            {
                new Vest()
                {
                    ArmorClass = 4,
                    ArmoredAreas = new string[]
                    {
                        "Thorax",
                        "Stomach"
                    },
                    Capacity = 12,
                    CategoryId = "vest",
                    Durability = 40,
                    ErgonomicsPercentageModifier = -0.15,
                    IconLink = "https://assets.tarkov.dev/5d5d646386f7742797261fd9-icon.jpg",
                    Id = "5d5d646386f7742797261fd9",
                    ImageLink = "https://assets.tarkov.dev/5d5d646386f7742797261fd9-image.jpg",
                    MarketLink = "https://tarkov.dev/item/6b3tm-01m-armored-rig",
                    Material = "Titan",
                    MovementSpeedPercentageModifier = -0.10,
                    Name = "6B3TM-01M armored rig",
                    //RicochetChance = , // TODO : MISSING FROM API
                    ShortName = "6B3TM-01M",
                    TurningSpeedPercentageModifier = -0.05,
                    Weight = 9.2,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/6B3TM-01M_armored_rig"
                },
                new Vest()
                {
                    Capacity = 6,
                    CategoryId = "vest",
                    IconLink = "https://assets.tarkov.dev/572b7adb24597762ae139821-icon.jpg",
                    Id = "572b7adb24597762ae139821",
                    ImageLink = "https://assets.tarkov.dev/572b7adb24597762ae139821-image.jpg",
                    MarketLink = "https://tarkov.dev/item/scav-vest",
                    Name = "Scav Vest",
                    ShortName = "Scav Vest",
                    Weight = 0.4,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Scav_Vest"
                }
            };

            // Act
            string result = Serialize(containers);

            // Assert
            result.Should().Be("[{\"ac\":4,\"aa\":[\"Thorax\",\"Stomach\"],\"d\":40,\"e\":-0.15,\"ma\":\"Titan\",\"ms\":-0.1,\"t\":-0.05,\"ca\":12,\"c\":\"vest\",\"ic\":\"https://assets.tarkov.dev/5d5d646386f7742797261fd9-icon.jpg\",\"i\":\"5d5d646386f7742797261fd9\",\"im\":\"https://assets.tarkov.dev/5d5d646386f7742797261fd9-image.jpg\",\"m\":\"https://tarkov.dev/item/6b3tm-01m-armored-rig\",\"n\":\"6B3TM-01M armored rig\",\"s\":\"6B3TM-01M\",\"w\":9.2,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/6B3TM-01M_armored_rig\"},{\"ca\":6,\"c\":\"vest\",\"ic\":\"https://assets.tarkov.dev/572b7adb24597762ae139821-icon.jpg\",\"i\":\"572b7adb24597762ae139821\",\"im\":\"https://assets.tarkov.dev/572b7adb24597762ae139821-image.jpg\",\"m\":\"https://tarkov.dev/item/scav-vest\",\"n\":\"Scav Vest\",\"s\":\"Scav Vest\",\"w\":0.4,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Scav_Vest\"}]");
        }
    }
}
