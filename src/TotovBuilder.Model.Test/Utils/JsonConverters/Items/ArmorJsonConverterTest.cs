using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="ArmorJsonConverter"/> class.
    /// </summary>
    public class ArmorJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeArmor()
        {
            // Arrange
            Armor[] armors =
            [
                new Armor()
                {
                    CategoryId = "armor",
                    IconLink = "https://assets.tarkov.dev/unknown-icon.jpg",
                    Id = "unknown",
                    ImageLink = "https://assets.tarkov.dev/unknown-image.jpg",
                    MarketLink = "https://tarkov.dev/item/unknown",
                    Name = "Unknown",
                    ShortName = "Unknown",
                    Weight = 0.2,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Unknown"
                },
                new Armor()
                {
                    ArmorClass = 3,
                    ArmoredAreas =
                    [
                        "FRPLATE",
                        "BCKPLATE",
                        "LPLATE",
                        "RPLATE",
                        "Chest",
                        "Stomach",
                        "StomachLowerBack",
                        "ThoraxUpperBack",
                        "StomachLeftSide",
                        "StomachRightSide",
                        "HeadNeck",
                        "HeadThroat",
                        "LeftArmShoulder",
                        "RightArmShoulder",
                        "StomachGroin"
                    ],
                    CategoryId = "armor",
                    DefaultPresetId = "65766adc234b9f6e050a431a",
                    Durability = 350,
                    ErgonomicsModifierPercentage = -0.1,
                    IconLink = "https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-icon.webp",
                    Id = "545cdb794bdc2d3a198b456a",
                    ImageLink = "https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-image.webp",
                    MarketLink = "https://tarkov.dev/item/6b43-zabralo-sh-body-armor-digital-flora",
                    Material = "Aramid",
                    ModSlots =
                    [
                        new ModSlot()
                        {
                            Caption = null, // TODO : MISSING FROM API
                            CompatibleItemIds =
                            [
                                "656f9d5900d62bcd2e02407c",
                                "656fa8d700d62bcd2e024084",
                                "656fa99800d62bcd2e024088",
                                "656fae5f7c2d57afe200c0d7",
                                "656faf0ca0dce000a2020f77",
                                "656fa0fb498d1b7e3e071d9c",
                                "656fafe3498d1b7e3e071da4",
                                "656fa76500d62bcd2e024080",
                                "656fa25e94b480b8a500c0e0",
                                "656fad8c498d1b7e3e071da0",
                                "656fa61e94b480b8a500c0e8",
                                "656fb21fa0dce000a2020f7c",
                                "656fac30c6baea13cd07e10c",
                                "656f9fa0498d1b7e3e071d98",
                                "656fb0bd7c2d57afe200c0dc",
                                "656fa53d94b480b8a500c0e4",
                                "65573fa5655447403702a816",
                                "64afc71497cf3a403c01ff38",
                                "655746010177119f4a097ff7",
                                "64afdcb83efdfea28601d041"
                            ],
                            Name = "front_plate",
                        },
                        new ModSlot()
                        {
                            Caption = null, // TODO : MISSING FROM API
                            CompatibleItemIds =
                            [
                                "656f9d5900d62bcd2e02407c",
                                "656fa8d700d62bcd2e024084",
                                "656fa99800d62bcd2e024088",
                                "656fae5f7c2d57afe200c0d7",
                                "656faf0ca0dce000a2020f77",
                                "656fa0fb498d1b7e3e071d9c",
                                "656fafe3498d1b7e3e071da4",
                                "656fa76500d62bcd2e024080",
                                "656fa25e94b480b8a500c0e0",
                                "656fa61e94b480b8a500c0e8",
                                "656fad8c498d1b7e3e071da0",
                                "656fb21fa0dce000a2020f7c",
                                "656fac30c6baea13cd07e10c",
                                "656f9fa0498d1b7e3e071d98",
                                "656fb0bd7c2d57afe200c0dc",
                                "656fa53d94b480b8a500c0e4",
                                "65573fa5655447403702a816",
                                "64afc71497cf3a403c01ff38",
                                "655746010177119f4a097ff7",
                                "64afdcb83efdfea28601d041"
                            ],
                            Name = "back_plate"
                        },
                        new ModSlot()
                        {
                            Caption = null, // TODO : MISSING FROM API
                            CompatibleItemIds =
                            [
                                "64afd81707e2cf40e903a316",
                                "6557458f83942d705f0c4962",
                                "64afdb577bb3bfe8fe03fd1d"
                            ],
                            Name = "left_side_plate",
                        },
                        new ModSlot()
                        {
                            Caption = null, // TODO : MISSING FROM API
                            CompatibleItemIds =
                            [
                                "6557458f83942d705f0c4962",
                                "64afdb577bb3bfe8fe03fd1d",
                                "64afd81707e2cf40e903a316"
                            ],
                            Name = "right_side_plate",
                        }
                    ],
                    MovementSpeedModifierPercentage = -0.115,
                    Name = "6B43 Zabralo-Sh body armor (Digital Flora)",
                    ShortName = "6B43",
                    TurningSpeedModifierPercentage = -0.055,
                    Weight = 10.8,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/6B43_Zabralo-Sh_body_armor_(Digital_Flora)"
                }
            ];

            // Act
            string result = Serialize(armors);

            // Assert
            result.Should().Be("[{\"c\":\"armor\",\"ic\":\"https://assets.tarkov.dev/unknown-icon.jpg\",\"i\":\"unknown\",\"im\":\"https://assets.tarkov.dev/unknown-image.jpg\",\"m\":\"https://tarkov.dev/item/unknown\",\"n\":\"Unknown\",\"s\":\"Unknown\",\"w\":0.2,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Unknown\"},{\"ac\":3,\"aa\":[\"FRPLATE\",\"BCKPLATE\",\"LPLATE\",\"RPLATE\",\"Chest\",\"Stomach\",\"StomachLowerBack\",\"ThoraxUpperBack\",\"StomachLeftSide\",\"StomachRightSide\",\"HeadNeck\",\"HeadThroat\",\"LeftArmShoulder\",\"RightArmShoulder\",\"StomachGroin\"],\"dp\":\"65766adc234b9f6e050a431a\",\"d\":350,\"e\":-0.1,\"ma\":\"Aramid\",\"mo\":[{\"i\":[\"656f9d5900d62bcd2e02407c\",\"656fa8d700d62bcd2e024084\",\"656fa99800d62bcd2e024088\",\"656fae5f7c2d57afe200c0d7\",\"656faf0ca0dce000a2020f77\",\"656fa0fb498d1b7e3e071d9c\",\"656fafe3498d1b7e3e071da4\",\"656fa76500d62bcd2e024080\",\"656fa25e94b480b8a500c0e0\",\"656fad8c498d1b7e3e071da0\",\"656fa61e94b480b8a500c0e8\",\"656fb21fa0dce000a2020f7c\",\"656fac30c6baea13cd07e10c\",\"656f9fa0498d1b7e3e071d98\",\"656fb0bd7c2d57afe200c0dc\",\"656fa53d94b480b8a500c0e4\",\"65573fa5655447403702a816\",\"64afc71497cf3a403c01ff38\",\"655746010177119f4a097ff7\",\"64afdcb83efdfea28601d041\"],\"n\":\"front_plate\"},{\"i\":[\"656f9d5900d62bcd2e02407c\",\"656fa8d700d62bcd2e024084\",\"656fa99800d62bcd2e024088\",\"656fae5f7c2d57afe200c0d7\",\"656faf0ca0dce000a2020f77\",\"656fa0fb498d1b7e3e071d9c\",\"656fafe3498d1b7e3e071da4\",\"656fa76500d62bcd2e024080\",\"656fa25e94b480b8a500c0e0\",\"656fa61e94b480b8a500c0e8\",\"656fad8c498d1b7e3e071da0\",\"656fb21fa0dce000a2020f7c\",\"656fac30c6baea13cd07e10c\",\"656f9fa0498d1b7e3e071d98\",\"656fb0bd7c2d57afe200c0dc\",\"656fa53d94b480b8a500c0e4\",\"65573fa5655447403702a816\",\"64afc71497cf3a403c01ff38\",\"655746010177119f4a097ff7\",\"64afdcb83efdfea28601d041\"],\"n\":\"back_plate\"},{\"i\":[\"64afd81707e2cf40e903a316\",\"6557458f83942d705f0c4962\",\"64afdb577bb3bfe8fe03fd1d\"],\"n\":\"left_side_plate\"},{\"i\":[\"6557458f83942d705f0c4962\",\"64afdb577bb3bfe8fe03fd1d\",\"64afd81707e2cf40e903a316\"],\"n\":\"right_side_plate\"}],\"ms\":-0.115,\"t\":-0.055,\"c\":\"armor\",\"ic\":\"https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-icon.webp\",\"i\":\"545cdb794bdc2d3a198b456a\",\"im\":\"https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-image.webp\",\"m\":\"https://tarkov.dev/item/6b43-zabralo-sh-body-armor-digital-flora\",\"n\":\"6B43 Zabralo-Sh body armor (Digital Flora)\",\"s\":\"6B43\",\"w\":10.8,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/6B43_Zabralo-Sh_body_armor_(Digital_Flora)\"}]");
        }
    }
}
