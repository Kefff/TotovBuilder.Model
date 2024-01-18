using System;
using FluentAssertions;
using TotovBuilder.Model.Items;
using Xunit;

namespace TotovBuilder.Model.Test.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents tests on the <see cref="RangedWeaponJsonConverter"/> class.
    /// </summary>
    public class RangedWeaponJsonConverterTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeRangedWeapon()
        {
            // Arrange
            RangedWeapon[] containers = new RangedWeapon[]
            {
                new RangedWeapon()
                {
                    BaseItemId = "57dc2fa62459775949412633",
                    Caliber = "Caliber545x39",
                    CategoryId = "mainWeapon",
                    DefaultPresetId = "584147732459775a2b6d9f12",
                    Ergonomics = 44,
                    FireModes = new string[] { "SingleFire", "FullAuto" },
                    FireRate = 650,
                    HorizontalRecoil = 445,
                    IconLink = "https://assets.tarkov.dev/584147732459775a2b6d9f12-icon.webp",
                    Id = "584147732459775a2b6d9f12",
                    ImageLink = "https://assets.tarkov.dev/584147732459775a2b6d9f12-image.webp",
                    MarketLink = "https://tarkov.dev/item/kalashnikov-aks-74u-545x39-assault-rifle-default",
                    ModSlots = Array.Empty<ModSlot>(),
                    Name = "Kalashnikov AKS-74U 5.45x39 assault rifle Default",
                    MinuteOfAngle = 3.44,
                    ShortName = "AKS-74U Default",
                    VerticalRecoil = 141,
                    Weight = 2.694,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Kalashnikov_AKS-74U_5.45x39_assault_rifle"
                },
                new RangedWeapon()
                {
                    Caliber = "Caliber545x39",
                    CategoryId = "mainWeapon",
                    DefaultPresetId = "584147732459775a2b6d9f12",
                    Ergonomics = 44,
                    FireModes = new string[] { "SingleFire", "FullAuto" },
                    FireRate = 650,
                    HorizontalRecoil = 445,
                    IconLink = "https://assets.tarkov.dev/57dc2fa62459775949412633-icon.jpg",
                    Id = "57dc2fa62459775949412633",
                    ImageLink = "https://assets.tarkov.dev/57dc2fa62459775949412633-image.jpg",
                    MarketLink = "https://tarkov.dev/item/kalashnikov-aks-74u-545x39-assault-rifle",
                    ModSlots = new ModSlot[]
                    {
                        new ModSlot()
                        {
                            CompatibleItemIds = new string[]
                            {
                                "5f6341043ada5942720e2dc5",
                                "6087e663132d4d12c81fd96b",
                                "5beec8ea0db834001a6f9dbf",
                                "5649ad3f4bdc2df8348b4585",
                                "5649ade84bdc2d1b2b8b4587",
                                "59e62cc886f77440d40b52a1",
                                "5a0071d486f77404e23a12b2",
                                "57e3dba62459770f0c32322b",
                                "5cf54404d7f00c108840b2ef",
                                "5e2192a498a36665e8337386",
                                "5b30ac585acfc433000eb79c",
                                "59e6318286f77444dd62c4cc",
                                "5cf50850d7f00c056e24104c",
                                "5cf508bfd7f00c056e24104e",
                                "5947f92f86f77427344a76b1",
                                "5947fa2486f77425b47c1a9b",
                                "5c6bf4aa2e2216001219b0ae",
                                "5649ae4a4bdc2d1b2b8b4588",
                                "5998517986f7746017232f7e",
                                "623c3be0484b5003161840dc",
                                "628c9ab845c59e5b80768a81",
                                "628a664bccaab13006640e47"
                            },
                            Name = "mod_pistol_grip",
                            Required = true
                        },
                        new ModSlot()
                        {
                            CompatibleItemIds = new string[]
                            {
                                "59ecc28286f7746d7a68aa8c",
                                "5ab626e4d8ce87272e4c6e43",
                                "57dc347d245977596754e7a1"
                            },
                            Name = "mod_stock",
                        },
                        new ModSlot()
                        {
                            CompatibleItemIds = new string[]
                            {
                                "6130ca3fd92c473c77020dbd",
                                "5648ac824bdc2ded0b8b457d"
                            },
                            Name = "mod_charge",
                        },
                        new ModSlot()
                        {
                            CompatibleItemIds = new string[]
                            {
                                "564ca9df4bdc2d35148b4569",
                                "564ca99c4bdc2d16268b4589",
                                "55d480c04bdc2d1d4e8b456a",
                                "5cbdaf89ae9215000e5b9c94",
                                "55d481904bdc2d8c2f8b456a",
                                "55d482194bdc2d1d4e8b456b",
                                "55d4837c4bdc2d1d4e8b456c",
                                "5aaa4194e5b5b055d06310a5",
                                "5bed61680db834001d2c45ab",
                                "5bed625c0db834001c062946"
                            },
                            Name = "mod_magazine"
                        },
                        new ModSlot()
                        {
                            CompatibleItemIds = new string[]
                            {
                                "5ac72e945acfc43f3b691116",
                                "5ac7655e5acfc40016339a19",
                                "5649aa744bdc2ded0b8b457e",
                                "5f633f791b231926f2329f13",
                                "5943eeeb86f77412d6384f6b",
                                "5cc9a96cd7f00c011c04e04a",
                                "615d8f5dd92c473c770212ef",
                                "5649ab884bdc2ded0b8b457f",
                                "57dc324a24597759501edc20",
                                "59bffc1f86f77435b128b872",
                                "593d493f86f7745e6b2ceb22",
                                "564caa3d4bdc2d17108b458e",
                                "57ffb0e42459777d047111c5"
                            },
                            Name = "mod_muzzle"
                        },
                        new ModSlot()
                        {
                            CompatibleItemIds = new string[]
                            {
                                "57dc334d245977597164366f",
                                "5839a7742459773cf9693481"
                            },
                            Name = "mod_reciever"
                        },
                        new ModSlot()
                        {
                            CompatibleItemIds = new string[]
                            {
                                "59d36a0086f7747e673f3946"
                            },
                            Name = "mod_gas_block"
                        }
                    },
                    Name = "Kalashnikov AKS-74U 5.45x39 assault rifle",
                    ShortName = "AKS-74U",
                    VerticalRecoil = 141,
                    Weight = 1.809,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Kalashnikov_AKS-74U_5.45x39_assault_rifle"
                },
                new RangedWeapon()
                {
                    Caliber = "Caliber26x75",
                    CategoryId = "mainWeapon",
                    Ergonomics = 51,
                    FireModes = new string[] { "SingleFire" },
                    FireRate = 30,
                    HorizontalRecoil = 400,
                    IconLink = "https://assets.tarkov.dev/624c0b3340357b5f566e8766-icon.jpg",
                    Id = "624c0b3340357b5f566e8766",
                    ImageLink = "https://assets.tarkov.dev/624c0b3340357b5f566e8766-image.jpg",
                    MarketLink = "https://tarkov.dev/item/rsp-30-reactive-signal-cartridge-yellow",
                    Name = "RSP-30 reactive signal cartridge (Yellow)",
                    ShortName = "Yellow",
                    VerticalRecoil = 200,
                    Weight = 0.6,
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/RSP-30_reactive_signal_cartridge_(Yellow)"
                }
            };

            // Act
            string result = Serialize(containers);

            // Assert
            result.Should().Be("[{\"bi\":\"57dc2fa62459775949412633\",\"ca\":\"Caliber545x39\",\"dp\":\"584147732459775a2b6d9f12\",\"e\":44,\"fm\":[\"SingleFire\",\"FullAuto\"],\"r\":650,\"h\":445,\"ma\":3.44,\"v\":141,\"c\":\"mainWeapon\",\"ic\":\"https://assets.tarkov.dev/584147732459775a2b6d9f12-icon.webp\",\"i\":\"584147732459775a2b6d9f12\",\"im\":\"https://assets.tarkov.dev/584147732459775a2b6d9f12-image.webp\",\"m\":\"https://tarkov.dev/item/kalashnikov-aks-74u-545x39-assault-rifle-default\",\"n\":\"Kalashnikov AKS-74U 5.45x39 assault rifle Default\",\"s\":\"AKS-74U Default\",\"w\":2.694,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Kalashnikov_AKS-74U_5.45x39_assault_rifle\"},{\"ca\":\"Caliber545x39\",\"dp\":\"584147732459775a2b6d9f12\",\"e\":44,\"fm\":[\"SingleFire\",\"FullAuto\"],\"r\":650,\"h\":445,\"mo\":[{\"i\":[\"5f6341043ada5942720e2dc5\",\"6087e663132d4d12c81fd96b\",\"5beec8ea0db834001a6f9dbf\",\"5649ad3f4bdc2df8348b4585\",\"5649ade84bdc2d1b2b8b4587\",\"59e62cc886f77440d40b52a1\",\"5a0071d486f77404e23a12b2\",\"57e3dba62459770f0c32322b\",\"5cf54404d7f00c108840b2ef\",\"5e2192a498a36665e8337386\",\"5b30ac585acfc433000eb79c\",\"59e6318286f77444dd62c4cc\",\"5cf50850d7f00c056e24104c\",\"5cf508bfd7f00c056e24104e\",\"5947f92f86f77427344a76b1\",\"5947fa2486f77425b47c1a9b\",\"5c6bf4aa2e2216001219b0ae\",\"5649ae4a4bdc2d1b2b8b4588\",\"5998517986f7746017232f7e\",\"623c3be0484b5003161840dc\",\"628c9ab845c59e5b80768a81\",\"628a664bccaab13006640e47\"],\"n\":\"mod_pistol_grip\",\"r\":1},{\"i\":[\"59ecc28286f7746d7a68aa8c\",\"5ab626e4d8ce87272e4c6e43\",\"57dc347d245977596754e7a1\"],\"n\":\"mod_stock\"},{\"i\":[\"6130ca3fd92c473c77020dbd\",\"5648ac824bdc2ded0b8b457d\"],\"n\":\"mod_charge\"},{\"i\":[\"564ca9df4bdc2d35148b4569\",\"564ca99c4bdc2d16268b4589\",\"55d480c04bdc2d1d4e8b456a\",\"5cbdaf89ae9215000e5b9c94\",\"55d481904bdc2d8c2f8b456a\",\"55d482194bdc2d1d4e8b456b\",\"55d4837c4bdc2d1d4e8b456c\",\"5aaa4194e5b5b055d06310a5\",\"5bed61680db834001d2c45ab\",\"5bed625c0db834001c062946\"],\"n\":\"mod_magazine\"},{\"i\":[\"5ac72e945acfc43f3b691116\",\"5ac7655e5acfc40016339a19\",\"5649aa744bdc2ded0b8b457e\",\"5f633f791b231926f2329f13\",\"5943eeeb86f77412d6384f6b\",\"5cc9a96cd7f00c011c04e04a\",\"615d8f5dd92c473c770212ef\",\"5649ab884bdc2ded0b8b457f\",\"57dc324a24597759501edc20\",\"59bffc1f86f77435b128b872\",\"593d493f86f7745e6b2ceb22\",\"564caa3d4bdc2d17108b458e\",\"57ffb0e42459777d047111c5\"],\"n\":\"mod_muzzle\"},{\"i\":[\"57dc334d245977597164366f\",\"5839a7742459773cf9693481\"],\"n\":\"mod_reciever\"},{\"i\":[\"59d36a0086f7747e673f3946\"],\"n\":\"mod_gas_block\"}],\"v\":141,\"c\":\"mainWeapon\",\"ic\":\"https://assets.tarkov.dev/57dc2fa62459775949412633-icon.jpg\",\"i\":\"57dc2fa62459775949412633\",\"im\":\"https://assets.tarkov.dev/57dc2fa62459775949412633-image.jpg\",\"m\":\"https://tarkov.dev/item/kalashnikov-aks-74u-545x39-assault-rifle\",\"n\":\"Kalashnikov AKS-74U 5.45x39 assault rifle\",\"s\":\"AKS-74U\",\"w\":1.809,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/Kalashnikov_AKS-74U_5.45x39_assault_rifle\"},{\"ca\":\"Caliber26x75\",\"e\":51,\"r\":30,\"h\":400,\"v\":200,\"c\":\"mainWeapon\",\"ic\":\"https://assets.tarkov.dev/624c0b3340357b5f566e8766-icon.jpg\",\"i\":\"624c0b3340357b5f566e8766\",\"im\":\"https://assets.tarkov.dev/624c0b3340357b5f566e8766-image.jpg\",\"m\":\"https://tarkov.dev/item/rsp-30-reactive-signal-cartridge-yellow\",\"n\":\"RSP-30 reactive signal cartridge (Yellow)\",\"s\":\"Yellow\",\"w\":0.6,\"wi\":\"https://escapefromtarkov.fandom.com/wiki/RSP-30_reactive_signal_cartridge_(Yellow)\"}]");
        }
    }
}
