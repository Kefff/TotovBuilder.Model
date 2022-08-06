using System;
using TotovBuilder.Model.Items;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public static Item[] Items = new Item[]
        {
            new Ammunition()
            {
                AccuracyPercentageModifier = -0.05,
                ArmorDamagePercentage = 0.76,
                //ArmorPenetrations = , // TODO : OBTAIN FROM WIKI
                //Blinding = , // TODO : MISSING FROM API
                Caliber = "Caliber762x39",
                CategoryId = "ammunition",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                DurabilityBurnPercentageModifier = 0.7,
                FleshDamage = 47,
                FragmentationChancePercentage = 0.05,
                HeavyBleedingPercentageChance = 0.1,
                IconLink = "https://assets.tarkov.dev/601aa3d2b2bcb34913271e6d-icon.jpg",
                Id = "601aa3d2b2bcb34913271e6d",
                ImageLink = "https://assets.tarkov.dev/601aa3d2b2bcb34913271e6d-image.jpg",
                LightBleedingPercentageChance = 0.1,
                MarketLink = "https://tarkov.dev/item/762x39mm-mai-ap",
                MaxStackableAmount = 60,
                Name = "7.62x39mm MAI AP",
                PenetrationPower = 58,
                Projectiles = 1,
                RecoilPercentageModifier = 0.10,
                ShortName = "MAI AP",
                Subsonic = false,
                Tracer = false,
                Velocity = 730,
                Weight = 0.012,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/7.62x39mm_MAI_AP"
            },
            new Armor()
            {
                ArmorClass = 6,
                ArmoredAreas = new string[]
                {
                    "Left arm",
                    "Right arm",
                    "Thorax",
                    "Stomach"
                },
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                CategoryId = "armor",
                Durability = 85,
                ErgonomicsPercentageModifier = -0.27,
                IconLink = "https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-icon.jpg",
                Id = "545cdb794bdc2d3a198b456a",
                ImageLink = "https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-image.jpg",
                MarketLink = "https://tarkov.dev/item/6b43-6a-zabralo-sh-body-armor",
                Material = "Combined materials",
                MaxStackableAmount = 1,
                MovementSpeedPercentageModifier = -0.35,
                Name = "6B43 6A Zabralo-Sh body armor",
                //RicochetChance = , // TODO : MISSING FROM API
                ShortName = "6B43 6A",
                TurningSpeedPercentageModifier = -0.21,
                Weight = 20,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/6B43_6A_Zabralo-Sh_body_armor"
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
                ConflictingItemIds = new string[] // TODO : MISSING FROM API
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
                MaxStackableAmount = 1,
                ModSlots = Array.Empty<ModSlot>(), // TODO : MISSING FROM API
                MovementSpeedPercentageModifier = 0,
                Name = "Ops-Core FAST multi-hit ballistic face shield",
                //RicochetChance = , // TODO : MISSING FROM API
                ShortName = "FAST FS",
                TurningSpeedPercentageModifier = -0.08,
                Weight = 1.2,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/Ops-Core_FAST_multi-hit_ballistic_face_shield",
            },
            new Container()
            {
                Capacity = 35,
                CategoryId = "backpack",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                IconLink = "https://assets.tarkov.dev/5ab8ebf186f7742d8b372e80-icon.jpg",
                Id = "5ab8ebf186f7742d8b372e80",
                ImageLink = "https://assets.tarkov.dev/5ab8ebf186f7742d8b372e80-image.jpg",
                MarketLink = "https://tarkov.dev/item/sso-attack-2-raid-backpack",
                MaxStackableAmount = 1,
                Name = "SSO Attack 2 raid backpack",
                ShortName = "Attack 2",
                Weight = 6.12,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/SSO_Attack_2_raid_backpack"
            },
            new Container()
            {
                Capacity = 4,
                CategoryId = "container",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                IconLink = "https://assets.tarkov.dev/5783c43d2459774bbe137486-icon.jpg",
                Id = "5783c43d2459774bbe137486",
                ImageLink = "https://assets.tarkov.dev/5783c43d2459774bbe137486-image.jpg",
                MarketLink = "https://tarkov.dev/item/simple-wallet",
                MaxStackableAmount = 1,
                Name = "Simple wallet",
                ShortName = "Wallet",
                Weight = 0.23,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/Simple_wallet"
            },
            new Container()
            {
                Capacity = 12,
                CategoryId = "securedContainer",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                IconLink = "https://assets.tarkov.dev/5c093ca986f7740a1867ab12-icon.jpg",
                Id = "5c093ca986f7740a1867ab12",
                ImageLink = "https://assets.tarkov.dev/5c093ca986f7740a1867ab12-image.jpg",
                MarketLink = "https://tarkov.dev/item/secure-container-kappa",
                MaxStackableAmount = 1,
                Name = "Secure container Kappa",
                ShortName = "Kappa",
                Weight = 2,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/Secure_container_Kappa"
            },
            new Eyewear()
            {
                BlindnessProtectionPercentage = 0.1,
                CategoryId = "eyewear",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                IconLink = "https://assets.tarkov.dev/5b432be65acfc433000ed01f-icon.jpg",
                Id = "5b432be65acfc433000ed01f",
                ImageLink = "https://assets.tarkov.dev/5b432be65acfc433000ed01f-image.jpg",
                MarketLink = "https://tarkov.dev/item/6b34-anti-fragmentation-glasses",
                MaxStackableAmount = 1,
                Name = "6B34 anti-fragmentation glasses",
                ShortName = "6B34",
                Weight = 0.12,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/6B34_anti-fragmentation_glasses"
            },
            new Grenade()
            {
                CategoryId = "grenade",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                ExplosionDelay = 3,
                FragmentsAmount = 100,
                MaximumExplosionRange = 6,
                MinimumExplosionRange = 2,
                IconLink = "https://assets.tarkov.dev/5e32f56fcb6d5863cc5e5ee4-icon.jpg",
                Id = "5e32f56fcb6d5863cc5e5ee4",
                ImageLink = "https://assets.tarkov.dev/5e32f56fcb6d5863cc5e5ee4-image.jpg",
                MarketLink = "https://tarkov.dev/item/vog-17-khattabka-improvised-hand-grenade",
                MaxStackableAmount = 1,
                Name = "VOG-17 Khattabka improvised hand grenade",
                ShortName = "VOG-17",
                Type = "Grenade",
                Weight = 0.28,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/VOG-17_Khattabka_improvised_hand_grenade"
            },
            new Grenade()
            {
                CategoryId = "grenade",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                ExplosionDelay = 2,
                FragmentsAmount = 0,
                MaximumExplosionRange = 10,
                MinimumExplosionRange = 10,
                IconLink = "https://assets.tarkov.dev/5a0c27731526d80618476ac4-icon.jpg",
                Id = "5a0c27731526d80618476ac4",
                ImageLink = "https://assets.tarkov.dev/5a0c27731526d80618476ac4-image.jpg",
                MarketLink = "https://tarkov.dev/item/zarya-stun-grenade",
                MaxStackableAmount = 1,
                Name = "\"Zarya\" stun grenade",
                ShortName = "Zarya",
                Type = "Flashbang",
                Weight = 0.175,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/%22Zarya%22_stun_grenade"
            },
            new Headwear()
            {
                ArmorClass = 4,
                ArmoredAreas = new string[]
                {
                    "Top",
                    "Nape"
                },
                CategoryId = "headwear",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                Deafening = "None",
                Durability = 30,
                ErgonomicsPercentageModifier = -0.06,
                IconLink = "https://assets.tarkov.dev/5e4bfc1586f774264f7582d3-icon.jpg",
                Id = "5e4bfc1586f774264f7582d3",
                ImageLink = "https://assets.tarkov.dev/5e4bfc1586f774264f7582d3-image.jpg",
                MarketLink = "https://tarkov.dev/item/msa-gallet-tc-800-high-cut-combat-helmet",
                Material = "Combined materials",
                MaxStackableAmount = 1,
                ModSlots = new ModSlot[] // TODO : MISSING FROM API
                {
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5a16b672fcdbcb001912fa83",
                            "5a16b7e1fcdbcb00165aa6c9"
                        },
                        Id = "5e4bfc1586f774264f7582d5",
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
                        Id = "5e4bfc1586f774264f7582d6",
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
                        Id = "5e4bfc1586f774264f7582d7",
                        Name = "mod_mount",
                        Required = false
                    }
                },
                MovementSpeedPercentageModifier = -0.02,
                Name = "MSA Gallet TC 800 High Cut combat helmet",
                //RicochetChance = , // TODO : MISSING FROM API
                ShortName = "TC 800",
                TurningSpeedPercentageModifier = -0.08,
                Weight = 1.17,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/MSA_Gallet_TC_800_High_Cut_combat_helmet"
            },
            new Item()
            {
                CategoryId = "armband",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                IconLink = "https://assets.tarkov.dev/5f9949d869e2777a0e779ba5-icon.jpg",
                Id = "5f9949d869e2777a0e779ba5",
                ImageLink = "https://assets.tarkov.dev/5f9949d869e2777a0e779ba5-image.jpg",
                MarketLink = "https://tarkov.dev/item/rivals-2020-armband",
                MaxStackableAmount = 1,
                Name = "Rivals 2020 armband",
                ShortName = "Rivals",
                Weight = 0.05,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/Rivals_2020_armband"
            },
            new Item()
            {
                CategoryId = "currency",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                IconLink = "https://assets.tarkov.dev/569668774bdc2da2298b4568-icon.jpg",
                Id = "569668774bdc2da2298b4568",
                ImageLink = "https://assets.tarkov.dev/569668774bdc2da2298b4568-image.jpg",
                MarketLink = "https://tarkov.dev/item/euros",
                MaxStackableAmount = 50000, // TODO : MISSING FROM API
                Name = "Euros",
                ShortName = "EUR",
                Weight = 0,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/Euros"
            },
            new Item()
            {
                CategoryId = "faceCover",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                IconLink = "https://assets.tarkov.dev/5e54f76986f7740366043752-icon.jpg",
                Id = "5e54f76986f7740366043752",
                ImageLink = "https://assets.tarkov.dev/5e54f76986f7740366043752-image.jpg",
                MarketLink = "https://tarkov.dev/item/shroud-half-mask",
                MaxStackableAmount = 1,
                Name = "Shroud half-mask",
                ShortName = "Shroud",
                Weight = 0.1,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/Shroud_half-mask"
            },
            new Item()
            {
                CategoryId = "headphones",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                IconLink = "https://assets.tarkov.dev/628e4e576d783146b124c64d-icon.jpg",
                Id = "628e4e576d783146b124c64d",
                ImageLink = "https://assets.tarkov.dev/628e4e576d783146b124c64d-image.jpg",
                MarketLink = "https://tarkov.dev/item/peltor-comtac-4-hybrid-headset",
                MaxStackableAmount = 1,
                Name = "Peltor ComTac 4 Hybrid headset",
                ShortName = "ComTac 4",
                Weight = 0.6,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/Peltor_ComTac_4_Hybrid_headset"
            },
            new Item()
            {
                CategoryId = "other",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                IconLink = "https://assets.tarkov.dev/5c1d0c5f86f7744bb2683cf0-icon.jpg",
                Id = "5c1d0c5f86f7744bb2683cf0",
                ImageLink = "https://assets.tarkov.dev/5c1d0c5f86f7744bb2683cf0-image.jpg",
                MarketLink = "https://tarkov.dev/item/terragroup-labs-keycard-blue",
                MaxStackableAmount = 1,
                Name = "TerraGroup Labs keycard (Blue)",
                ShortName = "Blue",
                Weight = 0.01,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/TerraGroup_Labs_keycard_(Blue)"
            },
            new Item()
            {
                CategoryId = "special",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                IconLink = "https://assets.tarkov.dev/5991b51486f77447b112d44f-icon.jpg",
                Id = "5991b51486f77447b112d44f",
                ImageLink = "https://assets.tarkov.dev/5991b51486f77447b112d44f-image.jpg",
                MarketLink = "https://tarkov.dev/item/ms2000-marker",
                MaxStackableAmount = 1,
                Name = "MS2000 Marker",
                ShortName = "MS2000",
                Weight = 0.5,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/MS2000_Marker"
            },
            new Magazine()
            {
                AcceptedAmmunitionIds = new string[] // TODO : MISSING FROM API
                {
                    "5e81f423763d9f754677bf2e",
                    "5efb0cabfb3e451d70735af5",
                    "5efb0fc6aeb21837e749c801",
                    "5efb0d4f4bc50b58e81710f3",
                    "5ea2a8e200685063ec28c05a"
                },
                Capacity = 7,
                CategoryId = "magazine",
                CheckSpeedPercentageModifier = -0.2,
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                ErgonomicsModifier = -1,
                IconLink = "https://assets.tarkov.dev/5e81c4ca763d9f754677befa-icon.jpg",
                Id = "5e81c4ca763d9f754677befa",
                ImageLink = "https://assets.tarkov.dev/5e81c4ca763d9f754677befa-image.jpg",
                LoadSpeedPercentageModifier = -0.25,
                MalfunctionPercentage = 0.04,
                MarketLink = "https://tarkov.dev/item/m1911a1-45-acp-7-round-magazine",
                MaxStackableAmount = 1,
                ModSlots = Array.Empty<ModSlot>(),
                Name = "M1911A1 .45 ACP 7-round magazine",
                ShortName = "1911",
                Weight = 0.16,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/M1911A1_.45_ACP_7-round_magazine"
            },
            new MeleeWeapon()
            {
                CategoryId = "meleeWeapon",
                ChopDamage = 25,
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                HitRadius = 0.6,
                IconLink = "https://assets.tarkov.dev/5c0126f40db834002a125382-icon.jpg",
                Id = "5c0126f40db834002a125382",
                ImageLink = "https://assets.tarkov.dev/5c0126f40db834002a125382-image.jpg",
                MarketLink = "https://tarkov.dev/item/red-rebel-ice-pick",
                MaxStackableAmount = 1,
                Name = "Red Rebel ice pick",
                ShortName = "RedRebel",
                StabDamage = 30,
                Weight = 0.65,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/Red_Rebel_ice_pick"
            },
            new Mod()
            {
                CategoryId = "mod",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                ErgonomicsModifier = -2,
                IconLink = "https://assets.tarkov.dev/59d790f486f77403cb06aec6-icon.jpg",
                Id = "59d790f486f77403cb06aec6",
                ImageLink = "https://assets.tarkov.dev/59d790f486f77403cb06aec6-image.jpg",
                MarketLink = "https://tarkov.dev/item/armytek-predator-pro-v3-xhp35-hi-flashlight",
                MaxStackableAmount = 1,
                ModSlots = Array.Empty<ModSlot>(), // TODO : MISSING FROM API
                Name = "Armytek Predator Pro v3 XHP35 HI flashlight",
                ShortName = "XHP35",
                Weight = 0.12,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/Armytek_Predator_Pro_v3_XHP35_HI_flashlight"
            },
            new RangedWeapon()
            {
                Caliber = "Caliber545x39",
                CategoryId = "mainWeapon",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                Ergonomics = 44,
                FireModes = new string[] { "Single fire", "Full auto" },
                FireRate = 650,
                HorizontalRecoil = 445,
                IconLink = "https://assets.tarkov.dev/57dc2fa62459775949412633-icon.jpg",
                Id = "57dc2fa62459775949412633",
                ImageLink = "https://assets.tarkov.dev/57dc2fa62459775949412633-image.jpg",
                MarketLink = "https://tarkov.dev/item/kalashnikov-aks-74u-545x39-assault-rifle",
                MaxStackableAmount = 1,
                ModSlots = new ModSlot[] // TODO : MISSING FROM API
                {
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5c0d5e4486f77478390952fe",
                            "61962b617c6c7b169525f168",
                            "56dfef82d2720bbd668b4567",
                            "56dff026d2720bb8668b4567",
                            "56dff061d2720bb5668b4567",
                            "56dff0bed2720bb0668b4567",
                            "56dff216d2720bbd668b4568",
                            "56dff2ced2720bb4668b4567",
                            "56dff338d2720bbd668b4569",
                            "56dff3afd2720bba668b4567",
                            "56dff421d2720b5f5a8b4567",
                            "56dff4a2d2720bbd668b456a",
                            "56dff4ecd2720b5f5a8b4568"
                        },
                        Id = "57dc318524597759805c1581",
                        MaxStackableAmount = 1,
                        Name = "chamber0", // TODO : MISSING FROM API
                        Required = false
                    },
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
                            "5998517986f7746017232f7e"
                        },
                        Id = "57dc31bc245977596d4ef3d2",
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
                        Id = "57dc31ce245977593d4e1453",
                        Name = "mod_stock",
                        Required = false
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "6130ca3fd92c473c77020dbd",
                            "5648ac824bdc2ded0b8b457d"
                        },
                        Id = "57dc31e1245977597164366e",
                        Name = "mod_charge",
                        Required = false
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
                        Id = "57dc31f2245977596c274b4f",
                        Name = "mod_magazine",
                        Required = false
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
                        Id = "57dc35ce2459775971643671",
                        Name = "mod_muzzle",
                        Required = false
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "57dc334d245977597164366f",
                            "5839a7742459773cf9693481"
                        },
                        Id = "57dc35fb245977596d4ef3d7",
                        Name = "mod_reciever",
                        Required = false
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "59d36a0086f7747e673f3946"
                        },
                        Id = "59d368ce86f7747e6a5beb03",
                        Name = "mod_gas_block",
                        Required = true
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
                Caliber = "Caliber1143x23ACP",
                CategoryId = "secondaryWeapon",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                Ergonomics = 75,
                FireModes = new string[] { "Single fire" },
                FireRate = 30,
                HorizontalRecoil = 355,
                IconLink = "https://assets.tarkov.dev/5e81c3cbac2bb513793cdc75-icon.jpg",
                Id = "5e81c3cbac2bb513793cdc75",
                ImageLink = "https://assets.tarkov.dev/5e81c3cbac2bb513793cdc75-image.jpg",
                MarketLink = "https://tarkov.dev/item/colt-m1911a1-45-acp-pistol",
                MaxStackableAmount = 1,
                ModSlots = new ModSlot[] // TODO : MISSING FROM API
                {
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81f423763d9f754677bf2e",
                            "5efb0cabfb3e451d70735af5",
                            "5efb0fc6aeb21837e749c801",
                            "5efb0d4f4bc50b58e81710f3",
                            "5ea2a8e200685063ec28c05a"
                        },
                        Id = "5e81c3cbac2bb513793cdc7e",
                        Name = "chamber0",
                        Required = false
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81c519cb2b95385c177551",
                            "5f3e7801153b8571434a924c",
                            "5f3e77f59103d430b93f94c1"
                        },
                        Id = "5e81c3cbac2bb513793cdc77",
                        Name = "mod_barrel",
                        Required = true
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81c6bf763d9f754677beff",
                            "5ef366938cef260c0642acad"
                        },
                        Id = "5e81c3cbac2bb513793cdc78",
                        Name = "mod_pistol_grip",
                        Required = true
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81edc13397a21db957f6a1",
                            "5f3e7823ddc4f03b010e2045"
                        },
                        Id = "5e81c3cbac2bb513793cdc79",
                        Name = "mod_reciever",
                        Required = true
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81c4ca763d9f754677befa",
                            "5f3e77b26cda304dcc634057",
                            "5ef3448ab37dfd6af863525c"
                        },
                        Id = "5e81c3cbac2bb513793cdc7a",
                        Name = "mod_magazine",
                        Required = false
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5ef32e4d1c1fd62aea6a150d",
                            "5e81c6a2ac2bb513793cdc7f",
                            "5f3e772a670e2a7b01739a52"
                        },
                        Id = "5e8206f4cb2b95385c17759c",
                        Name = "mod_trigger",
                        Required = true
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81c550763d9f754677befd",
                            "5f3e76d86cda304dcc634054",
                            "5ef35f46382a846010715a96",
                            "5ef35d2ac64c5d0dfc0571b0",
                            "5ef35bc243cb350a955a7ccd"
                        },
                        Id = "5e820703ac2bb513793cdd0d",
                        Name = "mod_hammer",
                        Required = true
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81c539cb2b95385c177553",
                            "5f3e777688ca2d00ad199d25",
                            "5ef3553c43cb350a955a7ccb"
                        },
                        Id = "5e82070e763d9f754677bf93",
                        Name = "mod_catch",
                        Required = true
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5ef5d994dfbc9f3c660ded95"
                        },
                        Id = "5ef5d9bc22584f36a62bc2a6",
                        Name = "mod_mount_000",
                        Required = false
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5ef369b08cef260c0642acaf"
                        },
                        Id = "5ef5d9c76b0e105bd96c76db",
                        Name = "mod_mount_001",
                        Required = false
                    }
                },
                Name = "Colt M1911A1 .45 ACP pistol",
                ShortName = "M1911A1",
                VerticalRecoil = 530,
                Weight = 0.231,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/Colt_M1911A1_.45_ACP_pistol"
            },
            new RangedWeaponMod()
            {
                AccuracyPercentageModifier = 0,
                CategoryId = "rangedWeaponMod",
                ConflictingItemIds = new string[] // TODO : MISSING FROM API
                {
                    "5947db3f86f77447880cf76f",
                    "57486e672459770abd687134",
                    "5ac733a45acfc400192630e2",
                    "5649b0544bdc2d1b2b8b458a",
                    "5ac72e475acfc400180ae6fe",
                    "59d650cf86f7741b846413a4",
                    "5a0eb980fcdbcb001a3b00a6",
                    "59e8977386f77415a553c453",
                    "5649d9a14bdc2d79388b4580",
                    "5c82342f2e221644f31c060e",
                    "576fd4ec2459777f0b518431",
                    "5c82343a2e221644f31c0611",
                    "5cf638cbd7f00c06595bc936",
                    "5a7c74b3e899ef0014332c29",
                    "591ee00d86f774592f7b841e",
                    "5d0a29ead7ad1a0026013f27",
                    "57acb6222459771ec34b5cb0",
                    "5c61a40d2e2216001403158d",
                    "5c90c3622e221601da359851"
                },
                ErgonomicsModifier = 5,
                IconLink = "https://assets.tarkov.dev/5d2c76ed48f03532f2136169-icon.jpg",
                Id = "5d2c76ed48f03532f2136169",
                ImageLink = "https://assets.tarkov.dev/5d2c76ed48f03532f2136169-image.jpg",
                MarketLink = "https://tarkov.dev/item/ak-akademia-bastion-dust-cover",
                MaxStackableAmount = 1,
                ModSlots = new ModSlot[] // TODO : MISSING FROM API
                {
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "57ac965c24597706be5f975c",
                            "57aca93d2459771f2c7e26db",
                            "544a3f024bdc2d1d388b4568",
                            "544a3a774bdc2d3a388b4567",
                            "5d2dc3e548f035404a1a4798",
                            "57adff4f24597737f373b6e6",
                            "5c0517910db83400232ffee5",
                            "591c4efa86f7741030027726",
                            "570fd79bd2720bc7458b4583",
                            "570fd6c2d2720bc6458b457f",
                            "558022b54bdc2dac148b458d",
                            "5c07dd120db834001c39092d",
                            "5c0a2cec0db834001b7ce47d",
                            "58491f3324597764bc48fa02",
                            "584924ec24597768f12ae244",
                            "5b30b0dc5acfc400153b7124",
                            "6165ac8c290d254f5e6b2f6c",
                            "60a23797a37c940de7062d02",
                            "5d2da1e948f035477b1ce2ba",
                            "5c0505e00db834001b735073",
                            "609a63b6e2ff132951242d09",
                            "584984812459776a704a82a6",
                            "59f9d81586f7744c7506ee62",
                            "570fd721d2720bc5458b4596",
                            "57ae0171245977343c27bfcf",
                            "5dfe6104585a0c3e995c7b82",
                            "544a3d0a4bdc2d1b388b4567",
                            "5d1b5e94d7ad1a2b865a96b0",
                            "609bab8b455afd752b2e6138",
                            "58d39d3d86f77445bb794ae7",
                            "616554fe50224f204c1da2aa",
                            "5c7d55f52e221644f31bff6a",
                            "616584766ef05c2ce828ef57",
                            "5b3b6dc75acfc47a8773fb1e",
                            "615d8d878004cc50514c3233",
                            "5b2389515acfc4771e1be0c0",
                            "577d128124597739d65d0e56",
                            "618b9643526131765025ab35",
                            "618bab21526131765025ab3f",
                            "5c86592b2e2216000e69e77c",
                            "5a37ca54c4a282000d72296a",
                            "5d0a29fed7ad1a002769ad08",
                            "5c064c400db834001d23f468",
                            "58d2664f86f7747fec5834f6",
                            "57c69dd424597774c03b7bbc",
                            "5b3b99265acfc4704b4a1afb",
                            "5aa66a9be5b5b0214e506e89",
                            "5aa66c72e5b5b00016327c93",
                            "5c1cdd302e221602b3137250",
                            "61714b2467085e45ef140b2c",
                            "6171407e50224f204c1da3c5",
                            "61713cc4d8e3106d9806c109",
                            "5b31163c5acfc400153b71cb",
                            "5a33b652c4a28232996e407c",
                            "5a33b2c9c4a282000c5a9511",
                            "59db7eed86f77461f8380365",
                            "5a1ead28fcdbcb001912fa9f",
                            "5dff77c759400025ea5150cf"
                        },
                        Id = "5d2c76ed48f03532f213616b",
                        Name = "mod_scope",
                        Required = false
                    }
                },
                Name = "AK AKademia Bastion dust cover",
                RecoilPercentageModifier = -0.01,
                ShortName = "Bastion",
                Weight = 0.237,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/AK_AKademia_Bastion_dust_cover"
            },
            new RangedWeaponMod()
            {
                AccuracyPercentageModifier = 0,
                CategoryId = "rangedWeaponMod",
                ConflictingItemIds = new string[] // TODO : MISSING FROM API
                {
                    "591c4efa86f7741030027726",
                    "570fd79bd2720bc7458b4583",
                    "570fd6c2d2720bc6458b457f",
                    "558022b54bdc2dac148b458d",
                    "58491f3324597764bc48fa02",
                    "584924ec24597768f12ae244",
                    "5b30b0dc5acfc400153b7124",
                    "60a23797a37c940de7062d02",
                    "5d2da1e948f035477b1ce2ba",
                    "5c0505e00db834001b735073",
                    "609a63b6e2ff132951242d09",
                    "584984812459776a704a82a6",
                    "59f9d81586f7744c7506ee62",
                    "570fd721d2720bc5458b4596",
                    "5c7d55f52e221644f31bff6a"
                },
                ErgonomicsModifier = -6,
                IconLink = "https://assets.tarkov.dev/61714eec290d254f5e6b2ffc-icon.jpg",
                Id = "61714eec290d254f5e6b2ffc",
                ImageLink = "https://assets.tarkov.dev/61714eec290d254f5e6b2ffc-image.jpg",
                MarketLink = "https://tarkov.dev/item/schmidt-bender-pm-ii-3-12x50-scope",
                MaxStackableAmount = 1,
                ModSlots = Array.Empty<ModSlot>(), // TODO : MISSING FROM API
                Name = "Schmidt & Bender PM II 3-12x50 34mm riflescope",
                RecoilPercentageModifier = 0,
                ShortName = "PM II 3-12x50",
                Weight = 0.9,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/Schmidt_%26_Bender_PM_II_3-12x50_34mm_riflescope"
            },
            new Vest()
            {
                ArmorClass = 4,
                ArmoredAreas = new string[]
                {
                    "Thorax",
                    "Stomach"
                },
                Capacity = 12,
                CategoryId = "vest",
                ConflictingItemIds = Array.Empty<string>(), // TODO : MISSING FROM API
                Durability = 40,
                ErgonomicsPercentageModifier = -0.15,
                IconLink = "https://assets.tarkov.dev/5d5d646386f7742797261fd9-icon.jpg",
                Id = "5d5d646386f7742797261fd9",
                ImageLink = "https://assets.tarkov.dev/5d5d646386f7742797261fd9-image.jpg",
                MarketLink = "https://tarkov.dev/item/6b3tm-01m-armored-rig",
                Material = "Titan",
                MaxStackableAmount = 1,
                MovementSpeedPercentageModifier = -0.10,
                Name = "6B3TM-01M armored rig",
                //RicochetChance = , // TODO : MISSING FROM API
                ShortName = "6B3TM-01M",
                TurningSpeedPercentageModifier = -0.05,
                Weight = 9.2,
                WikiLink = "https://escapefromtarkov.fandom.com/wiki/6B3TM-01M_armored_rig"
            }
        };

        public const string ItemsJson = @"{
  ""data"": {
    ""items"": [
      {
        ""categories"": [
          {
            ""id"": ""5485a8684bdc2da71d8b4567""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/601aa3d2b2bcb34913271e6d-icon.jpg"",
        ""id"": ""601aa3d2b2bcb34913271e6d"",
        ""imageLink"": ""https://assets.tarkov.dev/601aa3d2b2bcb34913271e6d-image.jpg"",
        ""link"": ""https://tarkov.dev/item/762x39mm-mai-ap"",
        ""name"": ""7.62x39mm MAI AP"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesAmmo"",
          ""accuracyModifier"": -0.05,
          ""armorDamage"": 76,
          ""caliber"": ""Caliber762x39"",
          ""damage"": 47,
          ""durabilityBurnFactor"": 1.7,
          ""fragmentationChance"": 0.05,
          ""heavyBleedModifier"": 0.1,
          ""initialSpeed"": 730,
          ""lightBleedModifier"": 0.1,
          ""penetrationChance"": 0.65,
          ""penetrationPower"": 58,
          ""projectileCount"": 1,
          ""recoilModifier"": 0.1,
          ""ricochetChance"": 0.435,
          ""stackMaxSize"": 60,
          ""tracer"": false
        },
        ""shortName"": ""MAI AP"",
        ""weight"": 0.012,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/7.62x39mm_MAI_AP""
      },
      {
        ""categories"": [
          {
            ""id"": ""5448e54d4bdc2dcc718b4568""
          },
          {
            ""id"": ""57bef4c42459772e8d35a53b""
          },
          {
            ""id"": ""543be5f84bdc2dd4348b456a""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-icon.jpg"",
        ""id"": ""545cdb794bdc2d3a198b456a"",
        ""imageLink"": ""https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-image.jpg"",
        ""link"": ""https://tarkov.dev/item/6b43-6a-zabralo-sh-body-armor"",
        ""name"": ""6B43 6A Zabralo-Sh body armor"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesArmor"",
          ""class"": 6,
          ""durability"": 85,
          ""ergoPenalty"": -27,
          ""material"": {
            ""name"": ""Combined materials""
          },
          ""speedPenalty"": -0.35,
          ""turnPenalty"": -0.21,
          ""zones"": [""Left Arm"", ""Right Arm"", ""THORAX"", ""STOMACH""]
        },
        ""shortName"": ""6B43 6A"",
        ""weight"": 20,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/6B43_6A_Zabralo-Sh_body_armor""
      },
      {
        ""categories"": [
          {
            ""id"": ""57bef4c42459772e8d35a53b""
          },
          {
            ""id"": ""543be5f84bdc2dd4348b456a""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5a16b7e1fcdbcb00165aa6c9-icon.jpg"",
        ""id"": ""5a16b7e1fcdbcb00165aa6c9"",
        ""imageLink"": ""https://assets.tarkov.dev/5a16b7e1fcdbcb00165aa6c9-image.jpg"",
        ""link"": ""https://tarkov.dev/item/ops-core-fast-multi-hit-ballistic-face-shield"",
        ""name"": ""Ops-Core FAST multi-hit ballistic face shield"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesArmorAttachment"",
          ""blindnessProtection"": 0.1,
          ""class"": 3,
          ""durability"": 40,
          ""ergoPenalty"": -8,
          ""headZones"": [""Eyes"", ""Jaws""],
          ""material"": {
            ""name"": ""Glass""
          },
          ""speedPenalty"": 0,
          ""turnPenalty"": -0.08
        },
        ""shortName"": ""FAST FS"",
        ""weight"": 1.2,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Ops-Core_FAST_multi-hit_ballistic_face_shield""
      },
      {
        ""categories"": [
          {
            ""id"": ""5448e53e4bdc2d60728b4567""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5ab8ebf186f7742d8b372e80-icon.jpg"",
        ""id"": ""5ab8ebf186f7742d8b372e80"",
        ""imageLink"": ""https://assets.tarkov.dev/5ab8ebf186f7742d8b372e80-image.jpg"",
        ""link"": ""https://tarkov.dev/item/sso-attack-2-raid-backpack"",
        ""name"": ""SSO Attack 2 raid backpack"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesBackpack"",
          ""capacity"": 35
        },
        ""shortName"": ""Attack 2"",
        ""weight"": 6.12,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/SSO_Attack_2_raid_backpack""
      },
      {
        ""categories"": [
          {
            ""id"": ""5795f317245977243854e041""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5783c43d2459774bbe137486-icon.jpg"",
        ""id"": ""5783c43d2459774bbe137486"",
        ""imageLink"": ""https://assets.tarkov.dev/5783c43d2459774bbe137486-image.jpg"",
        ""link"": ""https://tarkov.dev/item/simple-wallet"",
        ""name"": ""Simple wallet"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesContainer"",
          ""capacity"": 4
        },
        ""shortName"": ""Wallet"",
        ""weight"": 0.23,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Simple_wallet""
      },
      {
        ""categories"": [
          {
            ""id"": ""5448bf274bdc2dfc2f8b456a""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5c093ca986f7740a1867ab12-icon.jpg"",
        ""id"": ""5c093ca986f7740a1867ab12"",
        ""imageLink"": ""https://assets.tarkov.dev/5c093ca986f7740a1867ab12-image.jpg"",
        ""link"": ""https://tarkov.dev/item/secure-container-kappa"",
        ""name"": ""Secure container Kappa"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesContainer"",
          ""capacity"": 12
        },
        ""shortName"": ""Kappa"",
        ""weight"": 2,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Secure_container_Kappa""
      },
      {
        ""categories"": [
          {
            ""id"": ""5448e5724bdc2ddf718b4568""
          },
          {
            ""id"": ""57bef4c42459772e8d35a53b""
          },
          {
            ""id"": ""543be5f84bdc2dd4348b456a""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5b432be65acfc433000ed01f-icon.jpg"",
        ""id"": ""5b432be65acfc433000ed01f"",
        ""imageLink"": ""https://assets.tarkov.dev/5b432be65acfc433000ed01f-image.jpg"",
        ""link"": ""https://tarkov.dev/item/6b34-anti-fragmentation-glasses"",
        ""name"": ""6B34 anti-fragmentation glasses"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesGlasses"",
          ""blindnessProtection"": 0.1,
          ""class"": 0,
          ""durability"": 0,
          ""material"": null
        },
        ""shortName"": ""6B34"",
        ""weight"": 0.12,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/6B34_anti-fragmentation_glasses""
      },
      {
        ""categories"": [
          {
            ""id"": ""543be6564bdc2df4348b4568""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5e32f56fcb6d5863cc5e5ee4-icon.jpg"",
        ""id"": ""5e32f56fcb6d5863cc5e5ee4"",
        ""imageLink"": ""https://assets.tarkov.dev/5e32f56fcb6d5863cc5e5ee4-image.jpg"",
        ""link"": ""https://tarkov.dev/item/vog-17-khattabka-improvised-hand-grenade"",
        ""name"": ""VOG-17 Khattabka improvised hand grenade"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesGrenade"",
          ""contusionRadius"": 9,
          ""fragments"": 100,
          ""fuse"": 3,
          ""maxExplosionDistance"": 6,
          ""minExplosionDistance"": 2,
          ""type"": ""Grenade""
        },
        ""shortName"": ""VOG-17"",
        ""weight"": 0.28,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/VOG-17_Khattabka_improvised_hand_grenade""
      },
      {
        ""categories"": [
          {
            ""id"": ""543be6564bdc2df4348b4568""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5a0c27731526d80618476ac4-icon.jpg"",
        ""id"": ""5a0c27731526d80618476ac4"",
        ""imageLink"": ""https://assets.tarkov.dev/5a0c27731526d80618476ac4-image.jpg"",
        ""link"": ""https://tarkov.dev/item/zarya-stun-grenade"",
        ""name"": ""\""Zarya\"" stun grenade"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesGrenade"",
          ""contusionRadius"": 10,
          ""fragments"": 0,
          ""fuse"": 2,
          ""maxExplosionDistance"": 0,
          ""minExplosionDistance"": 0,
          ""type"": ""Flashbang""
        },
        ""shortName"": ""Zarya"",
        ""weight"": 0.175,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/%22Zarya%22_stun_grenade""
      },
      {
        ""categories"": [
          {
            ""id"": ""5a341c4086f77401f2541505""
          },
          {
            ""id"": ""57bef4c42459772e8d35a53b""
          },
          {
            ""id"": ""543be5f84bdc2dd4348b456a""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5e4bfc1586f774264f7582d3-icon.jpg"",
        ""id"": ""5e4bfc1586f774264f7582d3"",
        ""imageLink"": ""https://assets.tarkov.dev/5e4bfc1586f774264f7582d3-image.jpg"",
        ""link"": ""https://tarkov.dev/item/msa-gallet-tc-800-high-cut-combat-helmet"",
        ""name"": ""MSA Gallet TC 800 High Cut combat helmet"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesHelmet"",
          ""class"": 4,
          ""deafening"": ""None"",
          ""durability"": 30,
          ""ergoPenalty"": -6,
          ""headZones"": [""Top"", ""Nape""],
          ""material"": {
            ""name"": ""Combined materials""
          },
          ""speedPenalty"": -0.02,
          ""turnPenalty"": -0.08
        },
        ""shortName"": ""TC 800"",
        ""weight"": 1.17,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MSA_Gallet_TC_800_High_Cut_combat_helmet""
      },
      {
        ""categories"": [
          {
            ""id"": ""5b3f15d486f77432d0509248""
          },
          {
            ""id"": ""543be5f84bdc2dd4348b456a""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5f9949d869e2777a0e779ba5-icon.jpg"",
        ""id"": ""5f9949d869e2777a0e779ba5"",
        ""imageLink"": ""https://assets.tarkov.dev/5f9949d869e2777a0e779ba5-image.jpg"",
        ""link"": ""https://tarkov.dev/item/rivals-2020-armband"",
        ""name"": ""Rivals 2020 armband"",
        ""properties"": null,
        ""shortName"": ""Rivals"",
        ""weight"": 0.05,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Rivals_2020_armband""
      },
      {
        ""categories"": [
          {
            ""id"": ""543be5dd4bdc2deb348b4569""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/569668774bdc2da2298b4568-icon.jpg"",
        ""id"": ""569668774bdc2da2298b4568"",
        ""imageLink"": ""https://assets.tarkov.dev/569668774bdc2da2298b4568-image.jpg"",
        ""link"": ""https://tarkov.dev/item/euros"",
        ""name"": ""Euros"",
        ""properties"": null,
        ""shortName"": ""EUR"",
        ""weight"": 0,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Euros""
      },
      {
        ""categories"": [
          {
            ""id"": ""5a341c4686f77469e155819e""
          },
          {
            ""id"": ""57bef4c42459772e8d35a53b""
          },
          {
            ""id"": ""543be5f84bdc2dd4348b456a""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5e54f76986f7740366043752-icon.jpg"",
        ""id"": ""5e54f76986f7740366043752"",
        ""imageLink"": ""https://assets.tarkov.dev/5e54f76986f7740366043752-image.jpg"",
        ""link"": ""https://tarkov.dev/item/shroud-half-mask"",
        ""name"": ""Shroud half-mask"",
        ""properties"": null,
        ""shortName"": ""Shroud"",
        ""weight"": 0.1,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Shroud_half-mask""
      },
      {
        ""categories"": [
          {
            ""id"": ""5645bcb74bdc2ded0b8b4578""
          },
          {
            ""id"": ""543be5f84bdc2dd4348b456a""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/628e4e576d783146b124c64d-icon.jpg"",
        ""id"": ""628e4e576d783146b124c64d"",
        ""imageLink"": ""https://assets.tarkov.dev/628e4e576d783146b124c64d-image.jpg"",
        ""link"": ""https://tarkov.dev/item/peltor-comtac-4-hybrid-headset"",
        ""name"": ""Peltor ComTac 4 Hybrid headset"",
        ""properties"": null,
        ""shortName"": ""ComTac 4"",
        ""weight"": 0.6,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Peltor_ComTac_4_Hybrid_headset""
      },
      {
        ""categories"": [
          {
            ""id"": ""5c164d2286f774194c5e69fa""
          },
          {
            ""id"": ""543be5e94bdc2df1348b4568""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5c1d0c5f86f7744bb2683cf0-icon.jpg"",
        ""id"": ""5c1d0c5f86f7744bb2683cf0"",
        ""imageLink"": ""https://assets.tarkov.dev/5c1d0c5f86f7744bb2683cf0-image.jpg"",
        ""link"": ""https://tarkov.dev/item/terragroup-labs-keycard-blue"",
        ""name"": ""TerraGroup Labs keycard (Blue)"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesKey""
        },
        ""shortName"": ""Blue"",
        ""weight"": 0.01,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/TerraGroup_Labs_keycard_(Blue)""
      },
      {
        ""categories"": [
          {
            ""id"": ""5447e0e74bdc2d3c308b4567""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5991b51486f77447b112d44f-icon.jpg"",
        ""id"": ""5991b51486f77447b112d44f"",
        ""imageLink"": ""https://assets.tarkov.dev/5991b51486f77447b112d44f-image.jpg"",
        ""link"": ""https://tarkov.dev/item/ms2000-marker"",
        ""name"": ""MS2000 Marker"",
        ""properties"": null,
        ""shortName"": ""MS2000"",
        ""weight"": 0.5,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MS2000_Marker""
      },
      {
        ""categories"": [
          {
            ""id"": ""5448bc234bdc2d3c308b4569""
          },
          {
            ""id"": ""55802f3e4bdc2de7118b4584""
          },
          {
            ""id"": ""5448fe124bdc2da5018b4567""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5e81c4ca763d9f754677befa-icon.jpg"",
        ""id"": ""5e81c4ca763d9f754677befa"",
        ""imageLink"": ""https://assets.tarkov.dev/5e81c4ca763d9f754677befa-image.jpg"",
        ""link"": ""https://tarkov.dev/item/m1911a1-45-acp-7-round-magazine"",
        ""name"": ""M1911A1 .45 ACP 7-round magazine"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesMagazine"",
          ""ammoCheckModifier"": -0.2,
          ""capacity"": 7,
          ""ergonomics"": -1,
          ""loadModifier"": -0.25,
          ""malfunctionChance"": 0.04
        },
        ""shortName"": ""1911"",
        ""weight"": 0.16,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/M1911A1_.45_ACP_7-round_magazine""
      },
      {
        ""categories"": [
          {
            ""id"": ""5447e1d04bdc2dff2f8b4567""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5c0126f40db834002a125382-icon.jpg"",
        ""id"": ""5c0126f40db834002a125382"",
        ""imageLink"": ""https://assets.tarkov.dev/5c0126f40db834002a125382-image.jpg"",
        ""link"": ""https://tarkov.dev/item/red-rebel-ice-pick"",
        ""name"": ""Red Rebel ice pick"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesMelee"",
          ""hitRadius"": 0.6,
          ""slashDamage"": 25,
          ""stabDamage"": 30
        },
        ""shortName"": ""RedRebel"",
        ""weight"": 0.65,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Red_Rebel_ice_pick""
      },
      {
        ""categories"": [
          {
            ""id"": ""55818b084bdc2d5b648b4571""
          },
          {
            ""id"": ""550aa4154bdc2dd8348b456b""
          },
          {
            ""id"": ""5448fe124bdc2da5018b4567""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/59d790f486f77403cb06aec6-icon.jpg"",
        ""id"": ""59d790f486f77403cb06aec6"",
        ""imageLink"": ""https://assets.tarkov.dev/59d790f486f77403cb06aec6-image.jpg"",
        ""link"": ""https://tarkov.dev/item/armytek-predator-pro-v3-xhp35-hi-flashlight"",
        ""name"": ""Armytek Predator Pro v3 XHP35 HI flashlight"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesWeaponMod"",
          ""accuracyModifier"": 0,
          ""ergonomics"": -2,
          ""recoilModifier"": 0
        },
        ""shortName"": ""XHP35"",
        ""weight"": 0.12,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Armytek_Predator_Pro_v3_XHP35_HI_flashlight""
      },
      {
        ""categories"": [
          {
            ""id"": ""5447b5f14bdc2d61278b4567""
          },
          {
            ""id"": ""5422acb9af1c889c16000029""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/57dc2fa62459775949412633-icon.jpg"",
        ""id"": ""57dc2fa62459775949412633"",
        ""imageLink"": ""https://assets.tarkov.dev/57dc2fa62459775949412633-image.jpg"",
        ""link"": ""https://tarkov.dev/item/kalashnikov-aks-74u-545x39-assault-rifle"",
        ""name"": ""Kalashnikov AKS-74U 5.45x39 assault rifle"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesWeapon"",
          ""caliber"": ""Caliber545x39"",
          ""ergonomics"": 44,
          ""fireModes"": [""Single fire"", ""Full Auto""],
          ""fireRate"": 650,
          ""recoilHorizontal"": 445,
          ""recoilVertical"": 141
        },
        ""shortName"": ""AKS-74U"",
        ""weight"": 1.809,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Kalashnikov_AKS-74U_5.45x39_assault_rifle""
      },
      {
        ""categories"": [
          {
            ""id"": ""5447b5cf4bdc2d65278b4567""
          },
          {
            ""id"": ""5422acb9af1c889c16000029""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5e81c3cbac2bb513793cdc75-icon.jpg"",
        ""id"": ""5e81c3cbac2bb513793cdc75"",
        ""imageLink"": ""https://assets.tarkov.dev/5e81c3cbac2bb513793cdc75-image.jpg"",
        ""link"": ""https://tarkov.dev/item/colt-m1911a1-45-acp-pistol"",
        ""name"": ""Colt M1911A1 .45 ACP pistol"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesWeapon"",
          ""caliber"": ""Caliber1143x23ACP"",
          ""ergonomics"": 75,
          ""fireModes"": [""Single fire""],
          ""fireRate"": 30,
          ""recoilHorizontal"": 355,
          ""recoilVertical"": 530
        },
        ""shortName"": ""M1911A1"",
        ""weight"": 0.231,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Colt_M1911A1_.45_ACP_pistol""
      },
      {
        ""categories"": [
          {
            ""id"": ""55818a304bdc2db5418b457d""
          },
          {
            ""id"": ""55802f4a4bdc2ddb688b4569""
          },
          {
            ""id"": ""5448fe124bdc2da5018b4567""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5d2c76ed48f03532f2136169-icon.jpg"",
        ""id"": ""5d2c76ed48f03532f2136169"",
        ""imageLink"": ""https://assets.tarkov.dev/5d2c76ed48f03532f2136169-image.jpg"",
        ""link"": ""https://tarkov.dev/item/ak-akademia-bastion-dust-cover"",
        ""name"": ""AK AKademia Bastion dust cover"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesWeaponMod"",
          ""accuracyModifier"": 0,
          ""ergonomics"": 5,
          ""recoilModifier"": -0.01
        },
        ""shortName"": ""Bastion"",
        ""weight"": 0.237,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AK_AKademia_Bastion_dust_cover""
      },
      {
        ""categories"": [
          {
            ""id"": ""55818ae44bdc2dde698b456c""
          },
          {
            ""id"": ""5448fe7a4bdc2d6f028b456b""
          },
          {
            ""id"": ""550aa4154bdc2dd8348b456b""
          },
          {
            ""id"": ""5448fe124bdc2da5018b4567""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/61714eec290d254f5e6b2ffc-icon.jpg"",
        ""id"": ""61714eec290d254f5e6b2ffc"",
        ""imageLink"": ""https://assets.tarkov.dev/61714eec290d254f5e6b2ffc-image.jpg"",
        ""link"": ""https://tarkov.dev/item/schmidt-bender-pm-ii-3-12x50-scope"",
        ""name"": ""Schmidt & Bender PM II 3-12x50 34mm riflescope"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesScope"",
          ""ergonomics"": -6,
          ""recoilModifier"": 0,
          ""zoomLevels"": [[12, 3]]
        },
        ""shortName"": ""PM II 3-12x50"",
        ""weight"": 0.9,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Schmidt_%26_Bender_PM_II_3-12x50_34mm_riflescope""
      },
      {
        ""categories"": [
          {
            ""id"": ""5448e5284bdc2dcb718b4567""
          }
        ],
        ""iconLink"": ""https://assets.tarkov.dev/5d5d646386f7742797261fd9-icon.jpg"",
        ""id"": ""5d5d646386f7742797261fd9"",
        ""imageLink"": ""https://assets.tarkov.dev/5d5d646386f7742797261fd9-image.jpg"",
        ""link"": ""https://tarkov.dev/item/6b3tm-01m-armored-rig"",
        ""name"": ""6B3TM-01M armored rig"",
        ""properties"": {
          ""__typename"": ""ItemPropertiesChestRig"",
          ""capacity"": 12,
          ""class"": 4,
          ""durability"": 40,
          ""ergoPenalty"": -15,
          ""material"": {
            ""name"": ""Titan""
          },
          ""speedPenalty"": -0.1,
          ""turnPenalty"": -0.05,
          ""zones"": [""THORAX"", ""STOMACH""]
        },
        ""shortName"": ""6B3TM-01M"",
        ""weight"": 9.2,
        ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/6B3TM-01M_armored_rig""
      }
    ]
  }
}";

        public static ItemMissingProperties[] ItemMissingProperties = new ItemMissingProperties[]
        {
            new ItemMissingProperties()
            {
                Id = "601aa3d2b2bcb34913271e6d",
                MaxStackableAmount = 60
            },
            new ItemMissingProperties()
            {
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
                Id = "5a16b7e1fcdbcb00165aa6c9"
            },
            new ItemMissingProperties()
            {
                Id = "5e4bfc1586f774264f7582d3",
                ModSlots = new ModSlot[]
                {
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5a16b672fcdbcb001912fa83",
                            "5a16b7e1fcdbcb00165aa6c9"
                        },
                        Id = "5e4bfc1586f774264f7582d5",
                        Name = "mod_equipment_000"
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5c0558060db834001b735271",
                            "5a16b8a9fcdbcb00165aa6ca"
                        },
                        Id = "5e4bfc1586f774264f7582d6",
                        Name = "mod_nvg"
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5a398b75c4a282000a51a266",
                            "5a398ab9c4a282000c5a9842"
                        },
                        Id = "5e4bfc1586f774264f7582d7",
                        Name = "mod_mount"
                    }
                }
            },
            new ItemMissingProperties()
            {
                Id = "569668774bdc2da2298b4568",
                MaxStackableAmount = 50000
            },
            new ItemMissingProperties()
            {
                AcceptedAmmunitionIds = new string[]
                {
                    "5e81f423763d9f754677bf2e",
                    "5efb0cabfb3e451d70735af5",
                    "5efb0fc6aeb21837e749c801",
                    "5efb0d4f4bc50b58e81710f3",
                    "5ea2a8e200685063ec28c05a"
                },
                Id = "5e81c4ca763d9f754677befa",
            },
            new ItemMissingProperties()
            {
                Id = "57dc2fa62459775949412633",
                ModSlots = new ModSlot[]
                {
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5c0d5e4486f77478390952fe",
                            "61962b617c6c7b169525f168",
                            "56dfef82d2720bbd668b4567",
                            "56dff026d2720bb8668b4567",
                            "56dff061d2720bb5668b4567",
                            "56dff0bed2720bb0668b4567",
                            "56dff216d2720bbd668b4568",
                            "56dff2ced2720bb4668b4567",
                            "56dff338d2720bbd668b4569",
                            "56dff3afd2720bba668b4567",
                            "56dff421d2720b5f5a8b4567",
                            "56dff4a2d2720bbd668b456a",
                            "56dff4ecd2720b5f5a8b4568"
                        },
                        Id = "57dc318524597759805c1581",
                        Name = "chamber0"
                    },
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
                            "5998517986f7746017232f7e"
                        },
                        Id = "57dc31bc245977596d4ef3d2",
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
                        Id = "57dc31ce245977593d4e1453",
                        Name = "mod_stock",
                        Required = false
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "6130ca3fd92c473c77020dbd",
                            "5648ac824bdc2ded0b8b457d"
                        },
                        Id = "57dc31e1245977597164366e",
                        Name = "mod_charge",
                        Required = false
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
                        Id = "57dc31f2245977596c274b4f",
                        Name = "mod_magazine",
                        Required = false
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
                        Id = "57dc35ce2459775971643671",
                        Name = "mod_muzzle",
                        Required = false
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "57dc334d245977597164366f",
                            "5839a7742459773cf9693481"
                        },
                        Id = "57dc35fb245977596d4ef3d7",
                        Name = "mod_reciever",
                        Required = false
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "59d36a0086f7747e673f3946"
                        },
                        Id = "59d368ce86f7747e6a5beb03",
                        Name = "mod_gas_block",
                        Required = true
                    }
                }
            },
            new ItemMissingProperties()
            {
                Id = "5e81c3cbac2bb513793cdc75",
                ModSlots = new ModSlot[]
                {
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81f423763d9f754677bf2e",
                            "5efb0cabfb3e451d70735af5",
                            "5efb0fc6aeb21837e749c801",
                            "5efb0d4f4bc50b58e81710f3",
                            "5ea2a8e200685063ec28c05a"
                        },
                        Id = "5e81c3cbac2bb513793cdc7e",
                        Name = "chamber0"
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81c519cb2b95385c177551",
                            "5f3e7801153b8571434a924c",
                            "5f3e77f59103d430b93f94c1"
                        },
                        Id = "5e81c3cbac2bb513793cdc77",
                        Name = "mod_barrel",
                        Required = true
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81c6bf763d9f754677beff",
                            "5ef366938cef260c0642acad"
                        },
                        Id = "5e81c3cbac2bb513793cdc78",
                        Name = "mod_pistol_grip",
                        Required = true
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81edc13397a21db957f6a1",
                            "5f3e7823ddc4f03b010e2045"
                        },
                        Id = "5e81c3cbac2bb513793cdc79",
                        Name = "mod_reciever",
                        Required = true
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81c4ca763d9f754677befa",
                            "5f3e77b26cda304dcc634057",
                            "5ef3448ab37dfd6af863525c"
                        },
                        Id = "5e81c3cbac2bb513793cdc7a",
                        Name = "mod_magazine",
                        Required = false
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5ef32e4d1c1fd62aea6a150d",
                            "5e81c6a2ac2bb513793cdc7f",
                            "5f3e772a670e2a7b01739a52"
                        },
                        Id = "5e8206f4cb2b95385c17759c",
                        Name = "mod_trigger",
                        Required = true
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81c550763d9f754677befd",
                            "5f3e76d86cda304dcc634054",
                            "5ef35f46382a846010715a96",
                            "5ef35d2ac64c5d0dfc0571b0",
                            "5ef35bc243cb350a955a7ccd"
                        },
                        Id = "5e820703ac2bb513793cdd0d",
                        Name = "mod_hammer",
                        Required = true
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5e81c539cb2b95385c177553",
                            "5f3e777688ca2d00ad199d25",
                            "5ef3553c43cb350a955a7ccb"
                        },
                        Id = "5e82070e763d9f754677bf93",
                        Name = "mod_catch",
                        Required = true
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5ef5d994dfbc9f3c660ded95"
                        },
                        Id = "5ef5d9bc22584f36a62bc2a6",
                        Name = "mod_mount_000",
                        Required = false
                    },
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "5ef369b08cef260c0642acaf"
                        },
                        Id = "5ef5d9c76b0e105bd96c76db",
                        Name = "mod_mount_001",
                        Required = false
                    }
                }
            },
            new ItemMissingProperties()
            {
                ConflictingItemIds = new string[]
                {
                    "5947db3f86f77447880cf76f",
                    "57486e672459770abd687134",
                    "5ac733a45acfc400192630e2",
                    "5649b0544bdc2d1b2b8b458a",
                    "5ac72e475acfc400180ae6fe",
                    "59d650cf86f7741b846413a4",
                    "5a0eb980fcdbcb001a3b00a6",
                    "59e8977386f77415a553c453",
                    "5649d9a14bdc2d79388b4580",
                    "5c82342f2e221644f31c060e",
                    "576fd4ec2459777f0b518431",
                    "5c82343a2e221644f31c0611",
                    "5cf638cbd7f00c06595bc936",
                    "5a7c74b3e899ef0014332c29",
                    "591ee00d86f774592f7b841e",
                    "5d0a29ead7ad1a0026013f27",
                    "57acb6222459771ec34b5cb0",
                    "5c61a40d2e2216001403158d",
                    "5c90c3622e221601da359851"
                },
                Id = "5d2c76ed48f03532f2136169",
                ModSlots = new ModSlot[]
                {
                    new ModSlot()
                    {
                        CompatibleItemIds = new string[]
                        {
                            "57ac965c24597706be5f975c",
                            "57aca93d2459771f2c7e26db",
                            "544a3f024bdc2d1d388b4568",
                            "544a3a774bdc2d3a388b4567",
                            "5d2dc3e548f035404a1a4798",
                            "57adff4f24597737f373b6e6",
                            "5c0517910db83400232ffee5",
                            "591c4efa86f7741030027726",
                            "570fd79bd2720bc7458b4583",
                            "570fd6c2d2720bc6458b457f",
                            "558022b54bdc2dac148b458d",
                            "5c07dd120db834001c39092d",
                            "5c0a2cec0db834001b7ce47d",
                            "58491f3324597764bc48fa02",
                            "584924ec24597768f12ae244",
                            "5b30b0dc5acfc400153b7124",
                            "6165ac8c290d254f5e6b2f6c",
                            "60a23797a37c940de7062d02",
                            "5d2da1e948f035477b1ce2ba",
                            "5c0505e00db834001b735073",
                            "609a63b6e2ff132951242d09",
                            "584984812459776a704a82a6",
                            "59f9d81586f7744c7506ee62",
                            "570fd721d2720bc5458b4596",
                            "57ae0171245977343c27bfcf",
                            "5dfe6104585a0c3e995c7b82",
                            "544a3d0a4bdc2d1b388b4567",
                            "5d1b5e94d7ad1a2b865a96b0",
                            "609bab8b455afd752b2e6138",
                            "58d39d3d86f77445bb794ae7",
                            "616554fe50224f204c1da2aa",
                            "5c7d55f52e221644f31bff6a",
                            "616584766ef05c2ce828ef57",
                            "5b3b6dc75acfc47a8773fb1e",
                            "615d8d878004cc50514c3233",
                            "5b2389515acfc4771e1be0c0",
                            "577d128124597739d65d0e56",
                            "618b9643526131765025ab35",
                            "618bab21526131765025ab3f",
                            "5c86592b2e2216000e69e77c",
                            "5a37ca54c4a282000d72296a",
                            "5d0a29fed7ad1a002769ad08",
                            "5c064c400db834001d23f468",
                            "58d2664f86f7747fec5834f6",
                            "57c69dd424597774c03b7bbc",
                            "5b3b99265acfc4704b4a1afb",
                            "5aa66a9be5b5b0214e506e89",
                            "5aa66c72e5b5b00016327c93",
                            "5c1cdd302e221602b3137250",
                            "61714b2467085e45ef140b2c",
                            "6171407e50224f204c1da3c5",
                            "61713cc4d8e3106d9806c109",
                            "5b31163c5acfc400153b71cb",
                            "5a33b652c4a28232996e407c",
                            "5a33b2c9c4a282000c5a9511",
                            "59db7eed86f77461f8380365",
                            "5a1ead28fcdbcb001912fa9f",
                            "5dff77c759400025ea5150cf"
                        },
                        Id = "5d2c76ed48f03532f213616b",
                        Name = "mod_scope",
                        Required = false
                    }
                }
            },
            new ItemMissingProperties()
            {
                ConflictingItemIds = new string[]
                {
                    "591c4efa86f7741030027726",
                    "570fd79bd2720bc7458b4583",
                    "570fd6c2d2720bc6458b457f",
                    "558022b54bdc2dac148b458d",
                    "58491f3324597764bc48fa02",
                    "584924ec24597768f12ae244",
                    "5b30b0dc5acfc400153b7124",
                    "60a23797a37c940de7062d02",
                    "5d2da1e948f035477b1ce2ba",
                    "5c0505e00db834001b735073",
                    "609a63b6e2ff132951242d09",
                    "584984812459776a704a82a6",
                    "59f9d81586f7744c7506ee62",
                    "570fd721d2720bc5458b4596",
                    "5c7d55f52e221644f31bff6a"
                },
                Id = "61714eec290d254f5e6b2ffc",
            }
        };

        public const string ItemMissingPropertiesJson = @"[
  {
    ""acceptedAmmunitionIds"": [],
    ""conflictingItemIds"": [],
    ""id"": ""601aa3d2b2bcb34913271e6d"",
    ""maxStackableAmount"": 60,
    ""modSlots"": []
  },
  {
    ""acceptedAmmunitionIds"": [],
    ""conflictingItemIds"": [
      ""5c0e66e2d174af02a96252f4"",
      ""5c0696830db834001d23f5da"",
      ""5c066e3a0db834001b7353f0"",
      ""5c0558060db834001b735271"",
      ""57235b6f24597759bf5a30f1"",
      ""5c110624d174af029e69734c"",
      ""5a16b8a9fcdbcb00165aa6ca""
    ],
    ""id"": ""5a16b7e1fcdbcb00165aa6c9"",
    ""maxStackableAmount"": 1,
    ""modSlots"": []
  },
  {
    ""acceptedAmmunitionIds"": [],
    ""conflictingItemIds"": [],
    ""id"": ""5e4bfc1586f774264f7582d3"",
    ""maxStackableAmount"": 1,
    ""modSlots"": [
      {
        ""compatibleItemIds"": [
          ""5a16b672fcdbcb001912fa83"",
          ""5a16b7e1fcdbcb00165aa6c9""
        ],
        ""id"": ""5e4bfc1586f774264f7582d5"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_equipment_000"",
        ""required"": false
      },
      {
        ""compatibleItemIds"": [
          ""5c0558060db834001b735271"",
          ""5a16b8a9fcdbcb00165aa6ca""
        ],
        ""id"": ""5e4bfc1586f774264f7582d6"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_nvg"",
        ""required"": false
      },
      {
        ""compatibleItemIds"": [
          ""5a398b75c4a282000a51a266"",
          ""5a398ab9c4a282000c5a9842""
        ],
        ""id"": ""5e4bfc1586f774264f7582d7"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_mount"",
        ""required"": false
      }
    ]
  },
  {
    ""acceptedAmmunitionIds"": [],
    ""conflictingItemIds"": [],
    ""id"": ""569668774bdc2da2298b4568"",
    ""maxStackableAmount"": 50000,
    ""modSlots"": []
  },
  {
    ""acceptedAmmunitionIds"": [
      ""5e81f423763d9f754677bf2e"",
      ""5efb0cabfb3e451d70735af5"",
      ""5efb0fc6aeb21837e749c801"",
      ""5efb0d4f4bc50b58e81710f3"",
      ""5ea2a8e200685063ec28c05a""
    ],
    ""conflictingItemIds"": [],
    ""id"": ""5e81c4ca763d9f754677befa"",
    ""maxStackableAmount"": 1,
    ""modSlots"": []
  },
  {
    ""acceptedAmmunitionIds"": [],
    ""conflictingItemIds"": [],
    ""id"": ""57dc2fa62459775949412633"",
    ""maxStackableAmount"": 1,
    ""modSlots"": [
      {
        ""compatibleItemIds"": [
          ""5c0d5e4486f77478390952fe"",
          ""61962b617c6c7b169525f168"",
          ""56dfef82d2720bbd668b4567"",
          ""56dff026d2720bb8668b4567"",
          ""56dff061d2720bb5668b4567"",
          ""56dff0bed2720bb0668b4567"",
          ""56dff216d2720bbd668b4568"",
          ""56dff2ced2720bb4668b4567"",
          ""56dff338d2720bbd668b4569"",
          ""56dff3afd2720bba668b4567"",
          ""56dff421d2720b5f5a8b4567"",
          ""56dff4a2d2720bbd668b456a"",
          ""56dff4ecd2720b5f5a8b4568""
        ],
        ""id"": ""57dc318524597759805c1581"",
        ""maxStackableAmount"": 1,
        ""name"": ""chamber0"",
        ""required"": false
      },
      {
        ""compatibleItemIds"": [
          ""5f6341043ada5942720e2dc5"",
          ""6087e663132d4d12c81fd96b"",
          ""5beec8ea0db834001a6f9dbf"",
          ""5649ad3f4bdc2df8348b4585"",
          ""5649ade84bdc2d1b2b8b4587"",
          ""59e62cc886f77440d40b52a1"",
          ""5a0071d486f77404e23a12b2"",
          ""57e3dba62459770f0c32322b"",
          ""5cf54404d7f00c108840b2ef"",
          ""5e2192a498a36665e8337386"",
          ""5b30ac585acfc433000eb79c"",
          ""59e6318286f77444dd62c4cc"",
          ""5cf50850d7f00c056e24104c"",
          ""5cf508bfd7f00c056e24104e"",
          ""5947f92f86f77427344a76b1"",
          ""5947fa2486f77425b47c1a9b"",
          ""5c6bf4aa2e2216001219b0ae"",
          ""5649ae4a4bdc2d1b2b8b4588"",
          ""5998517986f7746017232f7e""
        ],
        ""id"": ""57dc31bc245977596d4ef3d2"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_pistol_grip"",
        ""required"": true
      },
      {
        ""compatibleItemIds"": [
          ""59ecc28286f7746d7a68aa8c"",
          ""5ab626e4d8ce87272e4c6e43"",
          ""57dc347d245977596754e7a1""
        ],
        ""id"": ""57dc31ce245977593d4e1453"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_stock"",
        ""required"": false
      },
      {
        ""compatibleItemIds"": [
          ""6130ca3fd92c473c77020dbd"",
          ""5648ac824bdc2ded0b8b457d""
        ],
        ""id"": ""57dc31e1245977597164366e"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_charge"",
        ""required"": false
      },
      {
        ""compatibleItemIds"": [
          ""564ca9df4bdc2d35148b4569"",
          ""564ca99c4bdc2d16268b4589"",
          ""55d480c04bdc2d1d4e8b456a"",
          ""5cbdaf89ae9215000e5b9c94"",
          ""55d481904bdc2d8c2f8b456a"",
          ""55d482194bdc2d1d4e8b456b"",
          ""55d4837c4bdc2d1d4e8b456c"",
          ""5aaa4194e5b5b055d06310a5"",
          ""5bed61680db834001d2c45ab"",
          ""5bed625c0db834001c062946""
        ],
        ""id"": ""57dc31f2245977596c274b4f"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_magazine"",
        ""required"": false
      },
      {
        ""compatibleItemIds"": [
          ""5ac72e945acfc43f3b691116"",
          ""5ac7655e5acfc40016339a19"",
          ""5649aa744bdc2ded0b8b457e"",
          ""5f633f791b231926f2329f13"",
          ""5943eeeb86f77412d6384f6b"",
          ""5cc9a96cd7f00c011c04e04a"",
          ""615d8f5dd92c473c770212ef"",
          ""5649ab884bdc2ded0b8b457f"",
          ""57dc324a24597759501edc20"",
          ""59bffc1f86f77435b128b872"",
          ""593d493f86f7745e6b2ceb22"",
          ""564caa3d4bdc2d17108b458e"",
          ""57ffb0e42459777d047111c5""
        ],
        ""id"": ""57dc35ce2459775971643671"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_muzzle"",
        ""required"": false
      },
      {
        ""compatibleItemIds"": [
          ""57dc334d245977597164366f"",
          ""5839a7742459773cf9693481""
        ],
        ""id"": ""57dc35fb245977596d4ef3d7"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_reciever"",
        ""required"": false
      },
      {
        ""compatibleItemIds"": [""59d36a0086f7747e673f3946""],
        ""id"": ""59d368ce86f7747e6a5beb03"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_gas_block"",
        ""required"": true
      }
    ]
  },
  {
    ""acceptedAmmunitionIds"": [],
    ""conflictingItemIds"": [],
    ""id"": ""5e81c3cbac2bb513793cdc75"",
    ""maxStackableAmount"": 1,
    ""modSlots"": [
      {
        ""compatibleItemIds"": [
          ""5e81f423763d9f754677bf2e"",
          ""5efb0cabfb3e451d70735af5"",
          ""5efb0fc6aeb21837e749c801"",
          ""5efb0d4f4bc50b58e81710f3"",
          ""5ea2a8e200685063ec28c05a""
        ],
        ""id"": ""5e81c3cbac2bb513793cdc7e"",
        ""maxStackableAmount"": 1,
        ""name"": ""chamber0"",
        ""required"": false
      },
      {
        ""compatibleItemIds"": [
          ""5e81c519cb2b95385c177551"",
          ""5f3e7801153b8571434a924c"",
          ""5f3e77f59103d430b93f94c1""
        ],
        ""id"": ""5e81c3cbac2bb513793cdc77"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_barrel"",
        ""required"": true
      },
      {
        ""compatibleItemIds"": [
          ""5e81c6bf763d9f754677beff"",
          ""5ef366938cef260c0642acad""
        ],
        ""id"": ""5e81c3cbac2bb513793cdc78"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_pistol_grip"",
        ""required"": true
      },
      {
        ""compatibleItemIds"": [
          ""5e81edc13397a21db957f6a1"",
          ""5f3e7823ddc4f03b010e2045""
        ],
        ""id"": ""5e81c3cbac2bb513793cdc79"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_reciever"",
        ""required"": true
      },
      {
        ""compatibleItemIds"": [
          ""5e81c4ca763d9f754677befa"",
          ""5f3e77b26cda304dcc634057"",
          ""5ef3448ab37dfd6af863525c""
        ],
        ""id"": ""5e81c3cbac2bb513793cdc7a"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_magazine"",
        ""required"": false
      },
      {
        ""compatibleItemIds"": [
          ""5ef32e4d1c1fd62aea6a150d"",
          ""5e81c6a2ac2bb513793cdc7f"",
          ""5f3e772a670e2a7b01739a52""
        ],
        ""id"": ""5e8206f4cb2b95385c17759c"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_trigger"",
        ""required"": true
      },
      {
        ""compatibleItemIds"": [
          ""5e81c550763d9f754677befd"",
          ""5f3e76d86cda304dcc634054"",
          ""5ef35f46382a846010715a96"",
          ""5ef35d2ac64c5d0dfc0571b0"",
          ""5ef35bc243cb350a955a7ccd""
        ],
        ""id"": ""5e820703ac2bb513793cdd0d"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_hammer"",
        ""required"": true
      },
      {
        ""compatibleItemIds"": [
          ""5e81c539cb2b95385c177553"",
          ""5f3e777688ca2d00ad199d25"",
          ""5ef3553c43cb350a955a7ccb""
        ],
        ""id"": ""5e82070e763d9f754677bf93"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_catch"",
        ""required"": true
      },
      {
        ""compatibleItemIds"": [""5ef5d994dfbc9f3c660ded95""],
        ""id"": ""5ef5d9bc22584f36a62bc2a6"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_mount_000"",
        ""required"": false
      },
      {
        ""compatibleItemIds"": [""5ef369b08cef260c0642acaf""],
        ""id"": ""5ef5d9c76b0e105bd96c76db"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_mount_001"",
        ""required"": false
      }
    ]
  },
  {
    ""acceptedAmmunitionIds"": [],
    ""conflictingItemIds"": [
      ""5947db3f86f77447880cf76f"",
      ""57486e672459770abd687134"",
      ""5ac733a45acfc400192630e2"",
      ""5649b0544bdc2d1b2b8b458a"",
      ""5ac72e475acfc400180ae6fe"",
      ""59d650cf86f7741b846413a4"",
      ""5a0eb980fcdbcb001a3b00a6"",
      ""59e8977386f77415a553c453"",
      ""5649d9a14bdc2d79388b4580"",
      ""5c82342f2e221644f31c060e"",
      ""576fd4ec2459777f0b518431"",
      ""5c82343a2e221644f31c0611"",
      ""5cf638cbd7f00c06595bc936"",
      ""5a7c74b3e899ef0014332c29"",
      ""591ee00d86f774592f7b841e"",
      ""5d0a29ead7ad1a0026013f27"",
      ""57acb6222459771ec34b5cb0"",
      ""5c61a40d2e2216001403158d"",
      ""5c90c3622e221601da359851""
    ],
    ""id"": ""5d2c76ed48f03532f2136169"",
    ""maxStackableAmount"": 1,
    ""modSlots"": [
      {
        ""compatibleItemIds"": [
          ""57ac965c24597706be5f975c"",
          ""57aca93d2459771f2c7e26db"",
          ""544a3f024bdc2d1d388b4568"",
          ""544a3a774bdc2d3a388b4567"",
          ""5d2dc3e548f035404a1a4798"",
          ""57adff4f24597737f373b6e6"",
          ""5c0517910db83400232ffee5"",
          ""591c4efa86f7741030027726"",
          ""570fd79bd2720bc7458b4583"",
          ""570fd6c2d2720bc6458b457f"",
          ""558022b54bdc2dac148b458d"",
          ""5c07dd120db834001c39092d"",
          ""5c0a2cec0db834001b7ce47d"",
          ""58491f3324597764bc48fa02"",
          ""584924ec24597768f12ae244"",
          ""5b30b0dc5acfc400153b7124"",
          ""6165ac8c290d254f5e6b2f6c"",
          ""60a23797a37c940de7062d02"",
          ""5d2da1e948f035477b1ce2ba"",
          ""5c0505e00db834001b735073"",
          ""609a63b6e2ff132951242d09"",
          ""584984812459776a704a82a6"",
          ""59f9d81586f7744c7506ee62"",
          ""570fd721d2720bc5458b4596"",
          ""57ae0171245977343c27bfcf"",
          ""5dfe6104585a0c3e995c7b82"",
          ""544a3d0a4bdc2d1b388b4567"",
          ""5d1b5e94d7ad1a2b865a96b0"",
          ""609bab8b455afd752b2e6138"",
          ""58d39d3d86f77445bb794ae7"",
          ""616554fe50224f204c1da2aa"",
          ""5c7d55f52e221644f31bff6a"",
          ""616584766ef05c2ce828ef57"",
          ""5b3b6dc75acfc47a8773fb1e"",
          ""615d8d878004cc50514c3233"",
          ""5b2389515acfc4771e1be0c0"",
          ""577d128124597739d65d0e56"",
          ""618b9643526131765025ab35"",
          ""618bab21526131765025ab3f"",
          ""5c86592b2e2216000e69e77c"",
          ""5a37ca54c4a282000d72296a"",
          ""5d0a29fed7ad1a002769ad08"",
          ""5c064c400db834001d23f468"",
          ""58d2664f86f7747fec5834f6"",
          ""57c69dd424597774c03b7bbc"",
          ""5b3b99265acfc4704b4a1afb"",
          ""5aa66a9be5b5b0214e506e89"",
          ""5aa66c72e5b5b00016327c93"",
          ""5c1cdd302e221602b3137250"",
          ""61714b2467085e45ef140b2c"",
          ""6171407e50224f204c1da3c5"",
          ""61713cc4d8e3106d9806c109"",
          ""5b31163c5acfc400153b71cb"",
          ""5a33b652c4a28232996e407c"",
          ""5a33b2c9c4a282000c5a9511"",
          ""59db7eed86f77461f8380365"",
          ""5a1ead28fcdbcb001912fa9f"",
          ""5dff77c759400025ea5150cf""
        ],
        ""id"": ""5d2c76ed48f03532f213616b"",
        ""maxStackableAmount"": 1,
        ""name"": ""mod_scope"",
        ""required"": false
      }
    ]
  },
  {
    ""acceptedAmmunitionIds"": [],
    ""conflictingItemIds"": [
      ""591c4efa86f7741030027726"",
      ""570fd79bd2720bc7458b4583"",
      ""570fd6c2d2720bc6458b457f"",
      ""558022b54bdc2dac148b458d"",
      ""58491f3324597764bc48fa02"",
      ""584924ec24597768f12ae244"",
      ""5b30b0dc5acfc400153b7124"",
      ""60a23797a37c940de7062d02"",
      ""5d2da1e948f035477b1ce2ba"",
      ""5c0505e00db834001b735073"",
      ""609a63b6e2ff132951242d09"",
      ""584984812459776a704a82a6"",
      ""59f9d81586f7744c7506ee62"",
      ""570fd721d2720bc5458b4596"",
      ""5c7d55f52e221644f31bff6a""
    ],
    ""id"": ""61714eec290d254f5e6b2ffc"",
    ""maxStackableAmount"": 1,
    ""modSlots"": []
  }
]";
    }
}