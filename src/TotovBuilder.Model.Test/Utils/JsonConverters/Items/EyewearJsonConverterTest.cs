using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="EyewearJsonConverter"/> class.
    /// </summary>
    public class EyewearJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeEyewear()
        {
            // Arrange
            Eyewear[] eyewears =
            [
                new Eyewear()
                {
                    BlindnessProtectionPercentage = 0.1,
                    CategoryId = "eyewear",
                    IconLink = "https://assets.tarkov.dev/5b432be65acfc433000ed01f-icon.webp",
                    Id = "5b432be65acfc433000ed01f",
                    ImageLink = "https://assets.tarkov.dev/5b432be65acfc433000ed01f-image.webp",
                    MarketLink = "https://tarkov.dev/item/6b34-anti-fragmentation-glasses",
                    Material = "UHMWPE",
                    Name = "6B34 anti-fragmentation glasses",
                    ShortName = "6B34",
                    Weight = 0.12,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/6B34_anti-fragmentation_glasses"
                },
                new Eyewear()
                {
                    ArmorClass = 1,
                    BlindnessProtectionPercentage = 0.1,
                    CategoryId = "eyewear",
                    Durability = 25,
                    IconLink = "https://assets.tarkov.dev/603409c80ca681766b6a0fb2-icon.webp",
                    Id = "603409c80ca681766b6a0fb2",
                    ImageLink = "https://assets.tarkov.dev/603409c80ca681766b6a0fb2-image.webp",
                    MarketLink = "https://tarkov.dev/item/npp-klass-condor-glasses",
                    Material = "Glass",
                    Name = "NPP KlASS Condor glasses",
                    ShortName = "Condor",
                    Weight = 0.03,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/NPP_KlASS_Condor_glasses"
                },
            ];

            // Act
            string result = Serialize(eyewears);

            // Assert
            result.Should().Be("[{\"bp\":0.1,\"ma\":\"UHMWPE\",\"c\":\"eyewear\",\"ic\":\"https://assets.tarkov.dev/5b432be65acfc433000ed01f-icon.webp\",\"i\":\"5b432be65acfc433000ed01f\",\"im\":\"https://assets.tarkov.dev/5b432be65acfc433000ed01f-image.webp\",\"m\":\"https://tarkov.dev/item/6b34-anti-fragmentation-glasses\",\"n\":\"6B34 anti-fragmentation glasses\",\"s\":\"6B34\",\"w\":0.12,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/6B34_anti-fragmentation_glasses\"},{\"ac\":1,\"bp\":0.1,\"d\":25,\"ma\":\"Glass\",\"c\":\"eyewear\",\"ic\":\"https://assets.tarkov.dev/603409c80ca681766b6a0fb2-icon.webp\",\"i\":\"603409c80ca681766b6a0fb2\",\"im\":\"https://assets.tarkov.dev/603409c80ca681766b6a0fb2-image.webp\",\"m\":\"https://tarkov.dev/item/npp-klass-condor-glasses\",\"n\":\"NPP KlASS Condor glasses\",\"s\":\"Condor\",\"w\":0.03,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/NPP_KlASS_Condor_glasses\"}]");
        }
    }
}
