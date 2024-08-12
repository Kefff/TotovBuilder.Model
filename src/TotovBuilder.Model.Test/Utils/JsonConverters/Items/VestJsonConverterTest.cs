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
            Vest[] containers =
            [
                new Vest()
                {
                    ArmorClass = 4,
                    ArmoredAreas =
                    [
                        "FR. PLATE",
                        "BCK. PLATE",
                        "L. PLATE",
                        "R. PLATE",
                        "Stomach, Left Side",
                        "Stomach, Right Side"
                    ],
                    Capacity = 14,
                    CategoryId = "vest",
                    Durability = 40,
                    ErgonomicsModifierPercentage = -0.01,
                    IconLink = "https://assets.tarkov.dev/61bc85697113f767765c7fe7-icon.webp",
                    Id = "5d5d646386f7742797261fd9",
                    ImageLink = "https://assets.tarkov.dev/61bc85697113f767765c7fe7-image.webp",
                    MarketLink = "https://tarkov.dev/item/eagle-industries-mmac-plate-carrier-ranger-green",
                    Material = "Aramid",
                    MovementSpeedModifierPercentage = -0.01,
                    Name = "6B3TM-01M armored rig",
                    ShortName = "6B3TM-01M",
                    TurningSpeedModifierPercentage = -0.01,
                    Weight = 2.83,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Eagle_Industries_MMAC_plate_carrier_(Ranger_Green)"
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
            ];

            // Act
            string result = Serialize(containers);

            // Assert
            result.Should().Be("[{\"ac\":4,\"aa\":[\"FR. PLATE\",\"BCK. PLATE\",\"L. PLATE\",\"R. PLATE\",\"Stomach, Left Side\",\"Stomach, Right Side\"],\"d\":40,\"e\":-0.01,\"ma\":\"Aramid\",\"ms\":-0.01,\"t\":-0.01,\"ca\":14,\"c\":\"vest\",\"ic\":\"https://assets.tarkov.dev/61bc85697113f767765c7fe7-icon.webp\",\"i\":\"5d5d646386f7742797261fd9\",\"im\":\"https://assets.tarkov.dev/61bc85697113f767765c7fe7-image.webp\",\"m\":\"https://tarkov.dev/item/eagle-industries-mmac-plate-carrier-ranger-green\",\"n\":\"6B3TM-01M armored rig\",\"s\":\"6B3TM-01M\",\"w\":2.83,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Eagle_Industries_MMAC_plate_carrier_(Ranger_Green)\"},{\"ca\":6,\"c\":\"vest\",\"ic\":\"https://assets.tarkov.dev/572b7adb24597762ae139821-icon.jpg\",\"i\":\"572b7adb24597762ae139821\",\"im\":\"https://assets.tarkov.dev/572b7adb24597762ae139821-image.jpg\",\"m\":\"https://tarkov.dev/item/scav-vest\",\"n\":\"Scav Vest\",\"s\":\"Scav Vest\",\"w\":0.4,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Scav_Vest\"}]");
        }
    }
}
