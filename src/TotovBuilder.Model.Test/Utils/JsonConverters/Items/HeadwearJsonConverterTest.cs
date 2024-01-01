using System;
using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="HeadwearJsonConverter"/> class.
    /// </summary>
    public class HeadwearJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeHeadwear()
        {
            // Arrange
            Headwear[] containers = new Headwear[]
            {
                new Headwear()
                {
                    ArmorClass = 4,
                    ArmoredAreas = new string[]
                    {
                        "Top",
                        "Nape"
                    },
                    BlocksHeadphones = true,
                    CategoryId = "headwear",
                    Deafening = "High",
                    Durability = 30,
                    ErgonomicsPercentageModifier = -0.06,
                    IconLink = "https://assets.tarkov.dev/5e4bfc1586f774264f7582d3-icon.jpg",
                    Id = "5e4bfc1586f774264f7582d3",
                    ImageLink = "https://assets.tarkov.dev/5e4bfc1586f774264f7582d3-image.jpg",
                    MarketLink = "https://tarkov.dev/item/msa-gallet-tc-800-high-cut-combat-helmet",
                    Material = "CombinedMaterials",
                    ModSlots = new ModSlot[]
                    {
                        new ModSlot()
                        {
                            CompatibleItemIds = new string[]
                            {
                                "5a16b672fcdbcb001912fa83",
                                "5a16b7e1fcdbcb00165aa6c9"
                            },
                            Name = "mod_equipment_000",
                            Required = false
                        },
                        new ModSlot()
                        {
                            CompatibleItemIds = new string[]
                            {
                                "5c0558060db834001b735271",
                                "5a16b8a9fcdbcb00165aa6ca"
                            },
                            Name = "mod_nvg",
                            Required = false
                        },
                        new ModSlot()
                        {
                            CompatibleItemIds = new string[]
                            {
                                "5a398b75c4a282000a51a266",
                                "5a398ab9c4a282000c5a9842"
                            },
                            Name = "mod_mount",
                            Required = false
                        }
                    },
                    MovementSpeedPercentageModifier = -0.02,
                    Name = "MSA Gallet TC 800 High Cut combat helmet",
                    RicochetChance = string.Empty,
                    ShortName = "TC 800",
                    TurningSpeedPercentageModifier = -0.08,
                    Weight = 1.17,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/MSA_Gallet_TC_800_High_Cut_combat_helmet"
                },
                new Headwear()
                {
                    ArmorClass = 0,
                    ArmoredAreas = Array.Empty<string>(),
                    CategoryId = "headwear",
                    Deafening = "None",
                    Durability = 0,
                    ErgonomicsPercentageModifier = 0,
                    IconLink = "https://assets.tarkov.dev/5bd073c986f7747f627e796c-icon.jpg",
                    Id = "5bd073c986f7747f627e796c",
                    ImageLink = "https://assets.tarkov.dev/5bd073c986f7747f627e796c-image.jpg",
                    MarketLink = "https://tarkov.dev/item/kotton-beanie",
                    Material = string.Empty,
                    ModSlots = Array.Empty<ModSlot>(),
                    MovementSpeedPercentageModifier = 0,
                    Name = "Kotton beanie",
                    RicochetChance = string.Empty,
                    ShortName = "Kotton",
                    TurningSpeedPercentageModifier = 0,
                    Weight = 0.2,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Kotton_beanie"
                }
            };

            // Act
            string result = Serialize(containers);

            // Assert
            result.Should().Be("[{\"ac\":4,\"aa\":[\"Top\",\"Nape\"],\"h\":1,\"de\":\"High\",\"d\":30,\"e\":-0.06,\"ma\":\"CombinedMaterials\",\"mo\":[{\"i\":[\"5a16b672fcdbcb001912fa83\",\"5a16b7e1fcdbcb00165aa6c9\"],\"n\":\"mod_equipment_000\"},{\"i\":[\"5c0558060db834001b735271\",\"5a16b8a9fcdbcb00165aa6ca\"],\"n\":\"mod_nvg\"},{\"i\":[\"5a398b75c4a282000a51a266\",\"5a398ab9c4a282000c5a9842\"],\"n\":\"mod_mount\"}],\"ms\":-0.02,\"t\":-0.08,\"c\":\"headwear\",\"ic\":\"https://assets.tarkov.dev/5e4bfc1586f774264f7582d3-icon.jpg\",\"i\":\"5e4bfc1586f774264f7582d3\",\"im\":\"https://assets.tarkov.dev/5e4bfc1586f774264f7582d3-image.jpg\",\"m\":\"https://tarkov.dev/item/msa-gallet-tc-800-high-cut-combat-helmet\",\"n\":\"MSA Gallet TC 800 High Cut combat helmet\",\"s\":\"TC 800\",\"w\":1.17,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/MSA_Gallet_TC_800_High_Cut_combat_helmet\"},{\"c\":\"headwear\",\"ic\":\"https://assets.tarkov.dev/5bd073c986f7747f627e796c-icon.jpg\",\"i\":\"5bd073c986f7747f627e796c\",\"im\":\"https://assets.tarkov.dev/5bd073c986f7747f627e796c-image.jpg\",\"m\":\"https://tarkov.dev/item/kotton-beanie\",\"n\":\"Kotton beanie\",\"s\":\"Kotton\",\"w\":0.2,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Kotton_beanie\"}]");
        }
    }
}
