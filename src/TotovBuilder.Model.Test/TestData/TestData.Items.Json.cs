namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public partial class TestData
    {
        public const string ItemsJson = @$"{{
  ""data"": {{
    ""items"": [
      {FakeItemsJson},
      {RealItemsJson}
    ]
  }}
}}";

        /// <summary>
        /// Fake items only for testing purpose.
        /// </summary>
        /// <remarks>
        /// Expression to sort them in Visual Studio Code using the Sort JSON extension :
        /// (a.properties == null && b.properties != null) ? 1 : (a.properties != null && b.properties == null) ? -1 : ((a.properties == null && b.properties == null) || (a.properties != null && b.properties != null && a.properties.__typename === b.properties.__typename)) ? (a.name === b.name ? 0 : (a.name > b.name ? 1 : -1)) : (a.properties?.__typename > b.properties?.__typename) ? 1 : -1
        /// </remarks>
        private const string FakeItemsJson = @"{
    ""categories"": [
      {
        ""id"": ""57bef4c42459772e8d35a53b""
      },
      {
        ""id"": ""543be5f84bdc2dd4348b456a""
      },
      {
        ""id"": ""566162e44bdc2d3f298b4573""
      },
      {
        ""id"": ""54009119af1c881c07000029""
      }
    ],
    ""iconLink"": ""https://assets.tarkov.dev/test-preset-face-shield-alone-icon.webp"",
    ""id"": ""test-preset-face-shield-alone"",
    ""inspectImageLink"": ""https://assets.tarkov.dev/test-preset-face-shield-alone-image.webp"",
    ""link"": ""https://tarkov.dev/item/test-preset-face-shield-alone"",
    ""name"": ""Face shield alone"",
    ""properties"": {
      ""__typename"": ""ItemPropertiesPreset"",
      ""baseItem"": {
        ""id"": ""5a16b7e1fcdbcb00165aa6c9""
      },
      ""moa"": null
    },
    ""shortName"": ""FSA"",
    ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/test-preset-face-shield-alone""
  },
  {
    ""categories"": [
      {
        ""id"": ""56ea9461d2720b67698b456f""
      },
      {
        ""id"": ""550aa4154bdc2dd8348b456b""
      },
      {
        ""id"": ""5448fe124bdc2da5018b4567""
      },
      {
        ""id"": ""566162e44bdc2d3f298b4573""
      },
      {
        ""id"": ""54009119af1c881c07000029""
      }
    ],
    ""iconLink"": ""https://assets.tarkov.dev/test-preset-gas-tube-handguard-icon.webp"",
    ""id"": ""test-preset-gas-tube-handguard"",
    ""inspectImageLink"": ""https://assets.tarkov.dev/test-preset-gas-tube-handguard-image.webp"",
    ""link"": ""https://tarkov.dev/item/test-preset-gas-tube-handguard"",
    ""name"": ""Gas tube + handguard"",
    ""properties"": {
      ""__typename"": ""ItemPropertiesPreset"",
      ""baseItem"": {
        ""id"": ""59d36a0086f7747e673f3946""
      },
      ""moa"": null
    },
    ""shortName"": ""PGT+H"",
    ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/test-preset-gas-tube-handguard""
  },
  {
    ""categories"": [
      {
        ""id"": ""57bef4c42459772e8d35a53b""
      },
      {
        ""id"": ""543be5f84bdc2dd4348b456a""
      },
      {
        ""id"": ""566162e44bdc2d3f298b4573""
      },
      {
        ""id"": ""54009119af1c881c07000029""
      }
    ],
    ""iconLink"": ""https://assets.tarkov.dev/test-preset-magazine-alone-icon.webp"",
    ""id"": ""test-preset-magazine-alone"",
    ""inspectImageLink"": ""https://assets.tarkov.dev/test-preset-magazine-alone-image.webp"",
    ""link"": ""https://tarkov.dev/item/test-preset-magazine-alone"",
    ""name"": ""Magazine alone"",
    ""properties"": {
      ""__typename"": ""ItemPropertiesPreset"",
      ""baseItem"": {
        ""id"": ""5e81c4ca763d9f754677befa""
      },
      ""moa"": null
    },
    ""shortName"": ""MA"",
    ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/test-preset-magazine-alone""
  },
  {
    ""categories"": [
      {
        ""id"": ""55818b224bdc2dde698b456f""
      },
      {
        ""id"": ""55802f3e4bdc2de7118b4584""
      },
      {
        ""id"": ""5448fe124bdc2da5018b4567""
      },
      {
        ""id"": ""566162e44bdc2d3f298b4573""
      },
      {
        ""id"": ""54009119af1c881c07000029""
      }
    ],
    ""iconLink"": ""https://assets.tarkov.dev/test-preset-ring-flashlight-icon.webp"",
    ""id"": ""test-preset-ring-flashlight"",
    ""inspectImageLink"": ""https://assets.tarkov.dev/test-preset-ring-flashlight-image.webp"",
    ""link"": ""https://tarkov.dev/item/test-preset-ring-flashlight"",
    ""name"": ""Ring + flashlight"",
    ""properties"": {
      ""__typename"": ""ItemPropertiesPreset"",
      ""baseItem"": {
        ""id"": ""57d17e212459775a1179a0f5""
      },
      ""moa"": null
    },
    ""shortName"": ""PR+F"",
    ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/test-preset-ring-flashlight""
  },
  {
    ""categories"": [
      {
        ""id"": ""5485a8684bdc2da71d8b4567""
      }
    ],
    ""iconLink"": """",
    ""id"": ""testAmmunition"",
    ""inspectImageLink"": """",
    ""link"": """",
    ""name"": """",
    ""properties"": null,
    ""shortName"": """",
    ""weight"": 0,
    ""wikiLink"": """"
  },
  {
    ""categories"": [
      {
        ""id"": ""5448e54d4bdc2dcc718b4568""
      }
    ],
    ""iconLink"": """",
    ""id"": ""testArmor"",
    ""inspectImageLink"": """",
    ""link"": """",
    ""name"": """",
    ""properties"": null,
    ""shortName"": """",
    ""weight"": 0,
    ""wikiLink"": """"
  },
  {
    ""categories"": [
      {
        ""id"": ""57bef4c42459772e8d35a53b""
      }
    ],
    ""iconLink"": """",
    ""id"": ""testArmorMod"",
    ""inspectImageLink"": """",
    ""link"": """",
    ""name"": """",
    ""properties"": null,
    ""shortName"": """",
    ""weight"": 0,
    ""wikiLink"": """"
  },
  {
    ""categories"": [
      {
        ""id"": ""5448e53e4bdc2d60728b4567""
      }
    ],
    ""iconLink"": """",
    ""id"": ""testBackpack"",
    ""inspectImageLink"": """",
    ""link"": """",
    ""name"": """",
    ""properties"": null,
    ""shortName"": """",
    ""weight"": 0,
    ""wikiLink"": """"
  },
  {
    ""categories"": [
      {
        ""id"": ""5448bf274bdc2dfc2f8b456a""
      }
    ],
    ""iconLink"": """",
    ""id"": ""testContainer"",
    ""inspectImageLink"": """",
    ""link"": """",
    ""name"": """",
    ""properties"": null,
    ""shortName"": """",
    ""weight"": 0,
    ""wikiLink"": """"
  },
  {
    ""categories"": [
      {
        ""id"": ""5448e5724bdc2ddf718b4568""
      }
    ],
    ""iconLink"": """",
    ""id"": ""testEyewear"",
    ""inspectImageLink"": """",
    ""link"": """",
    ""name"": """",
    ""properties"": null,
    ""shortName"": """",
    ""weight"": 0,
    ""wikiLink"": """"
  },
  {
    ""categories"": [
      {
        ""id"": ""543be6564bdc2df4348b4568""
      }
    ],
    ""iconLink"": """",
    ""id"": ""testGrenade"",
    ""inspectImageLink"": """",
    ""link"": """",
    ""name"": """",
    ""properties"": null,
    ""shortName"": """",
    ""weight"": 0,
    ""wikiLink"": """"
  },
  {
    ""categories"": [
      {
        ""id"": ""5a341c4086f77401f2541505""
      }
    ],
    ""iconLink"": """",
    ""id"": ""testHeadwear"",
    ""inspectImageLink"": """",
    ""link"": """",
    ""name"": """",
    ""properties"": null,
    ""shortName"": """",
    ""weight"": 0,
    ""wikiLink"": """"
  },
  {
    ""categories"": [
      {
        ""id"": ""5448bc234bdc2d3c308b4569""
      }
    ],
    ""iconLink"": """",
    ""id"": ""testMagazine"",
    ""inspectImageLink"": """",
    ""link"": """",
    ""name"": """",
    ""properties"": null,
    ""shortName"": """",
    ""weight"": 0,
    ""wikiLink"": """"
  },
  {
    ""categories"": [
      {
        ""id"": ""5447e1d04bdc2dff2f8b4567""
      }
    ],
    ""iconLink"": """",
    ""id"": ""testMeleeWeapon"",
    ""inspectImageLink"": """",
    ""link"": """",
    ""name"": """",
    ""properties"": null,
    ""shortName"": """",
    ""weight"": 0,
    ""wikiLink"": """"
  },
  {
    ""categories"": [
      {
        ""id"": ""55818b224bdc2dde698b456f""
      }
    ],
    ""iconLink"": """",
    ""id"": ""testMod"",
    ""inspectImageLink"": """",
    ""link"": """",
    ""name"": """",
    ""properties"": null,
    ""shortName"": """",
    ""weight"": 0,
    ""wikiLink"": """"
  },
  {
    ""categories"": [
      {
        ""id"": ""5447b5cf4bdc2d65278b4567""
      }
    ],
    ""iconLink"": """",
    ""id"": ""testRangedWeapon"",
    ""inspectImageLink"": """",
    ""link"": """",
    ""name"": """",
    ""properties"": null,
    ""shortName"": """",
    ""weight"": 0,
    ""wikiLink"": """"
  },
  {
    ""categories"": [
      {
        ""id"": ""55818ae44bdc2dde698b456c""
      }
    ],
    ""iconLink"": """",
    ""id"": ""testRangedWeaponMod"",
    ""inspectImageLink"": """",
    ""link"": """",
    ""name"": """",
    ""properties"": null,
    ""shortName"": """",
    ""weight"": 0,
    ""wikiLink"": """"
  },
  {
    ""categories"": [
      {
        ""id"": ""5448e5284bdc2dcb718b4567""
      }
    ],
    ""iconLink"": """",
    ""id"": ""testVest"",
    ""inspectImageLink"": """",
    ""link"": """",
    ""name"": """",
    ""properties"": null,
    ""shortName"": """",
    ""weight"": 0,
    ""wikiLink"": """"
  }";

        /// <summary>
        /// Real items obtained from the API.
        /// </summary>
        /// <remarks>
        /// Exepression to sort them in Visual Studio Code using the Sort JSON extension :
        /// (a.properties == null && b.properties != null) ? 1 : (a.properties != null && b.properties == null) ? -1 : ((a.properties == null && b.properties == null) || (a.properties != null && b.properties != null && a.properties.__typename === b.properties.__typename)) ? (a.name === b.name ? 0 : (a.name > b.name ? 1 : -1)) : (a.properties?.__typename > b.properties?.__typename) ? 1 : -1
        /// </remarks>
        private const string RealItemsJson = @"{
  ""categories"": [
    {
      ""id"": ""5485a8684bdc2da71d8b4567""
    },
    {
      ""id"": ""5661632d4bdc2d903d8b456b""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5d6e6806a4b936088465b17e-icon.webp"",
  ""id"": ""5d6e6806a4b936088465b17e"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5d6e6806a4b936088465b17e-image.webp"",
  ""link"": ""https://tarkov.dev/item/1270-85mm-magnum-buckshot"",
  ""name"": ""12/70 8.5mm Magnum buckshot"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesAmmo"",
    ""accuracyModifier"": -0.15,
    ""armorDamage"": 26,
    ""caliber"": ""Caliber12g"",
    ""damage"": 50,
    ""durabilityBurnFactor"": 1,
    ""fragmentationChance"": 0,
    ""heavyBleedModifier"": 0.1,
    ""initialSpeed"": 385,
    ""lightBleedModifier"": 0.2,
    ""penetrationChance"": 0.05,
    ""penetrationPower"": 2,
    ""projectileCount"": 8,
    ""recoilModifier"": 1.15,
    ""ricochetChance"": 0,
    ""stackMaxSize"": 20,
    ""tracer"": false
  },
  ""shortName"": ""Magnum"",
  ""weight"": 0.059,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/12/70_8.5mm_Magnum_buckshot""
},
{
  ""categories"": [
    {
      ""id"": ""5485a8684bdc2da71d8b4567""
    },
    {
      ""id"": ""5661632d4bdc2d903d8b456b""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/56dff4ecd2720b5f5a8b4568-icon.webp"",
  ""id"": ""56dff4ecd2720b5f5a8b4568"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/56dff4ecd2720b5f5a8b4568-image.webp"",
  ""link"": ""https://tarkov.dev/item/545x39mm-us-gs"",
  ""name"": ""5.45x39mm US gs"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesAmmo"",
    ""accuracyModifier"": 0,
    ""armorDamage"": 33,
    ""caliber"": ""Caliber545x39"",
    ""damage"": 63,
    ""durabilityBurnFactor"": 0.8,
    ""fragmentationChance"": 0.1,
    ""heavyBleedModifier"": 0,
    ""initialSpeed"": 303,
    ""lightBleedModifier"": 0,
    ""penetrationChance"": 0.45,
    ""penetrationPower"": 17,
    ""projectileCount"": 1,
    ""recoilModifier"": -0.15,
    ""ricochetChance"": 0.4,
    ""stackMaxSize"": 60,
    ""tracer"": false
  },
  ""shortName"": ""US"",
  ""weight"": 0.01,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/5.45x39mm_US_gs""
},
{
  ""categories"": [
    {
      ""id"": ""5485a8684bdc2da71d8b4567""
    },
    {
      ""id"": ""5661632d4bdc2d903d8b456b""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/601aa3d2b2bcb34913271e6d-icon.webp"",
  ""id"": ""601aa3d2b2bcb34913271e6d"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/601aa3d2b2bcb34913271e6d-image.webp"",
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
    ""initialSpeed"": 875,
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
  ""weight"": 0.015,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/7.62x39mm_MAI_AP""
},
{
  ""categories"": [
    {
      ""id"": ""5485a8684bdc2da71d8b4567""
    },
    {
      ""id"": ""5661632d4bdc2d903d8b456b""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5c3df7d588a4501f290594e5-icon.webp"",
  ""id"": ""5c3df7d588a4501f290594e5"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5c3df7d588a4501f290594e5-image.webp"",
  ""link"": ""https://tarkov.dev/item/9x19mm-green-tracer"",
  ""name"": ""9x19mm Green Tracer"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesAmmo"",
    ""accuracyModifier"": -0.05,
    ""armorDamage"": 33,
    ""caliber"": ""Caliber9x19PARA"",
    ""damage"": 58,
    ""durabilityBurnFactor"": 1.15,
    ""fragmentationChance"": 0.15,
    ""heavyBleedModifier"": 0,
    ""initialSpeed"": 365,
    ""lightBleedModifier"": 0,
    ""penetrationChance"": 0.2,
    ""penetrationPower"": 14,
    ""projectileCount"": 1,
    ""recoilModifier"": -0.06,
    ""ricochetChance"": 0.05,
    ""stackMaxSize"": 50,
    ""tracer"": true
  },
  ""shortName"": ""GT"",
  ""weight"": 0.006,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/9x19mm_Green_Tracer""
},
{
  ""categories"": [
    {
      ""id"": ""5485a8684bdc2da71d8b4567""
    },
    {
      ""id"": ""5661632d4bdc2d903d8b456b""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5efb0da7a29a85116f6ea05f-icon.webp"",
  ""id"": ""5efb0da7a29a85116f6ea05f"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5efb0da7a29a85116f6ea05f-image.webp"",
  ""link"": ""https://tarkov.dev/item/9x19mm-pbp-gzh"",
  ""name"": ""9x19mm PBP gzh"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesAmmo"",
    ""accuracyModifier"": 0.05,
    ""armorDamage"": 55,
    ""caliber"": ""Caliber9x19PARA"",
    ""damage"": 52,
    ""durabilityBurnFactor"": 2.7,
    ""fragmentationChance"": 0.05,
    ""heavyBleedModifier"": 0,
    ""initialSpeed"": 560,
    ""lightBleedModifier"": 0,
    ""penetrationChance"": 0.4,
    ""penetrationPower"": 39,
    ""projectileCount"": 1,
    ""recoilModifier"": 0.05,
    ""ricochetChance"": 0.2,
    ""stackMaxSize"": 50,
    ""tracer"": false
  },
  ""shortName"": ""PBP"",
  ""weight"": 0.009,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/9x19mm_PBP_gzh""
},
{
  ""iconLink"": ""https://assets.tarkov.dev/5fc382a9d724d907e2077dab-icon.webp"",
  ""id"": ""5fc382a9d724d907e2077dab"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5fc382a9d724d907e2077dab-image.webp"",
  ""link"": ""https://tarkov.dev/item/338-lapua-magnum-ap"",
  ""name"": "".338 Lapua Magnum AP"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesAmmo"",
    ""accuracyModifier"": 0,
    ""armorDamage"": 89,
    ""caliber"": ""Caliber86x70"",
    ""damage"": 115,
    ""durabilityBurnFactor"": 2.4,
    ""fragmentationChance"": 0.13,
    ""heavyBleedModifier"": 0.55,
    ""initialSpeed"": 849,
    ""lightBleedModifier"": 0.2,
    ""penetrationChance"": 0.9,
    ""penetrationPower"": 79,
    ""projectileCount"": 1,
    ""recoilModifier"": 0.1,
    ""ricochetChance"": 0.3,
    ""stackMaxSize"": 30,
    ""tracer"": false
  },
  ""shortName"": ""AP"",
  ""weight"": 0.049,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/.338_Lapua_Magnum_AP"",
  ""conflictingItems"": [],
  ""categories"": [
    {
      ""id"": ""5485a8684bdc2da71d8b4567"",
      ""name"": ""Ammo""
    },
    {
      ""id"": ""5661632d4bdc2d903d8b456b"",
      ""name"": ""Stackable item""
    },
    {
      ""id"": ""54009119af1c881c07000029"",
      ""name"": ""Item""
    }
  ]
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-icon.webp"",
  ""id"": ""545cdb794bdc2d3a198b456a"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-image.webp"",
  ""link"": ""https://tarkov.dev/item/6b43-zabralo-sh-body-armor-digital-flora"",
  ""name"": ""6B43 Zabralo-Sh body armor (Digital Flora)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesArmor"",
    ""armorSlots"": [
      {
        ""__typename"": ""ItemArmorSlotOpen"",
        ""nameId"": ""Front_plate"",
        ""zones"": [
          ""FR. PLATE""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotOpen"",
        ""nameId"": ""Back_plate"",
        ""zones"": [
          ""BCK. PLATE""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotOpen"",
        ""nameId"": ""Left_side_plate"",
        ""zones"": [
          ""L. PLATE""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotOpen"",
        ""nameId"": ""Right_side_plate"",
        ""zones"": [
          ""R. PLATE""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Soft_armor_front"",
        ""zones"": [
          ""Chest"",
          ""Stomach""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Soft_armor_back"",
        ""zones"": [
          ""Stomach, Lower back"",
          ""Thorax, Upper back""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Soft_armor_left"",
        ""zones"": [
          ""Stomach, Left Side""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""soft_armor_right"",
        ""zones"": [
          ""Stomach, Right Side""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Collar"",
        ""zones"": [
          ""Head, Neck"",
          ""Head, Throat""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Shoulder_l"",
        ""zones"": [
          ""Left arm, Shoulder""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Shoulder_r"",
        ""zones"": [
          ""Right arm, Shoulder""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Groin"",
        ""zones"": [
          ""Stomach, Groin""
        ]
      }
    ],
    ""class"": 6,
    ""durability"": 510,
    ""ergoPenalty"": -0.1,
    ""material"": {
      ""id"": ""Aramid""
    },
    ""speedPenalty"": -0.115,
    ""turnPenalty"": -0.055
  },
  ""shortName"": ""6B43"",
  ""weight"": 10.8,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/6B43_Zabralo-Sh_body_armor_(Digital_Flora)""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5648a7494bdc2d9d488b4583-icon.webp"",
  ""id"": ""5648a7494bdc2d9d488b4583"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5648a7494bdc2d9d488b4583-image.webp"",
  ""link"": ""https://tarkov.dev/item/paca-soft-armor"",
  ""name"": ""PACA Soft Armor"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesArmor"",
    ""armorSlots"": [
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Soft_armor_front"",
        ""zones"": [
          ""Stomach"",
          ""Chest""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Soft_armor_back"",
        ""zones"": [
          ""Stomach, Lower back"",
          ""Thorax, Upper back""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Soft_armor_left"",
        ""zones"": [
          ""Stomach, Left Side""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""soft_armor_right"",
        ""zones"": [
          ""Stomach, Right Side""
        ]
      }
    ],
    ""class"": 2,
    ""durability"": 100,
    ""ergoPenalty"": -0.01,
    ""material"": {
      ""id"": ""Aramid""
    },
    ""speedPenalty"": -0.01,
    ""turnPenalty"": 0
  },
  ""shortName"": ""PACA"",
  ""weight"": 3.5,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/PACA_Soft_Armor""
},
{
  ""categories"": [
    {
      ""id"": ""57bef4c42459772e8d35a53b""
    },
    {
      ""id"": ""543be5f84bdc2dd4348b456a""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [
    {
      ""id"": ""5a16ba61fcdbcb098008728a""
    },
    {
      ""id"": ""5a16b672fcdbcb001912fa83""
    },
    {
      ""id"": ""5a16b7e1fcdbcb00165aa6c9""
    },
    {
      ""id"": ""5aa7e3abe5b5b000171d064d""
    },
    {
      ""id"": ""5c0e66e2d174af02a96252f4""
    },
    {
      ""id"": ""5e00cdd986f7747473332240""
    }
  ],
  ""iconLink"": ""https://assets.tarkov.dev/5ea18c84ecf1982c7712d9a2-icon.webp"",
  ""id"": ""5ea18c84ecf1982c7712d9a2"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5ea18c84ecf1982c7712d9a2-image.webp"",
  ""link"": ""https://tarkov.dev/item/diamond-age-bastion-helmet-armor-plate"",
  ""name"": ""Diamond Age Bastion helmet armor plate"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesArmorAttachment"",
    ""blindnessProtection"": 0,
    ""class"": 6,
    ""durability"": 40,
    ""ergoPenalty"": -0.05,
    ""zones"": [
      ""Head, Nape"",
      ""Head, Top of the head""
    ],
    ""material"": {
      ""id"": ""Ceramic""
    },
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5c0558060db834001b735271""
            },
            {
              ""id"": ""5a16b8a9fcdbcb00165aa6ca""
            }
          ]
        },
        ""nameId"": ""mod_nvg""
      }
    ],
    ""speedPenalty"": 0,
    ""turnPenalty"": -0.06
  },
  ""shortName"": ""Bastion plate"",
  ""weight"": 0.99,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Diamond_Age_Bastion_helmet_armor_plate""
},
{
  ""categories"": [
    {
      ""id"": ""644120aa86ffbe10ee032b6f""
    },
    {
      ""id"": ""57bef4c42459772e8d35a53b""
    },
    {
      ""id"": ""543be5f84bdc2dd4348b456a""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/64afdcb83efdfea28601d041-icon.webp"",
  ""id"": ""64afdcb83efdfea28601d041"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/64afdcb83efdfea28601d041-image.webp"",
  ""link"": ""https://tarkov.dev/item/esapi-level-iv-ballistic-plate"",
  ""name"": ""ESAPI level IV ballistic plate"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesArmorAttachment"",
    ""blindnessProtection"": 0,
    ""class"": 6,
    ""durability"": 55,
    ""ergoPenalty"": -0.015,
    ""zones"": [
      ""FR. PLATE"",
      ""BCK. PLATE""
    ],
    ""material"": {
      ""id"": ""Ceramic""
    },
    ""slots"": [],
    ""speedPenalty"": -0.015,
    ""turnPenalty"": -0.005
  },
  ""shortName"": ""ESAPI IV"",
  ""weight"": 3.2,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/ESAPI_level_IV_ballistic_plate""
},
{
  ""categories"": [
    {
      ""id"": ""644120aa86ffbe10ee032b6f""
    },
    {
      ""id"": ""57bef4c42459772e8d35a53b""
    },
    {
      ""id"": ""543be5f84bdc2dd4348b456a""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/654a4a964b446df1ad03f192-icon.webp"",
  ""id"": ""654a4a964b446df1ad03f192"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/654a4a964b446df1ad03f192-image.webp"",
  ""link"": ""https://tarkov.dev/item/granit-4rs-ballistic-plates-back"",
  ""name"": ""Granit 4RS ballistic plates (Back)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesArmorAttachment"",
    ""blindnessProtection"": 0,
    ""class"": 6,
    ""durability"": 50,
    ""ergoPenalty"": -0.01,
    ""zones"": [
      ""BCK. PLATE""
    ],
    ""material"": {
      ""id"": ""Ceramic""
    },
    ""slots"": [],
    ""speedPenalty"": -0.02,
    ""turnPenalty"": -0.01
  },
  ""shortName"": ""Granit 4RS Back"",
  ""weight"": 3.8,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Granit_4RS_ballistic_plates_(Back)""
},
{
  ""categories"": [
    {
      ""id"": ""644120aa86ffbe10ee032b6f""
    },
    {
      ""id"": ""57bef4c42459772e8d35a53b""
    },
    {
      ""id"": ""543be5f84bdc2dd4348b456a""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/64afc71497cf3a403c01ff38-icon.webp"",
  ""id"": ""64afc71497cf3a403c01ff38"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/64afc71497cf3a403c01ff38-image.webp"",
  ""link"": ""https://tarkov.dev/item/granit-br5-ballistic-plate"",
  ""name"": ""Granit Br5 ballistic plate"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesArmorAttachment"",
    ""blindnessProtection"": 0,
    ""class"": 6,
    ""durability"": 60,
    ""ergoPenalty"": -0.015,
    ""zones"": [
      ""F. PLATE"",
      ""BCK. PLATE""
    ],
    ""material"": {
      ""id"": ""Ceramic""
    },
    ""slots"": [],
    ""speedPenalty"": -0.02,
    ""turnPenalty"": -0.015
  },
  ""shortName"": ""Granit Br5"",
  ""weight"": 3.3,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Granit_Br5_ballistic_plate""
},
{
  ""categories"": [
    {
      ""id"": ""644120aa86ffbe10ee032b6f""
    },
    {
      ""id"": ""57bef4c42459772e8d35a53b""
    },
    {
      ""id"": ""543be5f84bdc2dd4348b456a""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/64afd81707e2cf40e903a316-icon.webp"",
  ""id"": ""64afd81707e2cf40e903a316"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/64afd81707e2cf40e903a316-image.webp"",
  ""link"": ""https://tarkov.dev/item/granit-ballistic-plate-side"",
  ""name"": ""Granit ballistic plate (Side)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesArmorAttachment"",
    ""blindnessProtection"": 0,
    ""class"": 6,
    ""durability"": 20,
    ""ergoPenalty"": 0,
    ""zones"": [
      ""L. PLATE"",
      ""L. PLATE"",
      ""R. PLATE"",
      ""R. PLATE""
    ],
    ""material"": {
      ""id"": ""Ceramic""
    },
    ""slots"": [],
    ""speedPenalty"": -0.0075,
    ""turnPenalty"": -0.0075
  },
  ""shortName"": ""Granit Side"",
  ""weight"": 1.3,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Granit_ballistic_plate_(Side)""
},
{
  ""categories"": [
    {
      ""id"": ""57bef4c42459772e8d35a53b""
    },
    {
      ""id"": ""543be5f84bdc2dd4348b456a""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [
    {
      ""id"": ""5c0e66e2d174af02a96252f4""
    },
    {
      ""id"": ""5c0696830db834001d23f5da""
    },
    {
      ""id"": ""5c066e3a0db834001b7353f0""
    },
    {
      ""id"": ""5c0558060db834001b735271""
    },
    {
      ""id"": ""57235b6f24597759bf5a30f1""
    },
    {
      ""id"": ""5c110624d174af029e69734c""
    },
    {
      ""id"": ""5a16b8a9fcdbcb00165aa6ca""
    },
    {
      ""id"": ""5a398b75c4a282000a51a266""
    },
    {
      ""id"": ""5a398ab9c4a282000c5a9842""
    }
  ],
  ""iconLink"": ""https://assets.tarkov.dev/5a16b7e1fcdbcb00165aa6c9-icon.webp"",
  ""id"": ""5a16b7e1fcdbcb00165aa6c9"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a16b7e1fcdbcb00165aa6c9-image.webp"",
  ""link"": ""https://tarkov.dev/item/ops-core-fast-multi-hit-ballistic-face-shield"",
  ""name"": ""Ops-Core FAST multi-hit ballistic face shield"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesArmorAttachment"",
    ""blindnessProtection"": 0.1,
    ""class"": 3,
    ""durability"": 40,
    ""ergoPenalty"": -0.04,
    ""zones"": [
      ""Head, Eyes"",
      ""Head, Face"",
      ""Head, Jaws""
    ],
    ""material"": {
      ""id"": ""Glass""
    },
    ""slots"": [],
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
    },
    {
      ""id"": ""566168634bdc2d144c8b456c""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5ab8ebf186f7742d8b372e80-icon.webp"",
  ""id"": ""5ab8ebf186f7742d8b372e80"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5ab8ebf186f7742d8b372e80-image.webp"",
  ""link"": ""https://tarkov.dev/item/sso-attack-2-raid-backpack-khaki"",
  ""name"": ""SSO Attack 2 raid backpack (Khaki)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesBackpack"",
    ""capacity"": 35,
    ""ergoPenalty"": -0.07,
    ""speedPenalty"": -0.05,
    ""turnPenalty"": -0.03
  },
  ""shortName"": ""Attack 2"",
  ""weight"": 2.8,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/SSO_Attack_2_raid_backpack_(Khaki)""
},
{
  ""categories"": [
    {
      ""id"": ""555ef6e44bdc2de9068b457e""
    },
    {
      ""id"": ""55802f4a4bdc2ddb688b4569""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [
    {
      ""id"": ""5c59529a2e221602b177d160""
    },
    {
      ""id"": ""5c5db6302e2216000e5e47f0""
    },
    {
      ""id"": ""5c5db63a2e2216000f1b284a""
    }
  ],
  ""iconLink"": ""https://assets.tarkov.dev/58aeaaa886f7744fc1560f81-icon.webp"",
  ""id"": ""58aeaaa886f7744fc1560f81"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58aeaaa886f7744fc1560f81-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-sd-9x19-165mm-barrel"",
  ""name"": ""MPX-SD 9x19 165mm barrel"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesBarrel"",
    ""ergonomics"": -3,
    ""recoilModifier"": -0.02,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""58aeac1b86f77457c419f475""
            }
          ]
        },
        ""nameId"": ""mod_muzzle""
      }
    ]
  },
  ""shortName"": ""MPXSD 165mm"",
  ""weight"": 0.18,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX-SD_9x19_165mm_barrel""
},
{
  ""categories"": [
    {
      ""id"": ""5448e5284bdc2dcb718b4567""
    },
    {
      ""id"": ""566168634bdc2d144c8b456c""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/61bc85697113f767765c7fe7-icon.webp"",
  ""id"": ""61bc85697113f767765c7fe7"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/61bc85697113f767765c7fe7-image.webp"",
  ""link"": ""https://tarkov.dev/item/eagle-industries-mmac-plate-carrier-ranger-green"",
  ""name"": ""Eagle Industries MMAC plate carrier (Ranger Green)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesChestRig"",
    ""armorSlots"": [
      {
        ""__typename"": ""ItemArmorSlotOpen"",
        ""nameId"": ""Front_plate"",
        ""zones"": [
          ""F. PLATE""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotOpen"",
        ""nameId"": ""Back_plate"",
        ""zones"": [
          ""BCK. PLATE""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotOpen"",
        ""nameId"": ""Left_side_plate"",
        ""zones"": [
          ""L. PLATE""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotOpen"",
        ""nameId"": ""Right_side_plate"",
        ""zones"": [
          ""R. PLATE""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Soft_armor_front"",
        ""zones"": []
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Soft_armor_back"",
        ""zones"": []
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Soft_armor_left"",
        ""zones"": [
          ""Stomach, Left Side""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""soft_armor_right"",
        ""zones"": [
          ""Stomach, Right Side""
        ]
      }
    ],
    ""capacity"": 14,
    ""class"": 4,
    ""durability"": 144,
    ""ergoPenalty"": -0.01,
    ""material"": {
      ""id"": ""Aramid""
    },
    ""speedPenalty"": -0.01,
    ""turnPenalty"": -0.01
  },
  ""shortName"": ""MMAC"",
  ""weight"": 2.83,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Eagle_Industries_MMAC_plate_carrier_(Ranger_Green)""
},
{
  ""categories"": [
    {
      ""id"": ""5448e5284bdc2dcb718b4567""
    },
    {
      ""id"": ""566168634bdc2d144c8b456c""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/572b7adb24597762ae139821-icon.webp"",
  ""id"": ""572b7adb24597762ae139821"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/572b7adb24597762ae139821-image.webp"",
  ""link"": ""https://tarkov.dev/item/scav-vest"",
  ""name"": ""Scav Vest"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesChestRig"",
    ""armorSlots"": null,
    ""capacity"": 6,
    ""class"": null,
    ""durability"": null,
    ""ergoPenalty"": 0,
    ""material"": null,
    ""speedPenalty"": 0,
    ""turnPenalty"": 0
  },
  ""shortName"": ""Scav Vest"",
  ""weight"": 0.4,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Scav_Vest""
},
{
  ""categories"": [
    {
      ""id"": ""5448bf274bdc2dfc2f8b456a""
    },
    {
      ""id"": ""566168634bdc2d144c8b456c""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5c093ca986f7740a1867ab12-icon.webp"",
  ""id"": ""5c093ca986f7740a1867ab12"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5c093ca986f7740a1867ab12-image.webp"",
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
      ""id"": ""5795f317245977243854e041""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5783c43d2459774bbe137486-icon.webp"",
  ""id"": ""5783c43d2459774bbe137486"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5783c43d2459774bbe137486-image.webp"",
  ""link"": ""https://tarkov.dev/item/simple-wallet"",
  ""name"": ""Simple wallet"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesContainer"",
    ""capacity"": 4
  },
  ""shortName"": ""Wallet"",
  ""weight"": 0.15,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Simple_wallet""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5b432be65acfc433000ed01f-icon.webp"",
  ""id"": ""5b432be65acfc433000ed01f"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5b432be65acfc433000ed01f-image.webp"",
  ""link"": ""https://tarkov.dev/item/6b34-anti-fragmentation-glasses"",
  ""name"": ""6B34 anti-fragmentation glasses"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesGlasses"",
    ""blindnessProtection"": 0.1,
    ""class"": 0,
    ""durability"": 0,
    ""material"": {
      ""id"": ""UHMWPE""
    }
  },
  ""shortName"": ""6B34"",
  ""weight"": 0.12,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/6B34_anti-fragmentation_glasses""
},
{
  ""categories"": [
    {
      ""id"": ""5448e5724bdc2ddf718b4568"",
      ""name"": ""Vis. observ. device""
    },
    {
      ""id"": ""57bef4c42459772e8d35a53b"",
      ""name"": ""Armored equipment""
    },
    {
      ""id"": ""543be5f84bdc2dd4348b456a"",
      ""name"": ""Equipment""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573"",
      ""name"": ""Compound item""
    },
    {
      ""id"": ""54009119af1c881c07000029"",
      ""name"": ""Item""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/603409c80ca681766b6a0fb2-icon.webp"",
  ""id"": ""603409c80ca681766b6a0fb2"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/603409c80ca681766b6a0fb2-image.webp"",
  ""link"": ""https://tarkov.dev/item/npp-klass-condor-glasses"",
  ""name"": ""NPP KlASS Condor glasses"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesGlasses"",
    ""blindnessProtection"": 0.1,
    ""class"": 1,
    ""durability"": 25,
    ""material"": {
      ""id"": ""Glass""
    }
  },
  ""shortName"": ""Condor"",
  ""weight"": 0.03,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/NPP_KlASS_Condor_glasses""
},
{
  ""categories"": [
    {
      ""id"": ""543be6564bdc2df4348b4568""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5a0c27731526d80618476ac4-icon.webp"",
  ""id"": ""5a0c27731526d80618476ac4"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a0c27731526d80618476ac4-image.webp"",
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
      ""id"": ""543be6564bdc2df4348b4568""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5e32f56fcb6d5863cc5e5ee4-icon.webp"",
  ""id"": ""5e32f56fcb6d5863cc5e5ee4"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5e32f56fcb6d5863cc5e5ee4-image.webp"",
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
      ""id"": ""5645bcb74bdc2ded0b8b4578""
    },
    {
      ""id"": ""543be5f84bdc2dd4348b456a""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/628e4e576d783146b124c64d-icon.webp"",
  ""id"": ""628e4e576d783146b124c64d"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/628e4e576d783146b124c64d-image.webp"",
  ""link"": ""https://tarkov.dev/item/peltor-comtac-4-hybrid-headset-coyote-brown"",
  ""name"": ""Peltor ComTac 4 Hybrid headset (Coyote Brown)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesHeadphone""
  },
  ""shortName"": ""ComTac 4"",
  ""weight"": 0.6,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Peltor_ComTac_4_Hybrid_headset_(Coyote_Brown)""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5bd073c986f7747f627e796c-icon.webp"",
  ""id"": ""5bd073c986f7747f627e796c"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5bd073c986f7747f627e796c-image.webp"",
  ""link"": ""https://tarkov.dev/item/kotton-beanie"",
  ""name"": ""Kotton beanie"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesHeadwear"",
    ""slots"": []
  },
  ""shortName"": ""Kotton"",
  ""weight"": 0.2,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Kotton_beanie""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5a16bb52fcdbcb001a3b00dc-icon.webp"",
  ""id"": ""5a16bb52fcdbcb001a3b00dc"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a16bb52fcdbcb001a3b00dc-image.webp"",
  ""link"": ""https://tarkov.dev/item/wilcox-skull-lock-head-mount"",
  ""name"": ""Wilcox Skull Lock head mount"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesHeadwear"",
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5a16b8a9fcdbcb00165aa6ca""
            }
          ]
        },
        ""nameId"": ""mod_nvg""
      }
    ]
  },
  ""shortName"": ""Skull Lock"",
  ""weight"": 0.5,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Wilcox_Skull_Lock_head_mount""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/59ef13ca86f77445fd0e2483-icon.webp"",
  ""id"": ""59ef13ca86f77445fd0e2483"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/59ef13ca86f77445fd0e2483-image.webp"",
  ""link"": ""https://tarkov.dev/item/jack-o-lantern-tactical-pumpkin-helmet"",
  ""name"": ""Jack-o'-lantern tactical pumpkin helmet"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesHelmet"",
    ""armorSlots"": [],
    ""blocksHeadset"": true,
    ""class"": 2,
    ""deafening"": ""Low"",
    ""durability"": 40,
    ""ergoPenalty"": 0,
    ""material"": {
      ""id"": ""UHMWPE""
    },
    ""ricochetX"": 0,
    ""slots"": [],
    ""speedPenalty"": 0,
    ""turnPenalty"": -0.01
  },
  ""shortName"": ""Pumpkin"",
  ""weight"": 1.2,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Jack-o%27-lantern_tactical_pumpkin_helmet""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5e4bfc1586f774264f7582d3-icon.webp"",
  ""id"": ""5e4bfc1586f774264f7582d3"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5e4bfc1586f774264f7582d3-image.webp"",
  ""link"": ""https://tarkov.dev/item/msa-gallet-tc-800-high-cut-combat-helmet-black"",
  ""name"": ""MSA Gallet TC 800 High Cut combat helmet (Black)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesHelmet"",
    ""armorSlots"": [
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Helmet_top"",
        ""zones"": [
          ""Head, Top of the head""
        ]
      },
      {
        ""__typename"": ""ItemArmorSlotLocked"",
        ""nameId"": ""Helmet_back"",
        ""zones"": [
          ""Head, Nape""
        ]
      }
    ],
    ""blocksHeadset"": false,
    ""class"": 4,
    ""deafening"": ""None"",
    ""durability"": 0,
    ""ergoPenalty"": -0.01,
    ""material"": {
      ""id"": ""Combined""
    },
    ""ricochetX"": 0.9,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5a16b672fcdbcb001912fa83""
            },
            {
              ""id"": ""5a16b7e1fcdbcb00165aa6c9""
            }
          ]
        },
        ""nameId"": ""mod_equipment_000""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5c0558060db834001b735271""
            },
            {
              ""id"": ""5a16b8a9fcdbcb00165aa6ca""
            }
          ]
        },
        ""nameId"": ""mod_nvg""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5a398b75c4a282000a51a266""
            },
            {
              ""id"": ""5a398ab9c4a282000c5a9842""
            }
          ]
        },
        ""nameId"": ""mod_mount""
      }
    ],
    ""speedPenalty"": 0,
    ""turnPenalty"": -0.02
  },
  ""shortName"": ""TC 800"",
  ""weight"": 1.17,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MSA_Gallet_TC_800_High_Cut_combat_helmet_(Black)""
},
{
  ""categories"": [
    {
      ""id"": ""5c164d2286f774194c5e69fa""
    },
    {
      ""id"": ""543be5e94bdc2df1348b4568""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5c1d0c5f86f7744bb2683cf0-icon.webp"",
  ""id"": ""5c1d0c5f86f7744bb2683cf0"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5c1d0c5f86f7744bb2683cf0-image.webp"",
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
      ""id"": ""5448bc234bdc2d3c308b4569""
    },
    {
      ""id"": ""55802f3e4bdc2de7118b4584""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/564ca99c4bdc2d16268b4589-icon.webp"",
  ""id"": ""564ca99c4bdc2d16268b4589"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/564ca99c4bdc2d16268b4589-image.webp"",
  ""link"": ""https://tarkov.dev/item/ak-74-545x39-6l20-30-round-magazine"",
  ""name"": ""AK-74 5.45x39 6L20 30-round magazine"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesMagazine"",
    ""allowedAmmo"": [
      {
        ""id"": ""5c0d5e4486f77478390952fe""
      },
      {
        ""id"": ""61962b617c6c7b169525f168""
      },
      {
        ""id"": ""56dfef82d2720bbd668b4567""
      },
      {
        ""id"": ""56dff026d2720bb8668b4567""
      },
      {
        ""id"": ""56dff061d2720bb5668b4567""
      },
      {
        ""id"": ""56dff0bed2720bb0668b4567""
      },
      {
        ""id"": ""56dff216d2720bbd668b4568""
      },
      {
        ""id"": ""56dff2ced2720bb4668b4567""
      },
      {
        ""id"": ""56dff338d2720bbd668b4569""
      },
      {
        ""id"": ""56dff3afd2720bba668b4567""
      },
      {
        ""id"": ""56dff421d2720b5f5a8b4567""
      },
      {
        ""id"": ""56dff4a2d2720bbd668b456a""
      },
      {
        ""id"": ""56dff4ecd2720b5f5a8b4568""
      }
    ],
    ""ammoCheckModifier"": 0,
    ""capacity"": 30,
    ""ergonomics"": -3,
    ""loadModifier"": 0,
    ""malfunctionChance"": 0.07,
    ""slots"": []
  },
  ""shortName"": ""6L20"",
  ""weight"": 0.215,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AK-74_5.45x39_6L20_30-round_magazine""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5e81c4ca763d9f754677befa-icon.webp"",
  ""id"": ""5e81c4ca763d9f754677befa"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5e81c4ca763d9f754677befa-image.webp"",
  ""link"": ""https://tarkov.dev/item/m1911a1-45-acp-7-round-magazine"",
  ""name"": ""M1911A1 .45 ACP 7-round magazine"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesMagazine"",
    ""allowedAmmo"": [
      {
        ""id"": ""5e81f423763d9f754677bf2e""
      },
      {
        ""id"": ""5efb0cabfb3e451d70735af5""
      },
      {
        ""id"": ""5efb0fc6aeb21837e749c801""
      },
      {
        ""id"": ""5efb0d4f4bc50b58e81710f3""
      },
      {
        ""id"": ""5ea2a8e200685063ec28c05a""
      }
    ],
    ""ammoCheckModifier"": -0.2,
    ""capacity"": 7,
    ""ergonomics"": -1,
    ""loadModifier"": -0.25,
    ""malfunctionChance"": 0.04,
    ""slots"": []
  },
  ""shortName"": ""1911"",
  ""weight"": 0.16,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/M1911A1_.45_ACP_7-round_magazine""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5894a05586f774094708ef75-icon.webp"",
  ""id"": ""5894a05586f774094708ef75"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5894a05586f774094708ef75-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-9x19-30-round-magazine"",
  ""name"": ""MPX 9x19 30-round magazine"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesMagazine"",
    ""allowedAmmo"": [
      {
        ""id"": ""5efb0da7a29a85116f6ea05f""
      },
      {
        ""id"": ""5c3df7d588a4501f290594e5""
      },
      {
        ""id"": ""58864a4f2459770fcc257101""
      },
      {
        ""id"": ""56d59d3ad2720bdb418b4577""
      },
      {
        ""id"": ""5c925fa22e221601da359b7b""
      },
      {
        ""id"": ""5a3c16fe86f77452b62de32a""
      },
      {
        ""id"": ""5efb0e16aeb21837e749c7ff""
      },
      {
        ""id"": ""5c0d56a986f774449d5de529""
      },
      {
        ""id"": ""64b7bbb74b75259c590fa897""
      }
    ],
    ""ammoCheckModifier"": -0.5,
    ""capacity"": 30,
    ""ergonomics"": -3,
    ""loadModifier"": 0,
    ""malfunctionChance"": 0.05,
    ""slots"": []
  },
  ""shortName"": ""MPX"",
  ""weight"": 0.17,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX_9x19_30-round_magazine""
},
{
  ""categories"": [
    {
      ""id"": ""5447e1d04bdc2dff2f8b4567""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5c0126f40db834002a125382-icon.webp"",
  ""id"": ""5c0126f40db834002a125382"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5c0126f40db834002a125382-image.webp"",
  ""link"": ""https://tarkov.dev/item/red-rebel-ice-pick"",
  ""name"": ""Red Rebel ice pick"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesMelee"",
    ""hitRadius"": 0.6,
    ""slashDamage"": 29,
    ""stabDamage"": 35
  },
  ""shortName"": ""RedRebel"",
  ""weight"": 0.65,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Red_Rebel_ice_pick""
},
{
  ""categories"": [
    {
      ""id"": ""5a2c3a9486f774688b05e574""
    },
    {
      ""id"": ""55818aeb4bdc2ddc698b456a""
    },
    {
      ""id"": ""5448fe7a4bdc2d6f028b456b""
    },
    {
      ""id"": ""550aa4154bdc2dd8348b456b""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57235b6f24597759bf5a30f1-icon.webp"",
  ""id"": ""57235b6f24597759bf5a30f1"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57235b6f24597759bf5a30f1-image.webp"",
  ""link"": ""https://tarkov.dev/item/anpvs-14-night-vision-monocular"",
  ""name"": ""AN/PVS-14 Night Vision Monocular"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesNightVision""
  },
  ""shortName"": ""PVS-14"",
  ""weight"": 0.65,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AN/PVS-14_Night_Vision_Monocular""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-icon.webp"",
  ""id"": ""65766adc234b9f6e050a431a"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-image.webp"",
  ""link"": ""https://tarkov.dev/item/6b43-zabralo-sh-body-armor-digital-flora-default"",
  ""name"": ""6B43 Zabralo-Sh body armor (Digital Flora) Default"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesPreset"",
    ""baseItem"": {
      ""id"": ""545cdb794bdc2d3a198b456a""
    },
    ""moa"": null
  },
  ""shortName"": ""6B43 Default"",
  ""weight"": 20,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/6B43_Zabralo-Sh_body_armor_(Digital_Flora)""
},
{
  ""categories"": [
    {
      ""id"": ""5447b5fc4bdc2d87278b4567""
    },
    {
      ""id"": ""5422acb9af1c889c16000029""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/618aaeb931ddad66c15eb7e9-icon.webp"",
  ""id"": ""618aaeb931ddad66c15eb7e9"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/618aaeb931ddad66c15eb7e9-image.webp"",
  ""link"": ""https://tarkov.dev/item/as-val-9x39-special-assault-rifle-kobra"",
  ""name"": ""AS VAL 9x39 special assault rifle Kobra"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesPreset"",
    ""baseItem"": {
      ""id"": ""57c44b372459772d2b39b8ce""
    },
    ""moa"": 3.44
  },
  ""shortName"": ""AS VAL Kobra"",
  ""weight"": 3.085,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AS_VAL_9x39_special_assault_rifle""
},
{
  ""categories"": [
    {
      ""id"": ""5448e5284bdc2dcb718b4567""
    },
    {
      ""id"": ""566168634bdc2d144c8b456c""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/61bc85697113f767765c7fe7-icon.webp"",
  ""id"": ""657660eb86f11bca4106d34f"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/61bc85697113f767765c7fe7-image.webp"",
  ""link"": ""https://tarkov.dev/item/eagle-industries-mmac-plate-carrier-ranger-green-default"",
  ""name"": ""Eagle Industries MMAC plate carrier (Ranger Green) Default"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesPreset"",
    ""baseItem"": {
      ""id"": ""61bc85697113f767765c7fe7""
    },
    ""moa"": null
  },
  ""shortName"": ""MMAC Default"",
  ""weight"": 5.53,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Eagle_Industries_MMAC_plate_carrier_(Ranger_Green)""
},
{
  ""categories"": [
    {
      ""id"": ""5447b5f14bdc2d61278b4567""
    },
    {
      ""id"": ""5422acb9af1c889c16000029""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/584147732459775a2b6d9f12-icon.webp"",
  ""id"": ""584147732459775a2b6d9f12"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/584147732459775a2b6d9f12-image.webp"",
  ""link"": ""https://tarkov.dev/item/kalashnikov-aks-74u-545x39-assault-rifle-default"",
  ""name"": ""Kalashnikov AKS-74U 5.45x39 assault rifle Default"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesPreset"",
    ""baseItem"": {
      ""id"": ""57dc2fa62459775949412633""
    },
    ""moa"": 3.44
  },
  ""shortName"": ""AKS-74U Default"",
  ""weight"": 2.694,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Kalashnikov_AKS-74U_5.45x39_assault_rifle""
},
{
  ""categories"": [
    {
      ""id"": ""5447b5e04bdc2d62278b4567""
    },
    {
      ""id"": ""5422acb9af1c889c16000029""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5a8ae43686f774377b73cfb3-icon.webp"",
  ""id"": ""5a8ae43686f774377b73cfb3"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a8ae43686f774377b73cfb3-image.webp"",
  ""link"": ""https://tarkov.dev/item/sig-mpx-9x19-submachine-gun-mqb"",
  ""name"": ""SIG MPX 9x19 submachine gun MQB"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesPreset"",
    ""baseItem"": {
      ""id"": ""58948c8e86f77409493f7266""
    },
    ""moa"": 6.19
  },
  ""shortName"": ""MPX MQB"",
  ""weight"": 3.87,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/SIG_MPX_9x19_submachine_gun""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5a3b898486f77467720a2f29-icon.webp"",
  ""id"": ""5a3b898486f77467720a2f29"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a3b898486f77467720a2f29-image.webp"",
  ""link"": ""https://tarkov.dev/item/wilcox-skull-lock-head-mount-pvs-14"",
  ""name"": ""Wilcox Skull Lock head mount PVS-14"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesPreset"",
    ""baseItem"": {
      ""id"": ""5a16bb52fcdbcb001a3b00dc""
    },
    ""moa"": null
  },
  ""shortName"": ""Skull Lock PVS-14"",
  ""weight"": 1.29,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Wilcox_Skull_Lock_head_mount""
},
{
  ""categories"": [
    {
      ""id"": ""55818acf4bdc2dde698b456b""
    },
    {
      ""id"": ""5448fe7a4bdc2d6f028b456b""
    },
    {
      ""id"": ""550aa4154bdc2dd8348b456b""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58d268fc86f774111273f8c2-icon.webp"",
  ""id"": ""58d268fc86f774111273f8c2"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58d268fc86f774111273f8c2-image.webp"",
  ""link"": ""https://tarkov.dev/item/leupold-deltapoint-reflex-sight"",
  ""name"": ""Leupold DeltaPoint Reflex Sight"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesScope"",
    ""ergonomics"": 0,
    ""recoilModifier"": 0,
    ""slots"": [],
    ""zoomLevels"": [
      [
        1
      ]
    ]
  },
  ""shortName"": ""DP"",
  ""weight"": 0.053,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Leupold_DeltaPoint_Reflex_Sight""
},
{
  ""categories"": [
    {
      ""id"": ""55818add4bdc2d5b648b456f""
    },
    {
      ""id"": ""5448fe7a4bdc2d6f028b456b""
    },
    {
      ""id"": ""550aa4154bdc2dd8348b456b""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57adff4f24597737f373b6e6-icon.webp"",
  ""id"": ""57adff4f24597737f373b6e6"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57adff4f24597737f373b6e6-image.webp"",
  ""link"": ""https://tarkov.dev/item/sig-sauer-bravo4-4x30-scope"",
  ""name"": ""SIG Sauer BRAVO4 4x30 scope"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesScope"",
    ""ergonomics"": -2,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""57ae0171245977343c27bfcf""
            },
            {
              ""id"": ""58d39d3d86f77445bb794ae7""
            },
            {
              ""id"": ""577d128124597739d65d0e56""
            },
            {
              ""id"": ""58d2664f86f7747fec5834f6""
            },
            {
              ""id"": ""5a33b2c9c4a282000c5a9511""
            }
          ]
        },
        ""nameId"": ""mod_scope""
      }
    ],
    ""zoomLevels"": [
      [
        4
      ]
    ]
  },
  ""shortName"": ""BRAVO4"",
  ""weight"": 0.419,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/SIG_Sauer_BRAVO4_4x30_scope""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [
    {
      ""id"": ""591c4efa86f7741030027726""
    },
    {
      ""id"": ""570fd79bd2720bc7458b4583""
    },
    {
      ""id"": ""64785e7c19d732620e045e15""
    },
    {
      ""id"": ""570fd6c2d2720bc6458b457f""
    },
    {
      ""id"": ""558022b54bdc2dac148b458d""
    },
    {
      ""id"": ""58491f3324597764bc48fa02""
    },
    {
      ""id"": ""584924ec24597768f12ae244""
    },
    {
      ""id"": ""5b30b0dc5acfc400153b7124""
    },
    {
      ""id"": ""6165ac8c290d254f5e6b2f6c""
    },
    {
      ""id"": ""60a23797a37c940de7062d02""
    },
    {
      ""id"": ""6477772ea8a38bb2050ed4db""
    },
    {
      ""id"": ""5d2da1e948f035477b1ce2ba""
    },
    {
      ""id"": ""5c0505e00db834001b735073""
    },
    {
      ""id"": ""609a63b6e2ff132951242d09""
    },
    {
      ""id"": ""570fd721d2720bc5458b4596""
    },
    {
      ""id"": ""59f9d81586f7744c7506ee62""
    },
    {
      ""id"": ""584984812459776a704a82a6""
    }
  ],
  ""iconLink"": ""https://assets.tarkov.dev/61714eec290d254f5e6b2ffc-icon.webp"",
  ""id"": ""61714eec290d254f5e6b2ffc"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/61714eec290d254f5e6b2ffc-image.webp"",
  ""link"": ""https://tarkov.dev/item/schmidt-bender-pm-ii-3-12x50-34mm-riflescope"",
  ""name"": ""Schmidt & Bender PM II 3-12x50 34mm riflescope"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesScope"",
    ""ergonomics"": -6,
    ""recoilModifier"": 0,
    ""slots"": [],
    ""zoomLevels"": [
      [
        3,
        12
      ]
    ]
  },
  ""shortName"": ""PM II 3-12x50"",
  ""weight"": 0.9,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Schmidt_%26_Bender_PM_II_3-12x50_34mm_riflescope""
},
{
  ""categories"": [
    {
      ""id"": ""5447b5cf4bdc2d65278b4567""
    },
    {
      ""id"": ""5422acb9af1c889c16000029""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5e81c3cbac2bb513793cdc75-icon.webp"",
  ""id"": ""5e81c3cbac2bb513793cdc75"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5e81c3cbac2bb513793cdc75-image.webp"",
  ""link"": ""https://tarkov.dev/item/colt-m1911a1-45-acp-pistol"",
  ""name"": ""Colt M1911A1 .45 ACP pistol"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeapon"",
    ""caliber"": ""Caliber1143x23ACP"",
    ""defaultPreset"": {
      ""id"": ""5eb2968186f7746d1f1a4fd5""
    },
    ""ergonomics"": 75,
    ""fireModes"": [
      ""Single fire""
    ],
    ""fireRate"": 30,
    ""recoilHorizontal"": 355,
    ""recoilVertical"": 451,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5e81c519cb2b95385c177551""
            },
            {
              ""id"": ""5f3e7801153b8571434a924c""
            },
            {
              ""id"": ""5f3e77f59103d430b93f94c1""
            }
          ]
        },
        ""nameId"": ""mod_barrel""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5e81c6bf763d9f754677beff""
            },
            {
              ""id"": ""5ef366938cef260c0642acad""
            },
            {
              ""id"": ""626a9cb151cb5849f6002890""
            }
          ]
        },
        ""nameId"": ""mod_pistol_grip""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5e81edc13397a21db957f6a1""
            },
            {
              ""id"": ""5f3e7823ddc4f03b010e2045""
            }
          ]
        },
        ""nameId"": ""mod_reciever""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5e81c4ca763d9f754677befa""
            },
            {
              ""id"": ""5f3e77b26cda304dcc634057""
            },
            {
              ""id"": ""5ef3448ab37dfd6af863525c""
            }
          ]
        },
        ""nameId"": ""mod_magazine""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5ef32e4d1c1fd62aea6a150d""
            },
            {
              ""id"": ""5e81c6a2ac2bb513793cdc7f""
            },
            {
              ""id"": ""5f3e772a670e2a7b01739a52""
            }
          ]
        },
        ""nameId"": ""mod_trigger""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5e81c550763d9f754677befd""
            },
            {
              ""id"": ""5f3e76d86cda304dcc634054""
            },
            {
              ""id"": ""5ef35f46382a846010715a96""
            },
            {
              ""id"": ""5ef35d2ac64c5d0dfc0571b0""
            },
            {
              ""id"": ""5ef35bc243cb350a955a7ccd""
            }
          ]
        },
        ""nameId"": ""mod_hammer""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5e81c539cb2b95385c177553""
            },
            {
              ""id"": ""5f3e777688ca2d00ad199d25""
            },
            {
              ""id"": ""5ef3553c43cb350a955a7ccb""
            }
          ]
        },
        ""nameId"": ""mod_catch""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5ef5d994dfbc9f3c660ded95""
            }
          ]
        },
        ""nameId"": ""mod_mount_000""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5ef369b08cef260c0642acaf""
            }
          ]
        },
        ""nameId"": ""mod_mount_001""
      }
    ]
  },
  ""shortName"": ""M1911A1"",
  ""weight"": 0.231,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Colt_M1911A1_.45_ACP_pistol""
},
{
  ""categories"": [
    {
      ""id"": ""5447b5f14bdc2d61278b4567""
    },
    {
      ""id"": ""5422acb9af1c889c16000029""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57dc2fa62459775949412633-icon.webp"",
  ""id"": ""57dc2fa62459775949412633"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57dc2fa62459775949412633-image.webp"",
  ""link"": ""https://tarkov.dev/item/kalashnikov-aks-74u-545x39-assault-rifle"",
  ""name"": ""Kalashnikov AKS-74U 5.45x39 assault rifle"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeapon"",
    ""caliber"": ""Caliber545x39"",
    ""defaultPreset"": {
      ""id"": ""584147732459775a2b6d9f12""
    },
    ""ergonomics"": 44,
    ""fireModes"": [
      ""Full auto"",
      ""Single fire""
    ],
    ""fireRate"": 650,
    ""recoilHorizontal"": 373,
    ""recoilVertical"": 102,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5f6341043ada5942720e2dc5""
            },
            {
              ""id"": ""6087e663132d4d12c81fd96b""
            },
            {
              ""id"": ""5beec8ea0db834001a6f9dbf""
            },
            {
              ""id"": ""5649ad3f4bdc2df8348b4585""
            },
            {
              ""id"": ""5649ade84bdc2d1b2b8b4587""
            },
            {
              ""id"": ""59e62cc886f77440d40b52a1""
            },
            {
              ""id"": ""5a0071d486f77404e23a12b2""
            },
            {
              ""id"": ""57e3dba62459770f0c32322b""
            },
            {
              ""id"": ""5cf54404d7f00c108840b2ef""
            },
            {
              ""id"": ""5e2192a498a36665e8337386""
            },
            {
              ""id"": ""5b30ac585acfc433000eb79c""
            },
            {
              ""id"": ""59e6318286f77444dd62c4cc""
            },
            {
              ""id"": ""5cf50850d7f00c056e24104c""
            },
            {
              ""id"": ""5cf508bfd7f00c056e24104e""
            },
            {
              ""id"": ""5947f92f86f77427344a76b1""
            },
            {
              ""id"": ""5947fa2486f77425b47c1a9b""
            },
            {
              ""id"": ""5c6bf4aa2e2216001219b0ae""
            },
            {
              ""id"": ""5649ae4a4bdc2d1b2b8b4588""
            },
            {
              ""id"": ""5998517986f7746017232f7e""
            },
            {
              ""id"": ""623c3be0484b5003161840dc""
            },
            {
              ""id"": ""628c9ab845c59e5b80768a81""
            },
            {
              ""id"": ""628a664bccaab13006640e47""
            },
            {
              ""id"": ""63f4da90f31d4a33b87bd054""
            },
            {
              ""id"": ""648ae3e356c6310a830fc291""
            },
            {
              ""id"": ""651580dc71a4f10aec4b6056""
            }
          ]
        },
        ""nameId"": ""mod_pistol_grip""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""59ecc28286f7746d7a68aa8c""
            },
            {
              ""id"": ""5ab626e4d8ce87272e4c6e43""
            },
            {
              ""id"": ""57dc347d245977596754e7a1""
            }
          ]
        },
        ""nameId"": ""mod_stock""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""6130ca3fd92c473c77020dbd""
            },
            {
              ""id"": ""5648ac824bdc2ded0b8b457d""
            }
          ]
        },
        ""nameId"": ""mod_charge""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""564ca9df4bdc2d35148b4569""
            },
            {
              ""id"": ""564ca99c4bdc2d16268b4589""
            },
            {
              ""id"": ""55d480c04bdc2d1d4e8b456a""
            },
            {
              ""id"": ""5cbdaf89ae9215000e5b9c94""
            },
            {
              ""id"": ""55d481904bdc2d8c2f8b456a""
            },
            {
              ""id"": ""55d482194bdc2d1d4e8b456b""
            },
            {
              ""id"": ""55d4837c4bdc2d1d4e8b456c""
            },
            {
              ""id"": ""5aaa4194e5b5b055d06310a5""
            },
            {
              ""id"": ""5bed61680db834001d2c45ab""
            },
            {
              ""id"": ""5bed625c0db834001c062946""
            },
            {
              ""id"": ""649ec30cb013f04a700e60fb""
            },
            {
              ""id"": ""64b9e265c94d0d15c5027e35""
            }
          ]
        },
        ""nameId"": ""mod_magazine""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5ac72e945acfc43f3b691116""
            },
            {
              ""id"": ""5ac7655e5acfc40016339a19""
            },
            {
              ""id"": ""5649aa744bdc2ded0b8b457e""
            },
            {
              ""id"": ""5f633f791b231926f2329f13""
            },
            {
              ""id"": ""5943eeeb86f77412d6384f6b""
            },
            {
              ""id"": ""5cc9a96cd7f00c011c04e04a""
            },
            {
              ""id"": ""615d8f5dd92c473c770212ef""
            },
            {
              ""id"": ""5649ab884bdc2ded0b8b457f""
            },
            {
              ""id"": ""57dc324a24597759501edc20""
            },
            {
              ""id"": ""59bffc1f86f77435b128b872""
            },
            {
              ""id"": ""593d493f86f7745e6b2ceb22""
            },
            {
              ""id"": ""564caa3d4bdc2d17108b458e""
            },
            {
              ""id"": ""57ffb0e42459777d047111c5""
            }
          ]
        },
        ""nameId"": ""mod_muzzle""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""57dc334d245977597164366f""
            },
            {
              ""id"": ""5839a7742459773cf9693481""
            },
            {
              ""id"": ""655cb6b5d680a544f30607fa""
            }
          ]
        },
        ""nameId"": ""mod_reciever""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""59d36a0086f7747e673f3946""
            }
          ]
        },
        ""nameId"": ""mod_gas_block""
      }
    ]
  },
  ""shortName"": ""AKS-74U"",
  ""weight"": 1.809,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Kalashnikov_AKS-74U_5.45x39_assault_rifle""
},
{
  ""categories"": [
    {
      ""id"": ""5447bedf4bdc2d87278b4568""
    },
    {
      ""id"": ""5422acb9af1c889c16000029""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/624c0b3340357b5f566e8766-icon.webp"",
  ""id"": ""624c0b3340357b5f566e8766"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/624c0b3340357b5f566e8766-image.webp"",
  ""link"": ""https://tarkov.dev/item/rsp-30-reactive-signal-cartridge-yellow"",
  ""name"": ""RSP-30 reactive signal cartridge (Yellow)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeapon"",
    ""caliber"": ""Caliber26x75"",
    ""defaultPreset"": null,
    ""ergonomics"": 51,
    ""fireModes"": [
      ""Single fire""
    ],
    ""fireRate"": 30,
    ""recoilHorizontal"": 400,
    ""recoilVertical"": 170,
    ""slots"": []
  },
  ""shortName"": ""Yellow"",
  ""weight"": 0.19,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/RSP-30_reactive_signal_cartridge_(Yellow)""
},
{
  ""categories"": [
    {
      ""id"": ""5447b5e04bdc2d62278b4567""
    },
    {
      ""id"": ""5422acb9af1c889c16000029""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58948c8e86f77409493f7266-icon.webp"",
  ""id"": ""58948c8e86f77409493f7266"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58948c8e86f77409493f7266-image.webp"",
  ""link"": ""https://tarkov.dev/item/sig-mpx-9x19-submachine-gun"",
  ""name"": ""SIG MPX 9x19 submachine gun"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeapon"",
    ""caliber"": ""Caliber9x19PARA"",
    ""defaultPreset"": {
      ""id"": ""58dffca786f774083a256ab1""
    },
    ""ergonomics"": 40,
    ""fireModes"": [
      ""Full auto"",
      ""Single fire""
    ],
    ""fireRate"": 850,
    ""recoilHorizontal"": 269,
    ""recoilVertical"": 51,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""55d4b9964bdc2d1d4e8b456e""
            },
            {
              ""id"": ""571659bb2459771fb2755a12""
            },
            {
              ""id"": ""602e71bd53a60014f9705bfa""
            },
            {
              ""id"": ""6113c3586c780c1e710c90bc""
            },
            {
              ""id"": ""6113cc78d3a39d50044c065a""
            },
            {
              ""id"": ""6113cce3d92c473c770200c7""
            },
            {
              ""id"": ""5cc9bcaed7f00c011c04e179""
            },
            {
              ""id"": ""5bb20e18d4351e00320205d5""
            },
            {
              ""id"": ""5bb20e0ed4351e3bac1212dc""
            },
            {
              ""id"": ""6193dcd0f8ee7e52e4210a28""
            },
            {
              ""id"": ""5d025cc1d7ad1a53845279ef""
            },
            {
              ""id"": ""5c6d7b3d2e221600114c9b7d""
            },
            {
              ""id"": ""57c55efc2459772d2c6271e7""
            },
            {
              ""id"": ""57af48872459771f0b2ebf11""
            },
            {
              ""id"": ""57c55f092459772d291a8463""
            },
            {
              ""id"": ""57c55f112459772d28133310""
            },
            {
              ""id"": ""57c55f172459772d27602381""
            },
            {
              ""id"": ""5a339805c4a2826c6e06d73d""
            },
            {
              ""id"": ""55802f5d4bdc2dac148b458f""
            },
            {
              ""id"": ""5d15cf3bd7ad1a67e71518b2""
            },
            {
              ""id"": ""59db3a1d86f77429e05b4e92""
            },
            {
              ""id"": ""5fbcbd6c187fea44d52eda14""
            },
            {
              ""id"": ""59db3acc86f7742a2c4ab912""
            },
            {
              ""id"": ""59db3b0886f77429d72fb895""
            },
            {
              ""id"": ""615d8faecabb9b7ad90f4d5d""
            },
            {
              ""id"": ""5b07db875acfc40dc528a5f6""
            },
            {
              ""id"": ""5894a51286f77426d13baf02""
            },
            {
              ""id"": ""63f5feead259b42f0b4d6d0f""
            },
            {
              ""id"": ""652911675ae2ae97b80fdf3c""
            }
          ]
        },
        ""nameId"": ""mod_pistol_grip""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5c5db6742e2216000f1b2852""
            },
            {
              ""id"": ""5c5db6552e2216001026119d""
            },
            {
              ""id"": ""5894a05586f774094708ef75""
            },
            {
              ""id"": ""5c5db6652e221600113fba51""
            }
          ]
        },
        ""nameId"": ""mod_magazine""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5894a5b586f77426d2590767""
            }
          ]
        },
        ""nameId"": ""mod_reciever""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""58ac1bf086f77420ed183f9f""
            },
            {
              ""id"": ""5894a13e86f7742405482982""
            },
            {
              ""id"": ""5fbcc429900b1d5091531dd7""
            },
            {
              ""id"": ""5fbcc437d724d907e2077d5c""
            },
            {
              ""id"": ""5c5db6ee2e221600113fba54""
            },
            {
              ""id"": ""5c5db6f82e2216003a0fe914""
            },
            {
              ""id"": ""6529348224cbe3c74a05e5c4""
            }
          ]
        },
        ""nameId"": ""mod_stock""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5c5db6b32e221600102611a0""
            },
            {
              ""id"": ""58949edd86f77409483e16a9""
            },
            {
              ""id"": ""58949fac86f77409483e16aa""
            }
          ]
        },
        ""nameId"": ""mod_charge""
      }
    ]
  },
  ""shortName"": ""MPX"",
  ""weight"": 0.64,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/SIG_MPX_9x19_submachine_gun""
},
{
  ""categories"": [
    {
      ""id"": ""5447bedf4bdc2d87278b4568"",
      ""name"": ""Grenade launcher""
    },
    {
      ""id"": ""5422acb9af1c889c16000029"",
      ""name"": ""Weapon""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573"",
      ""name"": ""Compound item""
    },
    {
      ""id"": ""54009119af1c881c07000029"",
      ""name"": ""Item""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/620109578d82e67e7911abf2-icon.webp"",
  ""id"": ""620109578d82e67e7911abf2"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/620109578d82e67e7911abf2-image.webp"",
  ""link"": ""https://tarkov.dev/item/zid-sp-81-26x75-signal-pistol"",
  ""name"": ""ZiD SP-81 26x75 signal pistol"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeapon"",
    ""caliber"": ""Caliber26x75"",
    ""defaultPreset"": null,
    ""ergonomics"": 51,
    ""fireModes"": [
      ""Single fire""
    ],
    ""fireRate"": 30,
    ""recoilHorizontal"": 400,
    ""recoilVertical"": 170,
    ""slots"": []
  },
  ""shortName"": ""SP-81"",
  ""weight"": 0.6,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/ZiD_SP-81_26x75_signal_pistol""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [
    {
      ""id"": ""5947db3f86f77447880cf76f""
    },
    {
      ""id"": ""57486e672459770abd687134""
    },
    {
      ""id"": ""5ac733a45acfc400192630e2""
    },
    {
      ""id"": ""5649b0544bdc2d1b2b8b458a""
    },
    {
      ""id"": ""5ac72e475acfc400180ae6fe""
    },
    {
      ""id"": ""59d650cf86f7741b846413a4""
    },
    {
      ""id"": ""5a0eb980fcdbcb001a3b00a6""
    },
    {
      ""id"": ""59e8977386f77415a553c453""
    },
    {
      ""id"": ""5649d9a14bdc2d79388b4580""
    },
    {
      ""id"": ""5c82342f2e221644f31c060e""
    },
    {
      ""id"": ""576fd4ec2459777f0b518431""
    },
    {
      ""id"": ""5c82343a2e221644f31c0611""
    },
    {
      ""id"": ""5cf638cbd7f00c06595bc936""
    },
    {
      ""id"": ""5a7c74b3e899ef0014332c29""
    },
    {
      ""id"": ""591ee00d86f774592f7b841e""
    },
    {
      ""id"": ""5d0a29ead7ad1a0026013f27""
    },
    {
      ""id"": ""57acb6222459771ec34b5cb0""
    },
    {
      ""id"": ""5c61a40d2e2216001403158d""
    },
    {
      ""id"": ""5c90c3622e221601da359851""
    },
    {
      ""id"": ""628a7b23b0f75035732dd565""
    },
    {
      ""id"": ""5bf3f59f0db834001a6fa060""
    },
    {
      ""id"": ""649ec2cec93611967b03495e""
    }
  ],
  ""iconLink"": ""https://assets.tarkov.dev/5d2c76ed48f03532f2136169-icon.webp"",
  ""id"": ""5d2c76ed48f03532f2136169"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5d2c76ed48f03532f2136169-image.webp"",
  ""link"": ""https://tarkov.dev/item/ak-akademia-bastion-dust-cover"",
  ""name"": ""AK AKademia Bastion dust cover"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 5,
    ""recoilModifier"": -0.01,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""57ac965c24597706be5f975c""
            },
            {
              ""id"": ""57aca93d2459771f2c7e26db""
            },
            {
              ""id"": ""544a3a774bdc2d3a388b4567""
            },
            {
              ""id"": ""5d2dc3e548f035404a1a4798""
            },
            {
              ""id"": ""57adff4f24597737f373b6e6""
            },
            {
              ""id"": ""5c0517910db83400232ffee5""
            },
            {
              ""id"": ""591c4efa86f7741030027726""
            },
            {
              ""id"": ""570fd79bd2720bc7458b4583""
            },
            {
              ""id"": ""570fd6c2d2720bc6458b457f""
            },
            {
              ""id"": ""558022b54bdc2dac148b458d""
            },
            {
              ""id"": ""5c07dd120db834001c39092d""
            },
            {
              ""id"": ""5c0a2cec0db834001b7ce47d""
            },
            {
              ""id"": ""58491f3324597764bc48fa02""
            },
            {
              ""id"": ""584924ec24597768f12ae244""
            },
            {
              ""id"": ""5b30b0dc5acfc400153b7124""
            },
            {
              ""id"": ""6165ac8c290d254f5e6b2f6c""
            },
            {
              ""id"": ""60a23797a37c940de7062d02""
            },
            {
              ""id"": ""5d2da1e948f035477b1ce2ba""
            },
            {
              ""id"": ""5c0505e00db834001b735073""
            },
            {
              ""id"": ""609a63b6e2ff132951242d09""
            },
            {
              ""id"": ""584984812459776a704a82a6""
            },
            {
              ""id"": ""59f9d81586f7744c7506ee62""
            },
            {
              ""id"": ""570fd721d2720bc5458b4596""
            },
            {
              ""id"": ""57ae0171245977343c27bfcf""
            },
            {
              ""id"": ""5dfe6104585a0c3e995c7b82""
            },
            {
              ""id"": ""5d1b5e94d7ad1a2b865a96b0""
            },
            {
              ""id"": ""609bab8b455afd752b2e6138""
            },
            {
              ""id"": ""58d39d3d86f77445bb794ae7""
            },
            {
              ""id"": ""616554fe50224f204c1da2aa""
            },
            {
              ""id"": ""5c7d55f52e221644f31bff6a""
            },
            {
              ""id"": ""616584766ef05c2ce828ef57""
            },
            {
              ""id"": ""5b3b6dc75acfc47a8773fb1e""
            },
            {
              ""id"": ""615d8d878004cc50514c3233""
            },
            {
              ""id"": ""5b2389515acfc4771e1be0c0""
            },
            {
              ""id"": ""577d128124597739d65d0e56""
            },
            {
              ""id"": ""618b9643526131765025ab35""
            },
            {
              ""id"": ""618bab21526131765025ab3f""
            },
            {
              ""id"": ""5c86592b2e2216000e69e77c""
            },
            {
              ""id"": ""5a37ca54c4a282000d72296a""
            },
            {
              ""id"": ""5d0a29fed7ad1a002769ad08""
            },
            {
              ""id"": ""5c064c400db834001d23f468""
            },
            {
              ""id"": ""58d2664f86f7747fec5834f6""
            },
            {
              ""id"": ""57c69dd424597774c03b7bbc""
            },
            {
              ""id"": ""5b3b99265acfc4704b4a1afb""
            },
            {
              ""id"": ""5aa66a9be5b5b0214e506e89""
            },
            {
              ""id"": ""5aa66c72e5b5b00016327c93""
            },
            {
              ""id"": ""5c1cdd302e221602b3137250""
            },
            {
              ""id"": ""61714b2467085e45ef140b2c""
            },
            {
              ""id"": ""6171407e50224f204c1da3c5""
            },
            {
              ""id"": ""61713cc4d8e3106d9806c109""
            },
            {
              ""id"": ""5b31163c5acfc400153b71cb""
            },
            {
              ""id"": ""5a33b652c4a28232996e407c""
            },
            {
              ""id"": ""5a33b2c9c4a282000c5a9511""
            },
            {
              ""id"": ""59db7eed86f77461f8380365""
            },
            {
              ""id"": ""5a1ead28fcdbcb001912fa9f""
            },
            {
              ""id"": ""5dff77c759400025ea5150cf""
            },
            {
              ""id"": ""626bb8532c923541184624b4""
            },
            {
              ""id"": ""62811f461d5df4475f46a332""
            },
            {
              ""id"": ""63fc449f5bd61c6cf3784a88""
            },
            {
              ""id"": ""6477772ea8a38bb2050ed4db""
            },
            {
              ""id"": ""6478641c19d732620e045e17""
            },
            {
              ""id"": ""64785e7c19d732620e045e15""
            },
            {
              ""id"": ""65392f611406374f82152ba5""
            },
            {
              ""id"": ""653931da5db71d30ab1d6296""
            },
            {
              ""id"": ""655f13e0a246670fb0373245""
            },
            {
              ""id"": ""6567e751a715f85433025998""
            }
          ]
        },
        ""nameId"": ""mod_scope""
      }
    ]
  },
  ""shortName"": ""Bastion"",
  ""weight"": 0.237,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AK_AKademia_Bastion_dust_cover""
},
{
  ""categories"": [
    {
      ""id"": ""55818a684bdc2ddd698b456d""
    },
    {
      ""id"": ""55802f4a4bdc2ddb688b4569""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57e3dba62459770f0c32322b-icon.webp"",
  ""id"": ""57e3dba62459770f0c32322b"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57e3dba62459770f0c32322b-image.webp"",
  ""link"": ""https://tarkov.dev/item/ak-bakelite-pistol-grip-6p4-sb9"",
  ""name"": ""AK bakelite pistol grip (6P4 Sb.9)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 6,
    ""recoilModifier"": 0,
    ""slots"": []
  },
  ""shortName"": ""6P4 Sb.9"",
  ""weight"": 0.07,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AK_bakelite_pistol_grip_(6P4_Sb.9)""
},
{
  ""categories"": [
    {
      ""id"": ""550aa4bf4bdc2dd6348b456b""
    },
    {
      ""id"": ""5448fe394bdc2d0d028b456c""
    },
    {
      ""id"": ""550aa4154bdc2dd8348b456b""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57dc324a24597759501edc20-icon.webp"",
  ""id"": ""57dc324a24597759501edc20"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57dc324a24597759501edc20-image.webp"",
  ""link"": ""https://tarkov.dev/item/aks-74u-545x39-muzzle-brake-6p26-0-20"",
  ""name"": ""AKS-74U 5.45x39 muzzle brake (6P26 0-20)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": -2,
    ""recoilModifier"": -0.06,
    ""slots"": []
  },
  ""shortName"": ""6P26 0-20"",
  ""weight"": 0.1,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AKS-74U_5.45x39_muzzle_brake_(6P26_0-20)""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [
    {
      ""id"": ""57486e672459770abd687134""
    },
    {
      ""id"": ""5c82342f2e221644f31c060e""
    },
    {
      ""id"": ""576fd4ec2459777f0b518431""
    },
    {
      ""id"": ""5c82343a2e221644f31c0611""
    },
    {
      ""id"": ""5c61a40d2e2216001403158d""
    },
    {
      ""id"": ""5c90c3622e221601da359851""
    }
  ],
  ""iconLink"": ""https://assets.tarkov.dev/57dc334d245977597164366f-icon.webp"",
  ""id"": ""57dc334d245977597164366f"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57dc334d245977597164366f-image.webp"",
  ""link"": ""https://tarkov.dev/item/aks-74u-dust-cover-6p26-sb7"",
  ""name"": ""AKS-74U dust cover (6P26 Sb.7)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 5,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""57ffb0062459777a045af529""
            }
          ]
        },
        ""nameId"": ""mod_mount_000""
      }
    ]
  },
  ""shortName"": ""6P26 Sb.7"",
  ""weight"": 0.136,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AKS-74U_dust_cover_(6P26_Sb.7)""
},
{
  ""categories"": [
    {
      ""id"": ""56ea9461d2720b67698b456f""
    },
    {
      ""id"": ""550aa4154bdc2dd8348b456b""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/59d36a0086f7747e673f3946-icon.webp"",
  ""id"": ""59d36a0086f7747e673f3946"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/59d36a0086f7747e673f3946-image.webp"",
  ""link"": ""https://tarkov.dev/item/aks-74u-gas-tube-6p26-sb1-2"",
  ""name"": ""AKS-74U gas tube (6P26 Sb.1-2)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 0,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5d15ce51d7ad1a1eff619092""
            },
            {
              ""id"": ""5a957c3fa2750c00137fa5f7""
            },
            {
              ""id"": ""57dc32dc245977596d4ef3d3""
            },
            {
              ""id"": ""57ffa9f4245977728561e844""
            },
            {
              ""id"": ""647db1eca8d3399c380d195c""
            }
          ]
        },
        ""nameId"": ""mod_handguard""
      }
    ]
  },
  ""shortName"": ""6P26 Sb.1-2"",
  ""weight"": 0.03,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AKS-74U_gas_tube_(6P26_Sb.1-2)""
},
{
  ""categories"": [
    {
      ""id"": ""55818a594bdc2db9688b456a""
    },
    {
      ""id"": ""55802f3e4bdc2de7118b4584""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57dc347d245977596754e7a1-icon.webp"",
  ""id"": ""57dc347d245977596754e7a1"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57dc347d245977596754e7a1-image.webp"",
  ""link"": ""https://tarkov.dev/item/aks-74u-metal-skeleton-stock-6p26-sb5"",
  ""name"": ""AKS-74U metal skeleton stock (6P26 Sb.5)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 10,
    ""recoilModifier"": -0.21,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5a0c59791526d8dba737bba7""
            },
            {
              ""id"": ""6494094948796d891603e59f""
            }
          ]
        },
        ""nameId"": ""mod_stock""
      }
    ]
  },
  ""shortName"": ""6P26 Sb.5"",
  ""weight"": 0.218,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AKS-74U_metal_skeleton_stock_(6P26_Sb.5)""
},
{
  ""categories"": [
    {
      ""id"": ""55818a104bdc2db9688b4569""
    },
    {
      ""id"": ""55802f4a4bdc2ddb688b4569""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57dc32dc245977596d4ef3d3-icon.webp"",
  ""id"": ""57dc32dc245977596d4ef3d3"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57dc32dc245977596d4ef3d3-image.webp"",
  ""link"": ""https://tarkov.dev/item/aks-74u-wooden-handguard-6p26-sb6"",
  ""name"": ""AKS-74U wooden handguard (6P26 Sb.6)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 4,
    ""recoilModifier"": 0,
    ""slots"": []
  },
  ""shortName"": ""6P26 Sb.6"",
  ""weight"": 0.116,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AKS-74U_wooden_handguard_(6P26_Sb.6)""
},
{
  ""categories"": [
    {
      ""id"": ""55818b224bdc2dde698b456f""
    },
    {
      ""id"": ""55802f3e4bdc2de7118b4584""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5a16b93dfcdbcbcae6687261-icon.webp"",
  ""id"": ""5a16b93dfcdbcbcae6687261"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a16b93dfcdbcbcae6687261-image.webp"",
  ""link"": ""https://tarkov.dev/item/anpvs-14-dual-dovetail-mount"",
  ""name"": ""AN/PVS-14 Dual Dovetail Mount"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 0,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""57235b6f24597759bf5a30f1""
            }
          ]
        },
        ""nameId"": ""mod_nvg""
      }
    ]
  },
  ""shortName"": ""DDT"",
  ""weight"": 0.07,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AN/PVS-14_Dual_Dovetail_Mount""
},
{
  ""categories"": [
    {
      ""id"": ""55818a594bdc2db9688b456a""
    },
    {
      ""id"": ""55802f3e4bdc2de7118b4584""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/591aef7986f774139d495f03-icon.webp"",
  ""id"": ""591aef7986f774139d495f03"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/591aef7986f774139d495f03-image.webp"",
  ""link"": ""https://tarkov.dev/item/ar-15-troy-m7a1-pdw-stock-black"",
  ""name"": ""AR-15 TROY M7A1 PDW stock (Black)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 18,
    ""recoilModifier"": -0.18,
    ""slots"": []
  },
  ""shortName"": ""M7A1PDW"",
  ""weight"": 0.4,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AR-15_TROY_M7A1_PDW_stock""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/59d790f486f77403cb06aec6-icon.webp"",
  ""id"": ""59d790f486f77403cb06aec6"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/59d790f486f77403cb06aec6-image.webp"",
  ""link"": ""https://tarkov.dev/item/armytek-predator-pro-v3-xhp35-hi-flashlight"",
  ""name"": ""Armytek Predator Pro v3 XHP35 HI flashlight"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": -2,
    ""recoilModifier"": 0,
    ""slots"": []
  },
  ""shortName"": ""XHP35"",
  ""weight"": 0.12,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Armytek_Predator_Pro_v3_XHP35_HI_flashlight""
},
{
  ""categories"": [
    {
      ""id"": ""55818b224bdc2dde698b456f""
    },
    {
      ""id"": ""55802f3e4bdc2de7118b4584""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58d2664f86f7747fec5834f6-icon.webp"",
  ""id"": ""58d2664f86f7747fec5834f6"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58d2664f86f7747fec5834f6-image.webp"",
  ""link"": ""https://tarkov.dev/item/deltapoint-cross-slot-mount-base"",
  ""name"": ""DeltaPoint Cross Slot Mount base"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 0,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""58d268fc86f774111273f8c2""
            }
          ]
        },
        ""nameId"": ""mod_scope""
      }
    ]
  },
  ""shortName"": ""DPCSM"",
  ""weight"": 0.045,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/DeltaPoint_Cross_Slot_Mount_base""
},
{
  ""categories"": [
    {
      ""id"": ""55818af64bdc2d5b648b4570""
    },
    {
      ""id"": ""550aa4154bdc2dd8348b456b""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/59f8a37386f7747af3328f06-icon.webp"",
  ""id"": ""59f8a37386f7747af3328f06"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/59f8a37386f7747af3328f06-image.webp"",
  ""link"": ""https://tarkov.dev/item/fortis-shift-tactical-foregrip"",
  ""name"": ""Fortis Shift tactical foregrip"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 8,
    ""recoilModifier"": -0.015,
    ""slots"": []
  },
  ""shortName"": ""Shift"",
  ""weight"": 0.09,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Fortis_Shift_tactical_foregrip""
},
{
  ""categories"": [
    {
      ""id"": ""55818a684bdc2ddd698b456d""
    },
    {
      ""id"": ""55802f4a4bdc2ddb688b4569""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57c55efc2459772d2c6271e7-icon.webp"",
  ""id"": ""57c55efc2459772d2c6271e7"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57c55efc2459772d2c6271e7-image.webp"",
  ""link"": ""https://tarkov.dev/item/hogue-overmolded-rubber-grip-black"",
  ""name"": ""Hogue OverMolded Rubber Grip (Black)"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 9,
    ""recoilModifier"": 0,
    ""slots"": []
  },
  ""shortName"": ""OMRG BLK"",
  ""weight"": 0.08,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Hogue_OverMolded_Rubber_Grip""
},
{
  ""categories"": [
    {
      ""id"": ""55818b224bdc2dde698b456f""
    },
    {
      ""id"": ""55802f3e4bdc2de7118b4584""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57d17e212459775a1179a0f5-icon.webp"",
  ""id"": ""57d17e212459775a1179a0f5"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57d17e212459775a1179a0f5-image.webp"",
  ""link"": ""https://tarkov.dev/item/kiba-arms-25mm-accessory-ring-mount"",
  ""name"": ""Kiba Arms 25mm accessory ring mount"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": -1,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""59d790f486f77403cb06aec6""
            },
            {
              ""id"": ""57d17c5e2459775a5c57d17d""
            }
          ]
        },
        ""nameId"": ""mod_flashlight""
      }
    ]
  },
  ""shortName"": ""25mm ring"",
  ""weight"": 0.085,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Kiba_Arms_25mm_accessory_ring_mount""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5894a5b586f77426d2590767-icon.webp"",
  ""id"": ""5894a5b586f77426d2590767"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5894a5b586f77426d2590767-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-gen1-9x19-upper-receiver"",
  ""name"": ""MPX GEN1 9x19 upper receiver"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 5,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""57ac965c24597706be5f975c""
            },
            {
              ""id"": ""57aca93d2459771f2c7e26db""
            },
            {
              ""id"": ""544a3a774bdc2d3a388b4567""
            },
            {
              ""id"": ""5d2dc3e548f035404a1a4798""
            },
            {
              ""id"": ""57adff4f24597737f373b6e6""
            },
            {
              ""id"": ""5c0517910db83400232ffee5""
            },
            {
              ""id"": ""591c4efa86f7741030027726""
            },
            {
              ""id"": ""570fd79bd2720bc7458b4583""
            },
            {
              ""id"": ""570fd6c2d2720bc6458b457f""
            },
            {
              ""id"": ""558022b54bdc2dac148b458d""
            },
            {
              ""id"": ""5c07dd120db834001c39092d""
            },
            {
              ""id"": ""5c0a2cec0db834001b7ce47d""
            },
            {
              ""id"": ""58491f3324597764bc48fa02""
            },
            {
              ""id"": ""584924ec24597768f12ae244""
            },
            {
              ""id"": ""5b30b0dc5acfc400153b7124""
            },
            {
              ""id"": ""6165ac8c290d254f5e6b2f6c""
            },
            {
              ""id"": ""60a23797a37c940de7062d02""
            },
            {
              ""id"": ""5d2da1e948f035477b1ce2ba""
            },
            {
              ""id"": ""5c0505e00db834001b735073""
            },
            {
              ""id"": ""609a63b6e2ff132951242d09""
            },
            {
              ""id"": ""584984812459776a704a82a6""
            },
            {
              ""id"": ""59f9d81586f7744c7506ee62""
            },
            {
              ""id"": ""570fd721d2720bc5458b4596""
            },
            {
              ""id"": ""57ae0171245977343c27bfcf""
            },
            {
              ""id"": ""5dfe6104585a0c3e995c7b82""
            },
            {
              ""id"": ""5d1b5e94d7ad1a2b865a96b0""
            },
            {
              ""id"": ""609bab8b455afd752b2e6138""
            },
            {
              ""id"": ""58d39d3d86f77445bb794ae7""
            },
            {
              ""id"": ""616554fe50224f204c1da2aa""
            },
            {
              ""id"": ""5c7d55f52e221644f31bff6a""
            },
            {
              ""id"": ""616584766ef05c2ce828ef57""
            },
            {
              ""id"": ""5b3b6dc75acfc47a8773fb1e""
            },
            {
              ""id"": ""615d8d878004cc50514c3233""
            },
            {
              ""id"": ""5b2389515acfc4771e1be0c0""
            },
            {
              ""id"": ""577d128124597739d65d0e56""
            },
            {
              ""id"": ""618b9643526131765025ab35""
            },
            {
              ""id"": ""618bab21526131765025ab3f""
            },
            {
              ""id"": ""5c86592b2e2216000e69e77c""
            },
            {
              ""id"": ""5a37ca54c4a282000d72296a""
            },
            {
              ""id"": ""5d0a29fed7ad1a002769ad08""
            },
            {
              ""id"": ""58d2664f86f7747fec5834f6""
            },
            {
              ""id"": ""57c69dd424597774c03b7bbc""
            },
            {
              ""id"": ""5b3b99265acfc4704b4a1afb""
            },
            {
              ""id"": ""5aa66a9be5b5b0214e506e89""
            },
            {
              ""id"": ""5aa66c72e5b5b00016327c93""
            },
            {
              ""id"": ""5c1cdd302e221602b3137250""
            },
            {
              ""id"": ""61714b2467085e45ef140b2c""
            },
            {
              ""id"": ""6171407e50224f204c1da3c5""
            },
            {
              ""id"": ""61713cc4d8e3106d9806c109""
            },
            {
              ""id"": ""5b31163c5acfc400153b71cb""
            },
            {
              ""id"": ""5a33b652c4a28232996e407c""
            },
            {
              ""id"": ""5a33b2c9c4a282000c5a9511""
            },
            {
              ""id"": ""59db7eed86f77461f8380365""
            },
            {
              ""id"": ""5a1ead28fcdbcb001912fa9f""
            },
            {
              ""id"": ""5dff77c759400025ea5150cf""
            },
            {
              ""id"": ""626bb8532c923541184624b4""
            },
            {
              ""id"": ""62811f461d5df4475f46a332""
            },
            {
              ""id"": ""63fc449f5bd61c6cf3784a88""
            },
            {
              ""id"": ""6477772ea8a38bb2050ed4db""
            },
            {
              ""id"": ""6478641c19d732620e045e17""
            },
            {
              ""id"": ""64785e7c19d732620e045e15""
            },
            {
              ""id"": ""65392f611406374f82152ba5""
            },
            {
              ""id"": ""653931da5db71d30ab1d6296""
            },
            {
              ""id"": ""655f13e0a246670fb0373245""
            },
            {
              ""id"": ""6567e751a715f85433025998""
            }
          ]
        },
        ""nameId"": ""mod_scope""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5c5db5852e2216003a0fe71a""
            },
            {
              ""id"": ""5c5db5962e2216000e5e46eb""
            },
            {
              ""id"": ""58aeaaa886f7744fc1560f81""
            },
            {
              ""id"": ""5894a2c386f77427140b8342""
            },
            {
              ""id"": ""5c5db5b82e2216003a0fe71d""
            },
            {
              ""id"": ""5c5db5c62e22160012542255""
            }
          ]
        },
        ""nameId"": ""mod_barrel""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5c59529a2e221602b177d160""
            },
            {
              ""id"": ""5c5db6302e2216000e5e47f0""
            },
            {
              ""id"": ""5c5db63a2e2216000f1b284a""
            },
            {
              ""id"": ""5c5db5f22e2216000e5e47e8""
            },
            {
              ""id"": ""5c5db5fc2e2216000f1b2842""
            },
            {
              ""id"": ""5894a42086f77426d2590762""
            }
          ]
        },
        ""nameId"": ""mod_handguard""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5ba26b17d4351e00367f9bdd""
            },
            {
              ""id"": ""5dfa3d7ac41b2312ea33362a""
            },
            {
              ""id"": ""5c1780312e221602b66cc189""
            },
            {
              ""id"": ""5fb6564947ce63734e3fa1da""
            },
            {
              ""id"": ""5bc09a18d4351e003562b68e""
            },
            {
              ""id"": ""5c18b9192e2216398b5a8104""
            },
            {
              ""id"": ""5fc0fa957283c4046c58147e""
            },
            {
              ""id"": ""5894a81786f77427140b8347""
            }
          ]
        },
        ""nameId"": ""mod_sight_rear""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""57fd23e32459772d0805bcf1""
            },
            {
              ""id"": ""544909bb4bdc2d6f028b4577""
            },
            {
              ""id"": ""5c06595c0db834001a66af6c""
            },
            {
              ""id"": ""5a7b483fe899ef0016170d15""
            },
            {
              ""id"": ""61605d88ffa6e502ac5e7eeb""
            },
            {
              ""id"": ""5c5952732e2216398b5abda2""
            },
            {
              ""id"": ""644a3df63b0b6f03e101e065""
            }
          ]
        },
        ""nameId"": ""mod_tactical_000""
      }
    ]
  },
  ""shortName"": ""MPX GEN1"",
  ""weight"": 0.488,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX_GEN1_9x19_upper_receiver""
},
{
  ""categories"": [
    {
      ""id"": ""55818a104bdc2db9688b4569""
    },
    {
      ""id"": ""55802f4a4bdc2ddb688b4569""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5894a42086f77426d2590762-icon.webp"",
  ""id"": ""5894a42086f77426d2590762"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5894a42086f77426d2590762-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-gen1-handguard"",
  ""name"": ""MPX GEN1 handguard"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 7,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5ba26b01d4351e0085325a51""
            },
            {
              ""id"": ""5dfa3d950dee1b22f862eae0""
            },
            {
              ""id"": ""5c17804b2e2216152006c02f""
            },
            {
              ""id"": ""5fb6567747ce63734e3fa1dc""
            },
            {
              ""id"": ""5bc09a30d4351e00367fb7c8""
            },
            {
              ""id"": ""5c18b90d2e2216152142466b""
            },
            {
              ""id"": ""5fc0fa362770a0045c59c677""
            },
            {
              ""id"": ""5894a73486f77426d259076c""
            }
          ]
        },
        ""nameId"": ""mod_sight_front""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""58a56f8d86f774651579314c""
            }
          ]
        },
        ""nameId"": ""mod_mount_000""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""58a5c12e86f7745d585a2b9e""
            }
          ]
        },
        ""nameId"": ""mod_mount_001""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""58a56f8d86f774651579314c""
            }
          ]
        },
        ""nameId"": ""mod_mount_002""
      }
    ]
  },
  ""shortName"": ""MPX GEN1"",
  ""weight"": 0.302,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX_GEN1_handguard""
},
{
  ""categories"": [
    {
      ""id"": ""55818b224bdc2dde698b456f""
    },
    {
      ""id"": ""55802f3e4bdc2de7118b4584""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58a56f8d86f774651579314c-icon.webp"",
  ""id"": ""58a56f8d86f774651579314c"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58a56f8d86f774651579314c-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-gen1-handguard-2-inch-rail"",
  ""name"": ""MPX GEN1 handguard 2 inch rail"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 0,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5a800961159bd4315e3a1657""
            },
            {
              ""id"": ""57fd23e32459772d0805bcf1""
            },
            {
              ""id"": ""544909bb4bdc2d6f028b4577""
            },
            {
              ""id"": ""5c06595c0db834001a66af6c""
            },
            {
              ""id"": ""5cc9c20cd7f00c001336c65d""
            },
            {
              ""id"": ""5d2369418abbc306c62e0c80""
            },
            {
              ""id"": ""5b07dd285acfc4001754240d""
            },
            {
              ""id"": ""56def37dd2720bec348b456a""
            },
            {
              ""id"": ""5a7b483fe899ef0016170d15""
            },
            {
              ""id"": ""61605d88ffa6e502ac5e7eeb""
            },
            {
              ""id"": ""5a5f1ce64f39f90b401987bc""
            },
            {
              ""id"": ""560d657b4bdc2da74d8b4572""
            },
            {
              ""id"": ""5b3a337e5acfc4704b4a19a0""
            },
            {
              ""id"": ""5c5952732e2216398b5abda2""
            },
            {
              ""id"": ""57d17e212459775a1179a0f5""
            },
            {
              ""id"": ""6267c6396b642f77f56f5c1c""
            },
            {
              ""id"": ""6272370ee4013c5d7e31f418""
            },
            {
              ""id"": ""6272379924e29f06af4d5ecb""
            },
            {
              ""id"": ""626becf9582c3e319310b837""
            },
            {
              ""id"": ""644a3df63b0b6f03e101e065""
            },
            {
              ""id"": ""646f6322f43d0c5d62063715""
            }
          ]
        },
        ""nameId"": ""mod_tactical""
      }
    ]
  },
  ""shortName"": ""MPX 2\"""",
  ""weight"": 0.07,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX_GEN1_handguard_2_inch_rail""
},
{
  ""categories"": [
    {
      ""id"": ""55818b224bdc2dde698b456f""
    },
    {
      ""id"": ""55802f3e4bdc2de7118b4584""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58a5c12e86f7745d585a2b9e-icon.webp"",
  ""id"": ""58a5c12e86f7745d585a2b9e"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58a5c12e86f7745d585a2b9e-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-gen1-handguard-4-inch-rail"",
  ""name"": ""MPX GEN1 handguard 4 inch rail"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 0,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5c7fc87d2e221644f31c0298""
            },
            {
              ""id"": ""5cda9bcfd7f00c0c0b53e900""
            },
            {
              ""id"": ""59f8a37386f7747af3328f06""
            },
            {
              ""id"": ""619386379fb0c665d5490dbe""
            },
            {
              ""id"": ""5c87ca002e221600114cb150""
            },
            {
              ""id"": ""588226d124597767ad33f787""
            },
            {
              ""id"": ""588226dd24597767ad33f789""
            },
            {
              ""id"": ""588226e62459776e3e094af7""
            },
            {
              ""id"": ""588226ef24597767af46e39c""
            },
            {
              ""id"": ""59fc48e086f77463b1118392""
            },
            {
              ""id"": ""5fce0cf655375d18a253eff0""
            },
            {
              ""id"": ""5cf4fb76d7f00c065703d3ac""
            },
            {
              ""id"": ""5b057b4f5acfc4771e1bd3e9""
            },
            {
              ""id"": ""5c791e872e2216001219c40a""
            },
            {
              ""id"": ""558032614bdc2de7118b4585""
            },
            {
              ""id"": ""58c157be86f77403c74b2bb6""
            },
            {
              ""id"": ""58c157c886f774032749fb06""
            },
            {
              ""id"": ""5f6340d3ca442212f4047eb2""
            },
            {
              ""id"": ""591af28e86f77414a27a9e1d""
            },
            {
              ""id"": ""5c1cd46f2e22164bef5cfedb""
            },
            {
              ""id"": ""5c1bc4812e22164bef5cfde7""
            },
            {
              ""id"": ""5c1bc5612e221602b5429350""
            },
            {
              ""id"": ""5c1bc5af2e221602b412949b""
            },
            {
              ""id"": ""5c1bc5fb2e221602b1779b32""
            },
            {
              ""id"": ""5c1bc7432e221602b412949d""
            },
            {
              ""id"": ""5c1bc7752e221602b1779b34""
            },
            {
              ""id"": ""64806bdd26c80811d408d37a""
            },
            {
              ""id"": ""64807a29e5ffe165600abc97""
            },
            {
              ""id"": ""648067db042be0705c0b3009""
            },
            {
              ""id"": ""65169d5b30425317755f8e25""
            },
            {
              ""id"": ""655df24fdf80b12750626d0a""
            },
            {
              ""id"": ""655dccfdbdcc6b5df71382b6""
            }
          ]
        },
        ""nameId"": ""mod_foregrip""
      }
    ]
  },
  ""shortName"": ""MPX 4\"""",
  ""weight"": 0.05,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX_GEN1_handguard_4_inch_rail""
},
{
  ""categories"": [
    {
      ""id"": ""55818a6f4bdc2db9688b456b""
    },
    {
      ""id"": ""55802f3e4bdc2de7118b4584""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58949edd86f77409483e16a9-icon.webp"",
  ""id"": ""58949edd86f77409483e16a9"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58949edd86f77409483e16a9-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-double-latch-charging-handle"",
  ""name"": ""MPX double latch charging handle"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 1,
    ""recoilModifier"": 0,
    ""slots"": []
  },
  ""shortName"": ""MPX 2x"",
  ""weight"": 0.033,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX_double_latch_charging_handle""
},
{
  ""categories"": [
    {
      ""id"": ""550aa4cd4bdc2dd8348b456c""
    },
    {
      ""id"": ""5448fe394bdc2d0d028b456c""
    },
    {
      ""id"": ""550aa4154bdc2dd8348b456b""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58aeac1b86f77457c419f475-icon.webp"",
  ""id"": ""58aeac1b86f77457c419f475"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58aeac1b86f77457c419f475-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-sd-9x19-integrated-sound-suppressor"",
  ""name"": ""MPX-SD 9x19 integrated sound suppressor"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": -5,
    ""recoilModifier"": -0.11,
    ""slots"": []
  },
  ""shortName"": ""MPX-SD"",
  ""weight"": 0.6,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX-SD_9x19_integrated_sound_suppressor""
},
{
  ""categories"": [
    {
      ""id"": ""55818a594bdc2db9688b456a""
    },
    {
      ""id"": ""55802f3e4bdc2de7118b4584""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58ac1bf086f77420ed183f9f-icon.webp"",
  ""id"": ""58ac1bf086f77420ed183f9f"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58ac1bf086f77420ed183f9f-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpxmcx-retractable-stock-adapter"",
  ""name"": ""MPX/MCX retractable stock adapter"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": -2,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""57ade1442459771557167e15""
            },
            {
              ""id"": ""5a33ca0fc4a282000d72292f""
            },
            {
              ""id"": ""5c0faeddd174af02a962601f""
            },
            {
              ""id"": ""5649be884bdc2d79388b4577""
            },
            {
              ""id"": ""5d120a10d7ad1a4e1026ba85""
            },
            {
              ""id"": ""5b0800175acfc400153aebd4""
            },
            {
              ""id"": ""5947e98b86f774778f1448bc""
            },
            {
              ""id"": ""5947eab886f77475961d96c5""
            },
            {
              ""id"": ""5ef1ba28c64c5d0dfc0571a5""
            },
            {
              ""id"": ""602e3f1254072b51b239f713""
            },
            {
              ""id"": ""5c793fb92e221644f31bfb64""
            },
            {
              ""id"": ""5c793fc42e221600114ca25d""
            },
            {
              ""id"": ""591aef7986f774139d495f03""
            },
            {
              ""id"": ""591af10186f774139d495f0e""
            },
            {
              ""id"": ""627254cc9c563e6e442c398f""
            },
            {
              ""id"": ""638de3603a1a4031d8260b8c""
            }
          ]
        },
        ""nameId"": ""mod_stock""
      }
    ]
  },
  ""shortName"": ""MPX/MCX"",
  ""weight"": 0.2,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX/MCX_retractable_stock_adapter""
},
{
  ""categories"": [
    {
      ""id"": ""55818b224bdc2dde698b456f""
    },
    {
      ""id"": ""55802f3e4bdc2de7118b4584""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5a16b8a9fcdbcb00165aa6ca-icon.webp"",
  ""id"": ""5a16b8a9fcdbcb00165aa6ca"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a16b8a9fcdbcb00165aa6ca-image.webp"",
  ""link"": ""https://tarkov.dev/item/norotos-titanium-advanced-tactical-mount"",
  ""name"": ""Norotos Titanium Advanced Tactical Mount"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 0,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            {
              ""id"": ""5c0695860db834001b735461""
            },
            {
              ""id"": ""5a16b93dfcdbcbcae6687261""
            },
            {
              ""id"": ""5c11046cd174af02a012e42b""
            }
          ]
        },
        ""nameId"": ""mod_nvg""
      }
    ]
  },
  ""shortName"": ""TATM"",
  ""weight"": 0.07,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Norotos_Titanium_Advanced_Tactical_Mount""
},
{
  ""categories"": [
    {
      ""id"": ""55818b164bdc2ddc698b456c""
    },
    {
      ""id"": ""550aa4154bdc2dd8348b456b""
    },
    {
      ""id"": ""5448fe124bdc2da5018b4567""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5a7b483fe899ef0016170d15-icon.webp"",
  ""id"": ""5a7b483fe899ef0016170d15"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a7b483fe899ef0016170d15-image.webp"",
  ""link"": ""https://tarkov.dev/item/surefire-xc1-tactical-flashlight"",
  ""name"": ""SureFire XC1 tactical flashlight"",
  ""properties"": {
    ""__typename"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": -1,
    ""recoilModifier"": 0,
    ""slots"": []
  },
  ""shortName"": ""XC1"",
  ""weight"": 0.05,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/SureFire_XC1_tactical_flashlight""
},
{
  ""categories"": [
    {
      ""id"": ""5b3f15d486f77432d0509248""
    },
    {
      ""id"": ""543be5f84bdc2dd4348b456a""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5f9949d869e2777a0e779ba5-icon.webp"",
  ""id"": ""5f9949d869e2777a0e779ba5"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5f9949d869e2777a0e779ba5-image.webp"",
  ""link"": ""https://tarkov.dev/item/armband-rivals-2020"",
  ""name"": ""Armband (Rivals 2020)"",
  ""properties"": null,
  ""shortName"": ""Rivals"",
  ""weight"": 0.05,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Armband_(Rivals_2020)""
},
{
  ""categories"": [
    {
      ""id"": ""543be5dd4bdc2deb348b4569""
    },
    {
      ""id"": ""5661632d4bdc2d903d8b456b""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/569668774bdc2da2298b4568-icon.webp"",
  ""id"": ""569668774bdc2da2298b4568"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/569668774bdc2da2298b4568-image.webp"",
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
      ""id"": ""5447e0e74bdc2d3c308b4567""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5991b51486f77447b112d44f-icon.webp"",
  ""id"": ""5991b51486f77447b112d44f"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5991b51486f77447b112d44f-image.webp"",
  ""link"": ""https://tarkov.dev/item/ms2000-marker"",
  ""name"": ""MS2000 Marker"",
  ""properties"": null,
  ""shortName"": ""MS2000"",
  ""weight"": 0.15,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MS2000_Marker""
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
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5e54f76986f7740366043752-icon.webp"",
  ""id"": ""5e54f76986f7740366043752"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5e54f76986f7740366043752-image.webp"",
  ""link"": ""https://tarkov.dev/item/shroud-half-mask"",
  ""name"": ""Shroud half-mask"",
  ""properties"": null,
  ""shortName"": ""Shroud"",
  ""weight"": 0.1,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Shroud_half-mask""
},
{
  ""iconLink"": ""https://assets.tarkov.dev/657089638db3adca1009f4ca-icon.webp"",
  ""id"": ""657089638db3adca1009f4ca"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/657089638db3adca1009f4ca-image.webp"",
  ""link"": ""https://tarkov.dev/item/atomic-defense-cqcm-up-armored-ballistic-mask-black"",
  ""name"": ""Atomic Defense CQCM up armored ballistic mask (Black)"",
  ""shortName"": ""CQCM"",
  ""weight"": 2.1,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Atomic_Defense_CQCM_up_armored_ballistic_mask_(Black)"",
  ""categories"": [
    {
      ""id"": ""5a341c4686f77469e155819e""
    },
    {
      ""id"": ""57bef4c42459772e8d35a53b""
    },
    {
      ""id"": ""543be5f84bdc2dd4348b456a""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573""
    },
    {
      ""id"": ""54009119af1c881c07000029""
    }
  ],
  ""conflictingItems"": [
    {
      ""id"": ""66b5f65ca7f72d197e70bcd6""
    },
    {
      ""id"": ""66b5f666cad6f002ab7214c2""
    },
    {
      ""id"": ""66b5f661af44ca0014063c05""
    },
    {
      ""id"": ""5e01ef6886f77445f643baa4""
    },
    {
      ""id"": ""5e00c1ad86f774747333222c""
    }
  ],
  ""properties"": {
    ""__typename"": ""ItemPropertiesHelmet"",
    ""armorSlots"": [],
    ""blocksHeadset"": false,
    ""class"": 4,
    ""deafening"": ""None"",
    ""durability"": 35,
    ""ergoPenalty"": -0.02,
    ""ricochetX"": 0.9,
    ""slots"": [],
    ""speedPenalty"": -0.01,
    ""turnPenalty"": -0.03,
    ""material"": {
      ""id"": ""UHMWPE""
    }
  }
},
{
  ""iconLink"": ""https://assets.tarkov.dev/656fad8c498d1b7e3e071da0-icon.webp"",
  ""id"": ""656fad8c498d1b7e3e071da0"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/656fad8c498d1b7e3e071da0-image.webp"",
  ""link"": ""https://tarkov.dev/item/monoclete-level-iii-pe-ballistic-plate"",
  ""name"": ""Monoclete level III PE ballistic plate"",
  ""shortName"": ""Monoclete PE"",
  ""weight"": 1.35,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Monoclete_level_III_PE_ballistic_plate"",
  ""conflictingItems"": [],
  ""categories"": [
    {
      ""id"": ""644120aa86ffbe10ee032b6f"",
      ""name"": ""Armor Plate""
    },
    {
      ""id"": ""57bef4c42459772e8d35a53b"",
      ""name"": ""Armored equipment""
    },
    {
      ""id"": ""543be5f84bdc2dd4348b456a"",
      ""name"": ""Equipment""
    },
    {
      ""id"": ""566162e44bdc2d3f298b4573"",
      ""name"": ""Compound item""
    },
    {
      ""id"": ""54009119af1c881c07000029"",
      ""name"": ""Item""
    }
  ],
  ""properties"": {
    ""__typename"": ""ItemPropertiesArmorAttachment"",
    ""blindnessProtection"": 0,
    ""class"": 4,
    ""durability"": 40,
    ""ergoPenalty"": -0.01,
    ""slots"": [],
    ""speedPenalty"": -0.01,
    ""turnPenalty"": 0,
    ""zones"": [
      ""FR. PLATE"",
      ""BCK. PLATE""
    ],
    ""material"": {
      ""id"": ""UHMWPE""
    }
  }
}";
    }
}
