using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="MagazineJsonConverter"/> class.
    /// </summary>
    public class MagazineJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeMagazine()
        {
            // Arrange
            Magazine[] containers =
            [
                new Magazine()
                {
                    AcceptedAmmunitionIds =
                    [
                        "5e81f423763d9f754677bf2e",
                        "5efb0cabfb3e451d70735af5",
                        "5efb0fc6aeb21837e749c801",
                        "5efb0d4f4bc50b58e81710f3",
                        "5ea2a8e200685063ec28c05a"
                    ],
                    Capacity = 7,
                    CategoryId = "magazine",
                    CheckSpeedModifierPercentage = -0.2,
                    ErgonomicsModifier = -1,
                    IconLink = "https://assets.tarkov.dev/5e81c4ca763d9f754677befa-icon.jpg",
                    Id = "5e81c4ca763d9f754677befa",
                    ImageLink = "https://assets.tarkov.dev/5e81c4ca763d9f754677befa-image.jpg",
                    LoadSpeedModifierPercentage = -0.25,
                    MalfunctionPercentage = 0.04,
                    MarketLink = "https://tarkov.dev/item/m1911a1-45-acp-7-round-magazine",
                    Name = "M1911A1 .45 ACP 7-round magazine",
                    ShortName = "1911",
                    Weight = 0.16,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/M1911A1_.45_ACP_7-round_magazine"
                },
                new Magazine()
                {
                    AcceptedAmmunitionIds =
                    [
                        "5ede474b0c226a66f5402622",
                        "5ede475b549eed7c6d5c18fb",
                        "5ede4739e0350d05467f73e8",
                        "5f0c892565703e5c461894e9",
                        "5ede47405b097655935d7d16",
                        "5ede475339ee016e8c534742"
                    ],
                    CategoryId = "magazine",
                    ErgonomicsModifier = -10,
                    IconLink = "https://assets.tarkov.dev/627bce33f21bc425b06ab967-icon.webp",
                    Id = "627bce33f21bc425b06ab967",
                    ImageLink = "https://assets.tarkov.dev/627bce33f21bc425b06ab967-image.webp",
                    MarketLink = "https://tarkov.dev/item/m32a1-40mm-cylinder",
                    ModSlots =
                    [
                        new ModSlot()
                        {
                            CompatibleItemIds =
                            [
                                "5ede474b0c226a66f5402622",
                                "5ede475b549eed7c6d5c18fb",
                                "5ede4739e0350d05467f73e8",
                                "5f0c892565703e5c461894e9",
                                "5ede47405b097655935d7d16",
                                "5ede475339ee016e8c534742"
                            ],
                            Name = "camora_000"
                        },
                        new ModSlot()
                        {
                            CompatibleItemIds =
                            [
                                "5ede474b0c226a66f5402622",
                                "5ede475b549eed7c6d5c18fb",
                                "5ede4739e0350d05467f73e8",
                                "5f0c892565703e5c461894e9",
                                "5ede47405b097655935d7d16",
                                "5ede475339ee016e8c534742"
                            ],
                            Name = "camora_001"
                        },
                        new ModSlot()
                        {
                            CompatibleItemIds =
                            [
                                "5ede474b0c226a66f5402622",
                                "5ede475b549eed7c6d5c18fb",
                                "5ede4739e0350d05467f73e8",
                                "5f0c892565703e5c461894e9",
                                "5ede47405b097655935d7d16",
                                "5ede475339ee016e8c534742"
                            ],
                            Name = "camora_002"
                        },
                        new ModSlot()
                        {
                            CompatibleItemIds =
                            [
                                "5ede474b0c226a66f5402622",
                                "5ede475b549eed7c6d5c18fb",
                                "5ede4739e0350d05467f73e8",
                                "5f0c892565703e5c461894e9",
                                "5ede47405b097655935d7d16",
                                "5ede475339ee016e8c534742"
                            ],
                            Name = "camora_003"
                        },
                        new ModSlot()
                        {
                            CompatibleItemIds =
                            [
                                "5ede474b0c226a66f5402622",
                                "5ede475b549eed7c6d5c18fb",
                                "5ede4739e0350d05467f73e8",
                                "5f0c892565703e5c461894e9",
                                "5ede47405b097655935d7d16",
                                "5ede475339ee016e8c534742"
                            ],
                            Name = "camora_004"
                        },
                        new ModSlot()
                        {
                            CompatibleItemIds =
                            [
                                "5ede474b0c226a66f5402622",
                                "5ede475b549eed7c6d5c18fb",
                                "5ede4739e0350d05467f73e8",
                                "5f0c892565703e5c461894e9",
                                "5ede47405b097655935d7d16",
                                "5ede475339ee016e8c534742"
                            ],
                            Name = "camora_005"
                        }
                    ],
                    Name = "M32A1 40mm cylinder",
                    ShortName = "MSGL",
                    Weight = 0.8,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/M32A1_40mm_cylinder"
                }
            ];

            // Act
            string result = Serialize(containers);

            // Assert
            result.Should().Be("[{\"aa\":[\"5e81f423763d9f754677bf2e\",\"5efb0cabfb3e451d70735af5\",\"5efb0fc6aeb21837e749c801\",\"5efb0d4f4bc50b58e81710f3\",\"5ea2a8e200685063ec28c05a\"],\"ca\":7,\"cs\":-0.2,\"e\":-1,\"l\":-0.25,\"ma\":0.04,\"c\":\"magazine\",\"ic\":\"https://assets.tarkov.dev/5e81c4ca763d9f754677befa-icon.jpg\",\"i\":\"5e81c4ca763d9f754677befa\",\"im\":\"https://assets.tarkov.dev/5e81c4ca763d9f754677befa-image.jpg\",\"m\":\"https://tarkov.dev/item/m1911a1-45-acp-7-round-magazine\",\"n\":\"M1911A1 .45 ACP 7-round magazine\",\"s\":\"1911\",\"w\":0.16,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/M1911A1_.45_ACP_7-round_magazine\"},{\"aa\":[\"5ede474b0c226a66f5402622\",\"5ede475b549eed7c6d5c18fb\",\"5ede4739e0350d05467f73e8\",\"5f0c892565703e5c461894e9\",\"5ede47405b097655935d7d16\",\"5ede475339ee016e8c534742\"],\"e\":-10,\"mo\":[{\"i\":[\"5ede474b0c226a66f5402622\",\"5ede475b549eed7c6d5c18fb\",\"5ede4739e0350d05467f73e8\",\"5f0c892565703e5c461894e9\",\"5ede47405b097655935d7d16\",\"5ede475339ee016e8c534742\"],\"n\":\"camora_000\"},{\"i\":[\"5ede474b0c226a66f5402622\",\"5ede475b549eed7c6d5c18fb\",\"5ede4739e0350d05467f73e8\",\"5f0c892565703e5c461894e9\",\"5ede47405b097655935d7d16\",\"5ede475339ee016e8c534742\"],\"n\":\"camora_001\"},{\"i\":[\"5ede474b0c226a66f5402622\",\"5ede475b549eed7c6d5c18fb\",\"5ede4739e0350d05467f73e8\",\"5f0c892565703e5c461894e9\",\"5ede47405b097655935d7d16\",\"5ede475339ee016e8c534742\"],\"n\":\"camora_002\"},{\"i\":[\"5ede474b0c226a66f5402622\",\"5ede475b549eed7c6d5c18fb\",\"5ede4739e0350d05467f73e8\",\"5f0c892565703e5c461894e9\",\"5ede47405b097655935d7d16\",\"5ede475339ee016e8c534742\"],\"n\":\"camora_003\"},{\"i\":[\"5ede474b0c226a66f5402622\",\"5ede475b549eed7c6d5c18fb\",\"5ede4739e0350d05467f73e8\",\"5f0c892565703e5c461894e9\",\"5ede47405b097655935d7d16\",\"5ede475339ee016e8c534742\"],\"n\":\"camora_004\"},{\"i\":[\"5ede474b0c226a66f5402622\",\"5ede475b549eed7c6d5c18fb\",\"5ede4739e0350d05467f73e8\",\"5f0c892565703e5c461894e9\",\"5ede47405b097655935d7d16\",\"5ede475339ee016e8c534742\"],\"n\":\"camora_005\"}],\"c\":\"magazine\",\"ic\":\"https://assets.tarkov.dev/627bce33f21bc425b06ab967-icon.webp\",\"i\":\"627bce33f21bc425b06ab967\",\"im\":\"https://assets.tarkov.dev/627bce33f21bc425b06ab967-image.webp\",\"m\":\"https://tarkov.dev/item/m32a1-40mm-cylinder\",\"n\":\"M32A1 40mm cylinder\",\"s\":\"MSGL\",\"w\":0.8,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/M32A1_40mm_cylinder\"}]");
        }
    }
}
