using System;
using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="ArmorModJsonConverter"/> class.
    /// </summary>
    public class ArmorModJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeArmorMod()
        {
            // Arrange
            ArmorMod[] armorMods = new ArmorMod[]
            {
                new ArmorMod()
                {
                    ArmorClass = 6,
                    ArmoredAreas = new string[]
                    {
                        "TopOfTheHead",
                        "Nape"
                    },
                    BlindnessProtectionPercentage = 0,
                    ConflictingItemIds = new string[]
                    {
                        "5a16ba61fcdbcb098008728a",
                        "5a16b672fcdbcb001912fa83",
                        "5a16b7e1fcdbcb00165aa6c9",
                        "5aa7e3abe5b5b000171d064d",
                        "5c0e66e2d174af02a96252f4",
                        "5e00cdd986f7747473332240"
                    },
                    CategoryId = "armorMod",
                    Durability = 40,
                    ErgonomicsPercentageModifier = -0.05,
                    IconLink = "https://assets.tarkov.dev/5ea18c84ecf1982c7712d9a2-icon.webp",
                    Id = "5ea18c84ecf1982c7712d9a2",
                    ImageLink = "https://assets.tarkov.dev/5ea18c84ecf1982c7712d9a2-image.webp",
                    MarketLink = "https://tarkov.dev/item/diamond-age-bastion-helmet-armor-plate",
                    Material = "Ceramic",
                    ModSlots = new ModSlot[]
                    {
                        new ModSlot()
                        {
                            CompatibleItemIds = new string[]
                            {
                                "5c0558060db834001b735271",
                                "5a16b8a9fcdbcb00165aa6ca"
                            },
                            MaxStackableAmount = 1,
                            Name = "mod_nvg",
                            Required = false
                        }
                    },
                    MovementSpeedPercentageModifier = 0,
                    Name = "Diamond Age Bastion helmet armor plate",
                    //RicochetChance = , // TODO : MISSING FROM API
                    ShortName = "Bastion plate",
                    TurningSpeedPercentageModifier = -0.06,
                    Weight = 0.99,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Diamond_Age_Bastion_helmet_armor_plate",
                },
                new ArmorMod()
                {
                    ArmorClass = 3,
                    ArmoredAreas = new string[]
                    {
                        "Eyes",
                        "Jaws"
                    },
                    BlindnessProtectionPercentage = 0.1,
                    CategoryId = "armorMod",
                    ConflictingItemIds = new string[]
                    {
                        "5c0e66e2d174af02a96252f4",
                        "5c0696830db834001d23f5da",
                        "5c066e3a0db834001b7353f0",
                        "5c0558060db834001b735271",
                        "57235b6f24597759bf5a30f1",
                        "5c110624d174af029e69734c",
                        "5a16b8a9fcdbcb00165aa6ca"
                    },
                    Durability = 40,
                    ErgonomicsPercentageModifier = -0.08,
                    IconLink = "https://assets.tarkov.dev/5a16b7e1fcdbcb00165aa6c9-icon.jpg",
                    Id = "5a16b7e1fcdbcb00165aa6c9",
                    ImageLink = "https://assets.tarkov.dev/5a16b7e1fcdbcb00165aa6c9-image.jpg",
                    MarketLink = "https://tarkov.dev/item/ops-core-fast-multi-hit-ballistic-face-shield",
                    Material = "Glass",
                    ModSlots = Array.Empty<ModSlot>(),
                    MovementSpeedPercentageModifier = 0,
                    Name = "Ops-Core FAST multi-hit ballistic face shield",
                    //RicochetChance = , // TODO : MISSING FROM API
                    ShortName = "FAST FS",
                    TurningSpeedPercentageModifier = -0.08,
                    Weight = 1.2,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Ops-Core_FAST_multi-hit_ballistic_face_shield",
                }
            };

            // Act
            string result = Serialize(armorMods);

            // Assert
            result.Should().Be("[{\"ac\":6,\"aa\":[\"TopOfTheHead\",\"Nape\"],\"d\":40,\"e\":-0.05,\"ma\":\"Ceramic\",\"mo\":[{\"i\":[\"5c0558060db834001b735271\",\"5a16b8a9fcdbcb00165aa6ca\"],\"n\":\"mod_nvg\"}],\"t\":-0.06,\"c\":\"armorMod\",\"co\":[\"5a16ba61fcdbcb098008728a\",\"5a16b672fcdbcb001912fa83\",\"5a16b7e1fcdbcb00165aa6c9\",\"5aa7e3abe5b5b000171d064d\",\"5c0e66e2d174af02a96252f4\",\"5e00cdd986f7747473332240\"],\"ic\":\"https://assets.tarkov.dev/5ea18c84ecf1982c7712d9a2-icon.webp\",\"i\":\"5ea18c84ecf1982c7712d9a2\",\"im\":\"https://assets.tarkov.dev/5ea18c84ecf1982c7712d9a2-image.webp\",\"m\":\"https://tarkov.dev/item/diamond-age-bastion-helmet-armor-plate\",\"n\":\"Diamond Age Bastion helmet armor plate\",\"s\":\"Bastion plate\",\"w\":0.99,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Diamond_Age_Bastion_helmet_armor_plate\"},{\"ac\":3,\"aa\":[\"Eyes\",\"Jaws\"],\"bp\":0.1,\"d\":40,\"e\":-0.08,\"ma\":\"Glass\",\"t\":-0.08,\"c\":\"armorMod\",\"co\":[\"5c0e66e2d174af02a96252f4\",\"5c0696830db834001d23f5da\",\"5c066e3a0db834001b7353f0\",\"5c0558060db834001b735271\",\"57235b6f24597759bf5a30f1\",\"5c110624d174af029e69734c\",\"5a16b8a9fcdbcb00165aa6ca\"],\"ic\":\"https://assets.tarkov.dev/5a16b7e1fcdbcb00165aa6c9-icon.jpg\",\"i\":\"5a16b7e1fcdbcb00165aa6c9\",\"im\":\"https://assets.tarkov.dev/5a16b7e1fcdbcb00165aa6c9-image.jpg\",\"m\":\"https://tarkov.dev/item/ops-core-fast-multi-hit-ballistic-face-shield\",\"n\":\"Ops-Core FAST multi-hit ballistic face shield\",\"s\":\"FAST FS\",\"w\":1.2,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Ops-Core_FAST_multi-hit_ballistic_face_shield\"}]");
        }
    }
}
