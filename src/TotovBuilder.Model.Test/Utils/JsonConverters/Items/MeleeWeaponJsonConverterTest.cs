using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="MeleeWeaponJsonConverter"/> class.
    /// </summary>
    public class MeleeWeaponJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeMeleeWeapon()
        {
            // Arrange
            MeleeWeapon[] containers =
            [
                new MeleeWeapon()
                {
                    CategoryId = "meleeWeapon",
                    ChopDamage = 29,
                    HitRadius = 0.6,
                    IconLink = "https://assets.tarkov.dev/5c0126f40db834002a125382-icon.webp",
                    Id = "5c0126f40db834002a125382",
                    ImageLink = "https://assets.tarkov.dev/5c0126f40db834002a125382-image.webp",
                    MarketLink = "https://tarkov.dev/item/red-rebel-ice-pick",
                    Name = "Red Rebel ice pick",
                    ShortName = "RedRebel",
                    StabDamage = 35,
                    Weight = 0.65,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Red_Rebel_ice_pick"
                }
            ];

            // Act
            string result = Serialize(containers);

            // Assert
            result.Should().Be("[{\"ch\":29,\"r\":0.6,\"st\":35,\"c\":\"meleeWeapon\",\"ic\":\"https://assets.tarkov.dev/5c0126f40db834002a125382-icon.webp\",\"i\":\"5c0126f40db834002a125382\",\"im\":\"https://assets.tarkov.dev/5c0126f40db834002a125382-image.webp\",\"m\":\"https://tarkov.dev/item/red-rebel-ice-pick\",\"n\":\"Red Rebel ice pick\",\"s\":\"RedRebel\",\"w\":0.65,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Red_Rebel_ice_pick\"}]");
        }
    }
}
