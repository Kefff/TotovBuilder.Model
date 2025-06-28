using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="GrenadeJsonConverter"/> class.
    /// </summary>
    public class GrenadeJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeGrenade()
        {
            // Arrange
            Grenade[] containers =
            [
                new Grenade()
                {
                    Blinding = true,
                    CategoryId = "grenade",
                    ExplosionDelay = 3,
                    FragmentsAmount = 100,
                    MaximumExplosionRange = 6,
                    MinimumExplosionRange = 2,
                    IconLink = "https://assets.tarkov.dev/5e32f56fcb6d5863cc5e5ee4-icon.jpg",
                    Id = "5e32f56fcb6d5863cc5e5ee4",
                    ImageLink = "https://assets.tarkov.dev/5e32f56fcb6d5863cc5e5ee4-image.jpg",
                    MarketLink = "https://tarkov.dev/item/vog-17-khattabka-improvised-hand-grenade",
                    Name = "VOG-17 Khattabka improvised hand grenade",
                    ShortName = "VOG-17",
                    Weight = 0.28,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/VOG-17_Khattabka_improvised_hand_grenade"
                },
                new Grenade()
                {
                    CategoryId = "grenade",
                    ExplosionDelay = 3.5,
                    IconLink = "https://assets.tarkov.dev/5a2a57cfc4a2826c6e06d44a-icon.webp",
                    Id = "5a2a57cfc4a2826c6e06d44a",
                    ImageLink = "https://assets.tarkov.dev/5a2a57cfc4a2826c6e06d44a-image.webp",
                    MarketLink = "https://tarkov.dev/item/rdg-2b-smoke-grenade",
                    Name = "RDG-2B smoke grenade",
                    ShortName = "RDG-2B",
                    Smoke = true,
                    Weight = 0.6,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/RDG-2B_smoke_grenade"
                },
                new Grenade()
                {
                    CategoryId = "grenade",
                    ExplosionDelay = 3.5,
                    FragmentsAmount = 85,
                    Impact = true,
                    MaximumExplosionRange = 7,
                    MinimumExplosionRange = 2,
                    IconLink = "https://assets.tarkov.dev/618a431df1eb8e24b8741deb-icon.webp",
                    Id = "618a431df1eb8e24b8741deb",
                    ImageLink = "https://assets.tarkov.dev/618a431df1eb8e24b8741deb-image.webp",
                    MarketLink = "https://tarkov.dev/item/rgo-hand-grenade",
                    Name = "RGO hand grenade",
                    ShortName = "RGO",
                    Weight = 0.53,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/RGO_hand_grenade"
                }
            ];

            // Act
            string result = Serialize(containers);

            // Assert
            result.Should().Be("[{\"b\":1,\"d\":3,\"f\":100,\"ma\":6,\"mi\":2,\"c\":\"grenade\",\"ic\":\"https://assets.tarkov.dev/5e32f56fcb6d5863cc5e5ee4-icon.jpg\",\"i\":\"5e32f56fcb6d5863cc5e5ee4\",\"im\":\"https://assets.tarkov.dev/5e32f56fcb6d5863cc5e5ee4-image.jpg\",\"m\":\"https://tarkov.dev/item/vog-17-khattabka-improvised-hand-grenade\",\"n\":\"VOG-17 Khattabka improvised hand grenade\",\"s\":\"VOG-17\",\"w\":0.28,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/VOG-17_Khattabka_improvised_hand_grenade\"},{\"d\":3.5,\"sm\":1,\"c\":\"grenade\",\"ic\":\"https://assets.tarkov.dev/5a2a57cfc4a2826c6e06d44a-icon.webp\",\"i\":\"5a2a57cfc4a2826c6e06d44a\",\"im\":\"https://assets.tarkov.dev/5a2a57cfc4a2826c6e06d44a-image.webp\",\"m\":\"https://tarkov.dev/item/rdg-2b-smoke-grenade\",\"n\":\"RDG-2B smoke grenade\",\"s\":\"RDG-2B\",\"w\":0.6,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/RDG-2B_smoke_grenade\"},{\"d\":3.5,\"f\":85,\"ip\":1,\"ma\":7,\"mi\":2,\"c\":\"grenade\",\"ic\":\"https://assets.tarkov.dev/618a431df1eb8e24b8741deb-icon.webp\",\"i\":\"618a431df1eb8e24b8741deb\",\"im\":\"https://assets.tarkov.dev/618a431df1eb8e24b8741deb-image.webp\",\"m\":\"https://tarkov.dev/item/rgo-hand-grenade\",\"n\":\"RGO hand grenade\",\"s\":\"RGO\",\"w\":0.53,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/RGO_hand_grenade\"}]");
        }
    }
}
