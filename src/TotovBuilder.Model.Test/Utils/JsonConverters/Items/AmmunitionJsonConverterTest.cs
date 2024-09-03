using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="AmmunitionJsonConverter"/> class.
    /// </summary>
    public class AmmunitionJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeAmmunition()
        {
            // Arrange
            Ammunition[] ammunitions =
            [
                new Ammunition()
                {
                    AccuracyModifierPercentage = 0,
                    ArmorDamagePercentage = 0,
                    ArmorPenetrations = [0, 0, 0, 0, 0, 0],
                    Blinding = true,
                    Caliber = "unknown",
                    CategoryId = "ammunition",
                    DurabilityBurnModifierPercentage = 0,
                    FleshDamage = 0,
                    FragmentationChance = 0,
                    HeavyBleedingChance = 0,
                    IconLink = "https://assets.tarkov.dev/unknown-icon.jpg",
                    Id = "unknown",
                    ImageLink = "https://assets.tarkov.dev/unknown-image.jpg",
                    LightBleedingChance = 0,
                    MarketLink = "https://tarkov.dev/item/unknown",
                    MaxStackableAmount = 60,
                    Name = "Unknown",
                    PenetrationPower = 0,
                    Projectiles = 2,
                    RecoilModifier = 0,
                    ShortName = "U",
                    Velocity = 365,
                    Weight = 0.01,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/unknown"
                },
                new Ammunition()
                {
                    AccuracyModifierPercentage = 0,
                    ArmorDamagePercentage = 0.34,
                    ArmorPenetrations = [6, 3, 0, 0, 0, 0],
                    Caliber = "Caliber545x39",
                    CategoryId = "ammunition",
                    DurabilityBurnModifierPercentage = -0.2,
                    FleshDamage = 65,
                    FragmentationChance = 0.1,
                    HeavyBleedingChance = 0,
                    IconLink = "https://assets.tarkov.dev/56dff4ecd2720b5f5a8b4568-icon.jpg",
                    Id = "56dff4ecd2720b5f5a8b4568",
                    ImageLink = "https://assets.tarkov.dev/56dff4ecd2720b5f5a8b4568-image.jpg",
                    LightBleedingChance = 0,
                    MarketLink = "https://tarkov.dev/item/545x39mm-us-gs",
                    MaxStackableAmount = 60,
                    Name = "5.45x39mm US gs",
                    PenetrationPower = 15,
                    Projectiles = 1,
                    RecoilModifier = -25,
                    ShortName = "US",
                    Subsonic = true,
                    Tracer = false,
                    Velocity = 303,
                    Weight = 0.01,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/5.45x39mm_US_gs"
                },
                new Ammunition()
                {
                    AccuracyModifierPercentage = -0.05,
                    ArmorDamagePercentage = 0.33,
                    ArmorPenetrations = [6, 3, 1, 0, 0, 0],
                    Caliber = "Caliber9x19PARA",
                    CategoryId = "ammunition",
                    DurabilityBurnModifierPercentage = 0.15,
                    FleshDamage = 58,
                    FragmentationChance = 0.15,
                    HeavyBleedingChance = 0,
                    IconLink = "https://assets.tarkov.dev/5c3df7d588a4501f290594e5-icon.webp",
                    Id = "5c3df7d588a4501f290594e5",
                    ImageLink = "https://assets.tarkov.dev/5c3df7d588a4501f290594e5-image.webp",
                    LightBleedingChance = 0,
                    MarketLink = "https://tarkov.dev/item/9x19mm-green-tracer",
                    MaxStackableAmount = 50,
                    Name = "9x19mm Green Tracer",
                    PenetrationPower = 14,
                    Projectiles = 1,
                    RecoilModifier = -6,
                    ShortName = "GT",
                    Subsonic = false,
                    Tracer = true,
                    Velocity = 365,
                    Weight = 0.006,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/9x19mm_Green_Tracer"
                }
            ];

            // Act
            string result = Serialize(ammunitions);

            // Assert
            result.Should().Be("[{\"b\":1,\"ca\":\"unknown\",\"p\":2,\"v\":365,\"c\":\"ammunition\",\"ic\":\"https://assets.tarkov.dev/unknown-icon.jpg\",\"i\":\"unknown\",\"im\":\"https://assets.tarkov.dev/unknown-image.jpg\",\"a\":60,\"m\":\"https://tarkov.dev/item/unknown\",\"n\":\"Unknown\",\"s\":\"U\",\"w\":0.01,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/unknown\"},{\"ad\":0.34,\"ap\":[6,3,0,0,0,0],\"ca\":\"Caliber545x39\",\"d\":-0.2,\"f\":65,\"fr\":0.1,\"pp\":15,\"r\":-25,\"su\":1,\"v\":303,\"c\":\"ammunition\",\"ic\":\"https://assets.tarkov.dev/56dff4ecd2720b5f5a8b4568-icon.jpg\",\"i\":\"56dff4ecd2720b5f5a8b4568\",\"im\":\"https://assets.tarkov.dev/56dff4ecd2720b5f5a8b4568-image.jpg\",\"a\":60,\"m\":\"https://tarkov.dev/item/545x39mm-us-gs\",\"n\":\"5.45x39mm US gs\",\"s\":\"US\",\"w\":0.01,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/5.45x39mm_US_gs\"},{\"ac\":-0.05,\"ad\":0.33,\"ap\":[6,3,1,0,0,0],\"ca\":\"Caliber9x19PARA\",\"d\":0.15,\"f\":58,\"fr\":0.15,\"pp\":14,\"r\":-6,\"t\":1,\"v\":365,\"c\":\"ammunition\",\"ic\":\"https://assets.tarkov.dev/5c3df7d588a4501f290594e5-icon.webp\",\"i\":\"5c3df7d588a4501f290594e5\",\"im\":\"https://assets.tarkov.dev/5c3df7d588a4501f290594e5-image.webp\",\"a\":50,\"m\":\"https://tarkov.dev/item/9x19mm-green-tracer\",\"n\":\"9x19mm Green Tracer\",\"s\":\"GT\",\"w\":0.006,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/9x19mm_Green_Tracer\"}]");
        }
    }
}
