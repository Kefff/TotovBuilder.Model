using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="BackpackJsonConverter"/> class.
    /// </summary>
    public class BackpackJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeBackpack()
        {
            // Arrange
            Backpack[] containers =
            [
                new Backpack()
                {
                    Capacity = 35,
                    CategoryId = "backpack",
                    ErgonomicsModifierPercentage = -0.07,
                    IconLink = "https://assets.tarkov.dev/5ab8ebf186f7742d8b372e80-icon.webp",
                    Id = "5ab8ebf186f7742d8b372e80",
                    ImageLink = "https://assets.tarkov.dev/5ab8ebf186f7742d8b372e80-image.webp",
                    MarketLink = "https://tarkov.dev/item/sso-attack-2-raid-backpack",
                    MovementSpeedModifierPercentage = -0.05,
                    Name = "SSO Attack 2 raid backpack",
                    ShortName = "Attack 2",
                    TurningSpeedModifierPercentage = -0.03,
                    Weight = 2.8,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/SSO_Attack_2_raid_backpack"
                },
                new Backpack()
                {
                    CategoryId = "backpack",
                    IconLink = "https://assets.tarkov.dev/5ab8f04f86f774585f4237d8-icon.webp",
                    Id = "5ab8f04f86f774585f4237d8",
                    ImageLink = "https://assets.tarkov.dev/5ab8f04f86f774585f4237d8-image.webp",
                    MarketLink = "https://tarkov.dev/item/tactical-sling-bag",
                    Name = "Tactical sling bag",
                    ShortName = "Sling",
                    Weight = 0.48,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Tactical_sling_bag"
                }
            ];

            // Act
            string result = Serialize(containers);

            // Assert
            result.Should().Be("[{\"ca\":35,\"e\":-0.07,\"ms\":-0.05,\"t\":-0.03,\"c\":\"backpack\",\"ic\":\"https://assets.tarkov.dev/5ab8ebf186f7742d8b372e80-icon.webp\",\"i\":\"5ab8ebf186f7742d8b372e80\",\"im\":\"https://assets.tarkov.dev/5ab8ebf186f7742d8b372e80-image.webp\",\"m\":\"https://tarkov.dev/item/sso-attack-2-raid-backpack\",\"n\":\"SSO Attack 2 raid backpack\",\"s\":\"Attack 2\",\"w\":2.8,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/SSO_Attack_2_raid_backpack\"},{\"c\":\"backpack\",\"ic\":\"https://assets.tarkov.dev/5ab8f04f86f774585f4237d8-icon.webp\",\"i\":\"5ab8f04f86f774585f4237d8\",\"im\":\"https://assets.tarkov.dev/5ab8f04f86f774585f4237d8-image.webp\",\"m\":\"https://tarkov.dev/item/tactical-sling-bag\",\"n\":\"Tactical sling bag\",\"s\":\"Sling\",\"w\":0.48,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Tactical_sling_bag\"}]");
        }
    }
}
