using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="RangedWeaponModJsonConverter"/> class.
    /// </summary>
    public class RangedWeaponModJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeRangedWeaponMod()
        {
            // Arrange
            RangedWeaponMod[] containers = new RangedWeaponMod[]
            {
                new RangedWeaponMod()
                {
                    AccuracyPercentageModifier = -0.01,
                    CategoryId = "rangedWeaponMod",
                    ErgonomicsModifier = -5,
                    IconLink = "https://assets.tarkov.dev/58aeac1b86f77457c419f475-icon.jpg",
                    Id = "58aeac1b86f77457c419f475",
                    ImageLink = "https://assets.tarkov.dev/58aeac1b86f77457c419f475-image.jpg",
                    MarketLink = "https://tarkov.dev/item/mpx-sd-9x19-integrated-sound-suppressor",
                    Name = "MPX-SD 9x19 integrated sound suppressor",
                    RecoilPercentageModifier = -0.15,
                    ShortName = "MPX-SD",
                    Weight = 0.6,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/MPX-SD_9x19_integrated_sound_suppressor"
                },
                new RangedWeaponMod()
                {
                    CategoryId = "rangedWeaponMod",
                    IconLink = "https://assets.tarkov.dev/59d36a0086f7747e673f3946-icon.jpg",
                    Id = "59d36a0086f7747e673f3946",
                    ImageLink = "https://assets.tarkov.dev/59d36a0086f7747e673f3946-image.jpg",
                    MarketLink = "https://tarkov.dev/item/aks-74u-gas-tube-6p26-sb1-2",
                    ModSlots = new ModSlot[]
                    {
                        new ModSlot()
                        {
                            CompatibleItemIds = new string[]
                            {
                                "5d15ce51d7ad1a1eff619092",
                                "5a957c3fa2750c00137fa5f7",
                                "57dc32dc245977596d4ef3d3",
                                "57ffa9f4245977728561e844"
                            },
                            Name = "mod_handguard"
                        }
                    },
                    Name = "AKS-74U gas tube (6P26 Sb.1-2)",
                    ShortName = "6P26 Sb.1-2",
                    Weight = 0.03,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/AKS-74U_gas_tube_(6P26_Sb.1-2)"
                }
            };

            // Act
            string result = Serialize(containers);

            // Assert
            result.Should().Be("[{\"ac\":-0.01,\"e\":-5,\"r\":-0.15,\"c\":\"rangedWeaponMod\",\"ic\":\"https://assets.tarkov.dev/58aeac1b86f77457c419f475-icon.jpg\",\"i\":\"58aeac1b86f77457c419f475\",\"im\":\"https://assets.tarkov.dev/58aeac1b86f77457c419f475-image.jpg\",\"m\":\"https://tarkov.dev/item/mpx-sd-9x19-integrated-sound-suppressor\",\"n\":\"MPX-SD 9x19 integrated sound suppressor\",\"s\":\"MPX-SD\",\"w\":0.6,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/MPX-SD_9x19_integrated_sound_suppressor\"},{\"mo\":[{\"i\":[\"5d15ce51d7ad1a1eff619092\",\"5a957c3fa2750c00137fa5f7\",\"57dc32dc245977596d4ef3d3\",\"57ffa9f4245977728561e844\"],\"n\":\"mod_handguard\"}],\"c\":\"rangedWeaponMod\",\"ic\":\"https://assets.tarkov.dev/59d36a0086f7747e673f3946-icon.jpg\",\"i\":\"59d36a0086f7747e673f3946\",\"im\":\"https://assets.tarkov.dev/59d36a0086f7747e673f3946-image.jpg\",\"m\":\"https://tarkov.dev/item/aks-74u-gas-tube-6p26-sb1-2\",\"n\":\"AKS-74U gas tube (6P26 Sb.1-2)\",\"s\":\"6P26 Sb.1-2\",\"w\":0.03,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/AKS-74U_gas_tube_(6P26_Sb.1-2)\"}]");
        }
    }
}
