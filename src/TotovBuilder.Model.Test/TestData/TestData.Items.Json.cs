namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public partial class TestData
    {
        public const string ItemsJson = @$"{{
  ""data"": {{
    ""items"": {{
      {FakeItemsJson},
      {RealItemsJson}
    }},
    ""armorMaterials"": {ArmorMaterialsJson}
  }}
}}";

        /// <summary>
        /// Armor materials referenced by the items.
        /// </summary>
        private const string ArmorMaterialsJson = @"{
  ""Aramid"": {
    ""id"": ""Aramid"",
    ""name"": ""MatAramid""
  },
  ""Ceramic"": {
    ""id"": ""Ceramic"",
    ""name"": ""MatCeramic""
  },
  ""Glass"": {
    ""id"": ""Glass"",
    ""name"": ""MatGlass""
  },
  ""UHMWPE"": {
    ""id"": ""UHMWPE"",
    ""name"": ""MatUHMWPE""
  },
  ""Combined"": {
    ""id"": ""Combined"",
    ""name"": ""MatCombined""
  }
}";

        /// <summary>
        /// Fake items only for testing purpose.
        /// </summary>
        /// <remarks>
        /// Expression to sort them in Visual Studio Code using the Sort JSON extension :
        /// (a.properties == null && b.properties != null) ? 1 : (a.properties != null && b.properties == null) ? -1 : ((a.properties == null && b.properties == null) || (a.properties != null && b.properties != null && a.properties.propertiesType === b.properties.propertiesType)) ? (a.id === b.id ? 0 : (a.id > b.id ? 1 : -1)) : (a.properties?.propertiesType > b.properties?.propertiesType) ? 1 : -1
        /// </remarks>
        private const string FakeItemsJson = @"""test-preset-face-shield-alone"": {
  ""categories"": [
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""iconLink"": ""https://assets.tarkov.dev/test-preset-face-shield-alone-icon.webp"",
  ""id"": ""test-preset-face-shield-alone"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/test-preset-face-shield-alone-image.webp"",
  ""link"": ""https://tarkov.dev/item/test-preset-face-shield-alone"",
  ""name"": ""test-preset-face-shield-alone Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesPreset"",
    ""baseItem"": ""5a16b7e1fcdbcb00165aa6c9"",
    ""moa"": null
  },
  ""shortName"": ""test-preset-face-shield-alone ShortName"",
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/test-preset-face-shield-alone"",
  ""containsItems"": [
    {
      ""item"": ""5a16b7e1fcdbcb00165aa6c9"",
      ""count"": 1
    }
  ]
},
""test-preset-gas-tube-handguard"": {
  ""categories"": [
    ""56ea9461d2720b67698b456f"",
    ""550aa4154bdc2dd8348b456b"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""iconLink"": ""https://assets.tarkov.dev/test-preset-gas-tube-handguard-icon.webp"",
  ""id"": ""test-preset-gas-tube-handguard"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/test-preset-gas-tube-handguard-image.webp"",
  ""link"": ""https://tarkov.dev/item/test-preset-gas-tube-handguard"",
  ""name"": ""test-preset-gas-tube-handguard Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesPreset"",
    ""baseItem"": ""59d36a0086f7747e673f3946"",
    ""moa"": null
  },
  ""shortName"": ""test-preset-gas-tube-handguard ShortName"",
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/test-preset-gas-tube-handguard"",
  ""containsItems"": [
    {
      ""item"": ""59d36a0086f7747e673f3946"",
      ""count"": 1
    },
    {
      ""item"": ""57dc32dc245977596d4ef3d3"",
      ""count"": 1
    }
  ]
},
""test-preset-magazine-alone"": {
  ""categories"": [
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""iconLink"": ""https://assets.tarkov.dev/test-preset-magazine-alone-icon.webp"",
  ""id"": ""test-preset-magazine-alone"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/test-preset-magazine-alone-image.webp"",
  ""link"": ""https://tarkov.dev/item/test-preset-magazine-alone"",
  ""name"": ""test-preset-magazine-alone Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesPreset"",
    ""baseItem"": ""5e81c4ca763d9f754677befa"",
    ""moa"": null
  },
  ""shortName"": ""test-preset-magazine-alone ShortName"",
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/test-preset-magazine-alone""
},
""test-preset-ring-flashlight"": {
  ""categories"": [
    ""55818b224bdc2dde698b456f"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""iconLink"": ""https://assets.tarkov.dev/test-preset-ring-flashlight-icon.webp"",
  ""id"": ""test-preset-ring-flashlight"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/test-preset-ring-flashlight-image.webp"",
  ""link"": ""https://tarkov.dev/item/test-preset-ring-flashlight"",
  ""name"": ""test-preset-ring-flashlight Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesPreset"",
    ""baseItem"": ""57d17e212459775a1179a0f5"",
    ""moa"": null
  },
  ""shortName"": ""test-preset-ring-flashlight ShortName"",
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/test-preset-ring-flashlight"",
  ""containsItems"": [
    {
      ""item"": ""57d17e212459775a1179a0f5"",
      ""count"": 1
    },
    {
      ""item"": ""59d790f486f77403cb06aec6"",
      ""count"": 1
    }
  ]
},
""testAmmunition"": {
  ""categories"": [
    ""5485a8684bdc2da71d8b4567""
  ],
  ""iconLink"": """",
  ""id"": ""testAmmunition"",
  ""inspectImageLink"": """",
  ""link"": """",
  ""name"": ""testAmmunition Name"",
  ""properties"": null,
  ""shortName"": ""testAmmunition ShortName"",
  ""weight"": 0,
  ""wikiLink"": """"
},
""testArmor"": {
  ""categories"": [
    ""5448e54d4bdc2dcc718b4568""
  ],
  ""iconLink"": """",
  ""id"": ""testArmor"",
  ""inspectImageLink"": """",
  ""link"": """",
  ""name"": ""testArmor Name"",
  ""properties"": null,
  ""shortName"": ""testArmor ShortName"",
  ""weight"": 0,
  ""wikiLink"": """"
},
""testArmorMod"": {
  ""categories"": [
    ""57bef4c42459772e8d35a53b""
  ],
  ""iconLink"": """",
  ""id"": ""testArmorMod"",
  ""inspectImageLink"": """",
  ""link"": """",
  ""name"": ""testArmorMod Name"",
  ""properties"": null,
  ""shortName"": ""testArmorMod ShortName"",
  ""weight"": 0,
  ""wikiLink"": """"
},
""testBackpack"": {
  ""categories"": [
    ""5448e53e4bdc2d60728b4567""
  ],
  ""iconLink"": """",
  ""id"": ""testBackpack"",
  ""inspectImageLink"": """",
  ""link"": """",
  ""name"": ""testBackpack Name"",
  ""properties"": null,
  ""shortName"": ""testBackpack ShortName"",
  ""weight"": 0,
  ""wikiLink"": """"
},
""testContainer"": {
  ""categories"": [
    ""5448bf274bdc2dfc2f8b456a""
  ],
  ""iconLink"": """",
  ""id"": ""testContainer"",
  ""inspectImageLink"": """",
  ""link"": """",
  ""name"": ""testContainer Name"",
  ""properties"": null,
  ""shortName"": ""testContainer ShortName"",
  ""weight"": 0,
  ""wikiLink"": """"
},
""testEyewear"": {
  ""categories"": [
    ""5448e5724bdc2ddf718b4568""
  ],
  ""iconLink"": """",
  ""id"": ""testEyewear"",
  ""inspectImageLink"": """",
  ""link"": """",
  ""name"": ""testEyewear Name"",
  ""properties"": null,
  ""shortName"": ""testEyewear ShortName"",
  ""weight"": 0,
  ""wikiLink"": """"
},
""testGrenade"": {
  ""categories"": [
    ""543be6564bdc2df4348b4568""
  ],
  ""iconLink"": """",
  ""id"": ""testGrenade"",
  ""inspectImageLink"": """",
  ""link"": """",
  ""name"": ""testGrenade Name"",
  ""properties"": null,
  ""shortName"": ""testGrenade ShortName"",
  ""weight"": 0,
  ""wikiLink"": """"
},
""testHeadwear"": {
  ""categories"": [
    ""5a341c4086f77401f2541505""
  ],
  ""iconLink"": """",
  ""id"": ""testHeadwear"",
  ""inspectImageLink"": """",
  ""link"": """",
  ""name"": ""testHeadwear Name"",
  ""properties"": null,
  ""shortName"": ""testHeadwear ShortName"",
  ""weight"": 0,
  ""wikiLink"": """"
},
""testMagazine"": {
  ""categories"": [
    ""5448bc234bdc2d3c308b4569""
  ],
  ""iconLink"": """",
  ""id"": ""testMagazine"",
  ""inspectImageLink"": """",
  ""link"": """",
  ""name"": ""testMagazine Name"",
  ""properties"": null,
  ""shortName"": ""testMagazine ShortName"",
  ""weight"": 0,
  ""wikiLink"": """"
},
""testMeleeWeapon"": {
  ""categories"": [
    ""5447e1d04bdc2dff2f8b4567""
  ],
  ""iconLink"": """",
  ""id"": ""testMeleeWeapon"",
  ""inspectImageLink"": """",
  ""link"": """",
  ""name"": ""testMeleeWeapon Name"",
  ""properties"": null,
  ""shortName"": ""testMeleeWeapon ShortName"",
  ""weight"": 0,
  ""wikiLink"": """"
},
""testMod"": {
  ""categories"": [
    ""55818b224bdc2dde698b456f""
  ],
  ""iconLink"": """",
  ""id"": ""testMod"",
  ""inspectImageLink"": """",
  ""link"": """",
  ""name"": ""testMod Name"",
  ""properties"": null,
  ""shortName"": ""testMod ShortName"",
  ""weight"": 0,
  ""wikiLink"": """"
},
""testRangedWeapon"": {
  ""categories"": [
    ""5447b5cf4bdc2d65278b4567""
  ],
  ""iconLink"": """",
  ""id"": ""testRangedWeapon"",
  ""inspectImageLink"": """",
  ""link"": """",
  ""name"": ""testRangedWeapon Name"",
  ""properties"": null,
  ""shortName"": ""testRangedWeapon ShortName"",
  ""weight"": 0,
  ""wikiLink"": """"
},
""testRangedWeaponMod"": {
  ""categories"": [
    ""55818ae44bdc2dde698b456c""
  ],
  ""iconLink"": """",
  ""id"": ""testRangedWeaponMod"",
  ""inspectImageLink"": """",
  ""link"": """",
  ""name"": ""testRangedWeaponMod Name"",
  ""properties"": null,
  ""shortName"": ""testRangedWeaponMod ShortName"",
  ""weight"": 0,
  ""wikiLink"": """"
},
""testVest"": {
  ""categories"": [
    ""5448e5284bdc2dcb718b4567""
  ],
  ""iconLink"": """",
  ""id"": ""testVest"",
  ""inspectImageLink"": """",
  ""link"": """",
  ""name"": ""testVest Name"",
  ""properties"": null,
  ""shortName"": ""testVest ShortName"",
  ""weight"": 0,
  ""wikiLink"": """"
}";

        /// <summary>
        /// Real items obtained from the API.
        /// </summary>
        /// <remarks>
        /// Expression to sort them in Visual Studio Code using the Sort JSON extension :
        /// (a.properties == null && b.properties != null) ? 1 : (a.properties != null && b.properties == null) ? -1 : ((a.properties == null && b.properties == null) || (a.properties != null && b.properties != null && a.properties.propertiesType === b.properties.propertiesType)) ? (a.id === b.id ? 0 : (a.id > b.id ? 1 : -1)) : (a.properties?.propertiesType > b.properties?.propertiesType) ? 1 : -1
        /// </remarks>
        private const string RealItemsJson = @"""5d6e6806a4b936088465b17e"": {
  ""categories"": [
    ""5485a8684bdc2da71d8b4567"",
    ""5661632d4bdc2d903d8b456b"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5d6e6806a4b936088465b17e-icon.webp"",
  ""id"": ""5d6e6806a4b936088465b17e"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5d6e6806a4b936088465b17e-image.webp"",
  ""link"": ""https://tarkov.dev/item/1270-85mm-magnum-buckshot"",
  ""name"": ""5d6e6806a4b936088465b17e Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesAmmo"",
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
  ""shortName"": ""5d6e6806a4b936088465b17e ShortName"",
  ""weight"": 0.059,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/12/70_8.5mm_Magnum_buckshot""
},
""56dff4ecd2720b5f5a8b4568"": {
  ""categories"": [
    ""5485a8684bdc2da71d8b4567"",
    ""5661632d4bdc2d903d8b456b"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/56dff4ecd2720b5f5a8b4568-icon.webp"",
  ""id"": ""56dff4ecd2720b5f5a8b4568"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/56dff4ecd2720b5f5a8b4568-image.webp"",
  ""link"": ""https://tarkov.dev/item/545x39mm-us-gs"",
  ""name"": ""56dff4ecd2720b5f5a8b4568 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesAmmo"",
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
  ""shortName"": ""56dff4ecd2720b5f5a8b4568 ShortName"",
  ""weight"": 0.01,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/5.45x39mm_US_gs""
},
""601aa3d2b2bcb34913271e6d"": {
  ""categories"": [
    ""5485a8684bdc2da71d8b4567"",
    ""5661632d4bdc2d903d8b456b"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/601aa3d2b2bcb34913271e6d-icon.webp"",
  ""id"": ""601aa3d2b2bcb34913271e6d"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/601aa3d2b2bcb34913271e6d-image.webp"",
  ""link"": ""https://tarkov.dev/item/762x39mm-mai-ap"",
  ""name"": ""601aa3d2b2bcb34913271e6d Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesAmmo"",
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
  ""shortName"": ""601aa3d2b2bcb34913271e6d ShortName"",
  ""stackMaxSize"": 60,
  ""weight"": 0.015,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/7.62x39mm_MAI_AP""
},
""5c3df7d588a4501f290594e5"": {
  ""categories"": [
    ""5485a8684bdc2da71d8b4567"",
    ""5661632d4bdc2d903d8b456b"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5c3df7d588a4501f290594e5-icon.webp"",
  ""id"": ""5c3df7d588a4501f290594e5"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5c3df7d588a4501f290594e5-image.webp"",
  ""link"": ""https://tarkov.dev/item/9x19mm-green-tracer"",
  ""name"": ""5c3df7d588a4501f290594e5 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesAmmo"",
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
  ""shortName"": ""5c3df7d588a4501f290594e5 ShortName"",
  ""weight"": 0.006,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/9x19mm_Green_Tracer""
},
""5efb0da7a29a85116f6ea05f"": {
  ""categories"": [
    ""5485a8684bdc2da71d8b4567"",
    ""5661632d4bdc2d903d8b456b"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5efb0da7a29a85116f6ea05f-icon.webp"",
  ""id"": ""5efb0da7a29a85116f6ea05f"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5efb0da7a29a85116f6ea05f-image.webp"",
  ""link"": ""https://tarkov.dev/item/9x19mm-pbp-gzh"",
  ""name"": ""5efb0da7a29a85116f6ea05f Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesAmmo"",
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
  ""shortName"": ""5efb0da7a29a85116f6ea05f ShortName"",
  ""weight"": 0.009,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/9x19mm_PBP_gzh""
},
""5fc382a9d724d907e2077dab"": {
  ""iconLink"": ""https://assets.tarkov.dev/5fc382a9d724d907e2077dab-icon.webp"",
  ""id"": ""5fc382a9d724d907e2077dab"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5fc382a9d724d907e2077dab-image.webp"",
  ""link"": ""https://tarkov.dev/item/338-lapua-magnum-ap"",
  ""name"": ""5fc382a9d724d907e2077dab Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesAmmo"",
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
  ""shortName"": ""5fc382a9d724d907e2077dab ShortName"",
  ""weight"": 0.049,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/.338_Lapua_Magnum_AP"",
  ""conflictingItems"": [],
  ""categories"": [
    ""5485a8684bdc2da71d8b4567"",
    ""5661632d4bdc2d903d8b456b"",
    ""54009119af1c881c07000029""
  ]
},
""545cdb794bdc2d3a198b456a"": {
  ""iconLink"": ""https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-icon.webp"",
  ""id"": ""545cdb794bdc2d3a198b456a"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/545cdb794bdc2d3a198b456a-image.webp"",
  ""link"": ""https://tarkov.dev/item/6b43-zabralo-sh-body-armor-emr"",
  ""name"": ""545cdb794bdc2d3a198b456a Name"",
  ""shortName"": ""545cdb794bdc2d3a198b456a ShortName"",
  ""weight"": 10.8,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/6B43_Zabralo-Sh_body_armor_(EMR)"",
  ""conflictingItems"": [],
  ""categories"": [
    ""5448e54d4bdc2dcc718b4568"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesArmor"",
    ""class"": 6,
    ""durability"": 510,
    ""ergoPenalty"": -0.1,
    ""speedPenalty"": -0.115,
    ""turnPenalty"": -0.055,
    ""material"": ""Aramid"",
    ""armorSlots"": [
      {
        ""nameId"": ""Front_plate"",
        ""zones"": [
          ""Zone FR. PLATE""
        ],
        ""allowedPlates"": [
          ""656f9d5900d62bcd2e02407c"",
          ""656fa8d700d62bcd2e024084"",
          ""656fa99800d62bcd2e024088"",
          ""656fae5f7c2d57afe200c0d7"",
          ""656faf0ca0dce000a2020f77"",
          ""656fa0fb498d1b7e3e071d9c"",
          ""656fafe3498d1b7e3e071da4"",
          ""656fa76500d62bcd2e024080"",
          ""656fa25e94b480b8a500c0e0"",
          ""656fad8c498d1b7e3e071da0"",
          ""656fa61e94b480b8a500c0e8"",
          ""656fb21fa0dce000a2020f7c"",
          ""656fac30c6baea13cd07e10c"",
          ""656f9fa0498d1b7e3e071d98"",
          ""656fb0bd7c2d57afe200c0dc"",
          ""656fa53d94b480b8a500c0e4"",
          ""65573fa5655447403702a816"",
          ""64afc71497cf3a403c01ff38"",
          ""655746010177119f4a097ff7"",
          ""64afdcb83efdfea28601d041""
        ]
      },
      {
        ""nameId"": ""Back_plate"",
        ""zones"": [
          ""Zone BCK. PLATE""
        ],
        ""allowedPlates"": [
          ""656f9d5900d62bcd2e02407c"",
          ""656fa8d700d62bcd2e024084"",
          ""656fa99800d62bcd2e024088"",
          ""656fae5f7c2d57afe200c0d7"",
          ""656faf0ca0dce000a2020f77"",
          ""656fa0fb498d1b7e3e071d9c"",
          ""656fafe3498d1b7e3e071da4"",
          ""656fa76500d62bcd2e024080"",
          ""656fa25e94b480b8a500c0e0"",
          ""656fa61e94b480b8a500c0e8"",
          ""656fad8c498d1b7e3e071da0"",
          ""656fb21fa0dce000a2020f7c"",
          ""656fac30c6baea13cd07e10c"",
          ""656f9fa0498d1b7e3e071d98"",
          ""656fb0bd7c2d57afe200c0dc"",
          ""656fa53d94b480b8a500c0e4"",
          ""65573fa5655447403702a816"",
          ""64afc71497cf3a403c01ff38"",
          ""655746010177119f4a097ff7"",
          ""64afdcb83efdfea28601d041""
        ]
      },
      {
        ""nameId"": ""Left_side_plate"",
        ""zones"": [
          ""Zone L. PLATE""
        ],
        ""allowedPlates"": [
          ""64afd81707e2cf40e903a316"",
          ""6557458f83942d705f0c4962"",
          ""64afdb577bb3bfe8fe03fd1d""
        ]
      },
      {
        ""nameId"": ""Right_side_plate"",
        ""zones"": [
          ""Zone R. PLATE""
        ],
        ""allowedPlates"": [
          ""6557458f83942d705f0c4962"",
          ""64afdb577bb3bfe8fe03fd1d"",
          ""64afd81707e2cf40e903a316""
        ]
      },
      {
        ""nameId"": ""Soft_armor_front"",
        ""zones"": [
          ""Zone Stomach"",
          ""Zone Thorax""
        ],
        ""class"": 3,
        ""durability"": 85,
        ""ergoPenalty"": 0,
        ""name"": ""Soft_armor_front"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      },
      {
        ""nameId"": ""Soft_armor_back"",
        ""zones"": [
          ""Zone Thorax, Upper back"",
          ""Zone Stomach, Lower back""
        ],
        ""class"": 3,
        ""durability"": 85,
        ""ergoPenalty"": 0,
        ""name"": ""Soft_armor_back"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      },
      {
        ""nameId"": ""Soft_armor_left"",
        ""zones"": [
          ""Zone Stomach, Left Side""
        ],
        ""class"": 3,
        ""durability"": 26,
        ""ergoPenalty"": 0,
        ""name"": ""Soft_armor_left"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      },
      {
        ""nameId"": ""soft_armor_right"",
        ""zones"": [
          ""Zone Stomach, Right Side""
        ],
        ""class"": 3,
        ""durability"": 26,
        ""ergoPenalty"": 0,
        ""name"": ""soft_armor_right"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      },
      {
        ""nameId"": ""Collar"",
        ""zones"": [
          ""Zone Thorax, Throat"",
          ""Zone Thorax, Neck""
        ],
        ""class"": 3,
        ""durability"": 32,
        ""ergoPenalty"": 0,
        ""name"": ""Collar"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      },
      {
        ""nameId"": ""Shoulder_l"",
        ""zones"": [
          ""Zone Left arm, Shoulder""
        ],
        ""class"": 3,
        ""durability"": 28,
        ""ergoPenalty"": 0,
        ""name"": ""Shoulder_l"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      },
      {
        ""nameId"": ""Shoulder_r"",
        ""zones"": [
          ""Zone Right arm, Shoulder""
        ],
        ""class"": 3,
        ""durability"": 28,
        ""ergoPenalty"": 0,
        ""name"": ""Shoulder_r"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      },
      {
        ""nameId"": ""Groin"",
        ""zones"": [
          ""Zone Stomach, Groin""
        ],
        ""class"": 3,
        ""durability"": 40,
        ""ergoPenalty"": 0,
        ""name"": ""Groin"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      }
    ]
  }
},
""5648a7494bdc2d9d488b4583"": {
  ""iconLink"": ""https://assets.tarkov.dev/5648a7494bdc2d9d488b4583-icon.webp"",
  ""id"": ""5648a7494bdc2d9d488b4583"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5648a7494bdc2d9d488b4583-image.webp"",
  ""link"": ""https://tarkov.dev/item/paca-soft-armor"",
  ""name"": ""5648a7494bdc2d9d488b4583 Name"",
  ""shortName"": ""5648a7494bdc2d9d488b4583 ShortName"",
  ""weight"": 3.5,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/PACA_Soft_Armor"",
  ""conflictingItems"": [],
  ""categories"": [
    ""5448e54d4bdc2dcc718b4568"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesArmor"",
    ""class"": 2,
    ""durability"": 100,
    ""ergoPenalty"": -0.01,
    ""speedPenalty"": -0.01,
    ""turnPenalty"": 0,
    ""material"": ""Aramid"",
    ""armorSlots"": [
      {
        ""nameId"": ""Soft_armor_front"",
        ""zones"": [
          ""Zone Stomach"",
          ""Zone Thorax""
        ],
        ""class"": 2,
        ""durability"": 40,
        ""ergoPenalty"": 0,
        ""name"": ""Soft_armor_front"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      },
      {
        ""nameId"": ""Soft_armor_back"",
        ""zones"": [
          ""Zone Stomach, Lower back"",
          ""Zone Thorax, Upper back""
        ],
        ""class"": 2,
        ""durability"": 40,
        ""ergoPenalty"": 0,
        ""name"": ""Soft_armor_back"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      },
      {
        ""nameId"": ""Soft_armor_left"",
        ""zones"": [
          ""Zone Stomach, Left Side""
        ],
        ""class"": 2,
        ""durability"": 10,
        ""ergoPenalty"": 0,
        ""name"": ""Soft_armor_left"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      },
      {
        ""nameId"": ""soft_armor_right"",
        ""zones"": [
          ""Zone Stomach, Right Side""
        ],
        ""class"": 2,
        ""durability"": 10,
        ""ergoPenalty"": 0,
        ""name"": ""soft_armor_right"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      }
    ]
  }
},
""5ea18c84ecf1982c7712d9a2"": {
  ""categories"": [
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [
    ""5a16ba61fcdbcb098008728a"",
    ""5a16b672fcdbcb001912fa83"",
    ""5a16b7e1fcdbcb00165aa6c9"",
    ""5aa7e3abe5b5b000171d064d"",
    ""5c0e66e2d174af02a96252f4"",
    ""5e00cdd986f7747473332240""
  ],
  ""iconLink"": ""https://assets.tarkov.dev/5ea18c84ecf1982c7712d9a2-icon.webp"",
  ""id"": ""5ea18c84ecf1982c7712d9a2"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5ea18c84ecf1982c7712d9a2-image.webp"",
  ""link"": ""https://tarkov.dev/item/diamond-age-bastion-helmet-armor-plate"",
  ""name"": ""5ea18c84ecf1982c7712d9a2 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesArmorAttachment"",
    ""blindnessProtection"": 0,
    ""class"": 6,
    ""durability"": 40,
    ""ergoPenalty"": -0.05,
    ""zones"": [
      ""Zone Head, Nape"",
      ""Zone Head, Top of the head""
    ],
    ""material"": ""Ceramic"",
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""5c0558060db834001b735271"",
            ""5a16b8a9fcdbcb00165aa6ca""
          ]
        },
        ""nameId"": ""mod_nvg"",
        ""name"": ""MOD_NVG""
      }
    ],
    ""speedPenalty"": 0,
    ""turnPenalty"": -0.06
  },
  ""shortName"": ""5ea18c84ecf1982c7712d9a2 ShortName"",
  ""weight"": 0.99,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Diamond_Age_Bastion_helmet_armor_plate""
},
""64afdcb83efdfea28601d041"": {
  ""categories"": [
    ""644120aa86ffbe10ee032b6f"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/64afdcb83efdfea28601d041-icon.webp"",
  ""id"": ""64afdcb83efdfea28601d041"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/64afdcb83efdfea28601d041-image.webp"",
  ""link"": ""https://tarkov.dev/item/esapi-level-iv-ballistic-plate"",
  ""name"": ""64afdcb83efdfea28601d041 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesArmorAttachment"",
    ""blindnessProtection"": 0,
    ""class"": 6,
    ""durability"": 55,
    ""ergoPenalty"": -0.015,
    ""zones"": [
      ""Zone FR. PLATE"",
      ""Zone BCK. PLATE""
    ],
    ""material"": ""Ceramic"",
    ""slots"": [],
    ""speedPenalty"": -0.015,
    ""turnPenalty"": -0.005
  },
  ""shortName"": ""64afdcb83efdfea28601d041 ShortName"",
  ""weight"": 3.2,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/ESAPI_level_IV_ballistic_plate""
},
""654a4a964b446df1ad03f192"": {
  ""categories"": [
    ""644120aa86ffbe10ee032b6f"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/654a4a964b446df1ad03f192-icon.webp"",
  ""id"": ""654a4a964b446df1ad03f192"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/654a4a964b446df1ad03f192-image.webp"",
  ""link"": ""https://tarkov.dev/item/granit-4rs-ballistic-plates-back"",
  ""name"": ""654a4a964b446df1ad03f192 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesArmorAttachment"",
    ""blindnessProtection"": 0,
    ""class"": 6,
    ""durability"": 50,
    ""ergoPenalty"": -0.01,
    ""zones"": [
      ""Zone BCK. PLATE""
    ],
    ""material"": ""Ceramic"",
    ""slots"": [],
    ""speedPenalty"": -0.02,
    ""turnPenalty"": -0.01
  },
  ""shortName"": ""654a4a964b446df1ad03f192 ShortName"",
  ""weight"": 3.8,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Granit_4RS_ballistic_plates_(Back)""
},
""64afc71497cf3a403c01ff38"": {
  ""categories"": [
    ""644120aa86ffbe10ee032b6f"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/64afc71497cf3a403c01ff38-icon.webp"",
  ""id"": ""64afc71497cf3a403c01ff38"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/64afc71497cf3a403c01ff38-image.webp"",
  ""link"": ""https://tarkov.dev/item/granit-br5-ballistic-plate"",
  ""name"": ""64afc71497cf3a403c01ff38 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesArmorAttachment"",
    ""blindnessProtection"": 0,
    ""class"": 6,
    ""durability"": 60,
    ""ergoPenalty"": -0.015,
    ""zones"": [
      ""Zone F. PLATE"",
      ""Zone BCK. PLATE""
    ],
    ""material"": ""Ceramic"",
    ""slots"": [],
    ""speedPenalty"": -0.02,
    ""turnPenalty"": -0.015
  },
  ""shortName"": ""64afc71497cf3a403c01ff38 ShortName"",
  ""weight"": 3.3,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Granit_Br5_ballistic_plate""
},
""64afd81707e2cf40e903a316"": {
  ""categories"": [
    ""644120aa86ffbe10ee032b6f"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/64afd81707e2cf40e903a316-icon.webp"",
  ""id"": ""64afd81707e2cf40e903a316"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/64afd81707e2cf40e903a316-image.webp"",
  ""link"": ""https://tarkov.dev/item/granit-ballistic-plate-side"",
  ""name"": ""64afd81707e2cf40e903a316 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesArmorAttachment"",
    ""blindnessProtection"": 0,
    ""class"": 6,
    ""durability"": 20,
    ""ergoPenalty"": 0,
    ""zones"": [
      ""Zone L. PLATE"",
      ""Zone L. PLATE"",
      ""Zone R. PLATE"",
      ""Zone R. PLATE""
    ],
    ""material"": ""Ceramic"",
    ""slots"": [],
    ""speedPenalty"": -0.0075,
    ""turnPenalty"": -0.0075
  },
  ""shortName"": ""64afd81707e2cf40e903a316 ShortName"",
  ""weight"": 1.3,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Granit_ballistic_plate_(Side)""
},
""5a16b7e1fcdbcb00165aa6c9"": {
  ""categories"": [
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [
    ""5c0e66e2d174af02a96252f4"",
    ""5c0696830db834001d23f5da"",
    ""5c066e3a0db834001b7353f0"",
    ""5c0558060db834001b735271"",
    ""57235b6f24597759bf5a30f1"",
    ""5c110624d174af029e69734c"",
    ""5a16b8a9fcdbcb00165aa6ca"",
    ""5a398b75c4a282000a51a266"",
    ""5a398ab9c4a282000c5a9842""
  ],
  ""iconLink"": ""https://assets.tarkov.dev/5a16b7e1fcdbcb00165aa6c9-icon.webp"",
  ""id"": ""5a16b7e1fcdbcb00165aa6c9"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a16b7e1fcdbcb00165aa6c9-image.webp"",
  ""link"": ""https://tarkov.dev/item/ops-core-fast-multi-hit-ballistic-face-shield"",
  ""name"": ""5a16b7e1fcdbcb00165aa6c9 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesArmorAttachment"",
    ""blindnessProtection"": 0.1,
    ""class"": 3,
    ""durability"": 40,
    ""ergoPenalty"": -0.04,
    ""zones"": [
      ""Zone Head, Eyes"",
      ""Zone Head, Face"",
      ""Zone Head, Jaws""
    ],
    ""material"": ""Glass"",
    ""slots"": [],
    ""speedPenalty"": 0,
    ""turnPenalty"": -0.08
  },
  ""shortName"": ""5a16b7e1fcdbcb00165aa6c9 ShortName"",
  ""weight"": 1.2,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Ops-Core_FAST_multi-hit_ballistic_face_shield""
},
""5ab8ebf186f7742d8b372e80"": {
  ""categories"": [
    ""5448e53e4bdc2d60728b4567"",
    ""566168634bdc2d144c8b456c"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5ab8ebf186f7742d8b372e80-icon.webp"",
  ""id"": ""5ab8ebf186f7742d8b372e80"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5ab8ebf186f7742d8b372e80-image.webp"",
  ""link"": ""https://tarkov.dev/item/sso-attack-2-raid-backpack-khaki"",
  ""name"": ""5ab8ebf186f7742d8b372e80 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesBackpack"",
    ""capacity"": 35,
    ""ergoPenalty"": -0.07,
    ""speedPenalty"": -0.05,
    ""turnPenalty"": -0.03
  },
  ""shortName"": ""5ab8ebf186f7742d8b372e80 ShortName"",
  ""weight"": 2.8,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/SSO_Attack_2_raid_backpack_(Khaki)""
},
""58aeaaa886f7744fc1560f81"": {
  ""categories"": [
    ""555ef6e44bdc2de9068b457e"",
    ""55802f4a4bdc2ddb688b4569"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [
    ""5c59529a2e221602b177d160"",
    ""5c5db6302e2216000e5e47f0"",
    ""5c5db63a2e2216000f1b284a""
  ],
  ""iconLink"": ""https://assets.tarkov.dev/58aeaaa886f7744fc1560f81-icon.webp"",
  ""id"": ""58aeaaa886f7744fc1560f81"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58aeaaa886f7744fc1560f81-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-sd-9x19-165mm-barrel"",
  ""name"": ""58aeaaa886f7744fc1560f81 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesBarrel"",
    ""ergonomics"": -3,
    ""recoilModifier"": -0.02,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""58aeac1b86f77457c419f475""
          ]
        },
        ""nameId"": ""mod_muzzle"",
        ""name"": ""MOD_MUZZLE""
      }
    ]
  },
  ""shortName"": ""58aeaaa886f7744fc1560f81 ShortName"",
  ""weight"": 0.18,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX-SD_9x19_165mm_barrel""
},
""61bc85697113f767765c7fe7"": {
  ""iconLink"": ""https://assets.tarkov.dev/61bc85697113f767765c7fe7-icon.webp"",
  ""id"": ""61bc85697113f767765c7fe7"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/61bc85697113f767765c7fe7-image.webp"",
  ""link"": ""https://tarkov.dev/item/eagle-industries-mmac-plate-carrier-ranger-green"",
  ""name"": ""61bc85697113f767765c7fe7 Name"",
  ""shortName"": ""61bc85697113f767765c7fe7 ShortName"",
  ""weight"": 2.83,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Eagle_Industries_MMAC_plate_carrier_(Ranger_Green)"",
  ""conflictingItems"": [],
  ""categories"": [
    ""5448e5284bdc2dcb718b4567"",
    ""566168634bdc2d144c8b456c"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesChestRig"",
    ""capacity"": 14,
    ""class"": 4,
    ""durability"": 144,
    ""ergoPenalty"": -0.01,
    ""speedPenalty"": -0.01,
    ""turnPenalty"": -0.01,
    ""material"": ""Aramid"",
    ""armorSlots"": [
      {
        ""nameId"": ""Front_plate"",
        ""zones"": [
          ""Zone FR. PLATE""
        ],
        ""allowedPlates"": [
          ""656f9d5900d62bcd2e02407c"",
          ""656fa99800d62bcd2e024088"",
          ""656fa8d700d62bcd2e024084"",
          ""656faf0ca0dce000a2020f77"",
          ""656fae5f7c2d57afe200c0d7"",
          ""656fa0fb498d1b7e3e071d9c"",
          ""656fafe3498d1b7e3e071da4"",
          ""656fa76500d62bcd2e024080"",
          ""656fa25e94b480b8a500c0e0"",
          ""656fad8c498d1b7e3e071da0"",
          ""656fa61e94b480b8a500c0e8"",
          ""656fb21fa0dce000a2020f7c"",
          ""656fac30c6baea13cd07e10c"",
          ""656fb0bd7c2d57afe200c0dc"",
          ""656f9fa0498d1b7e3e071d98"",
          ""656fa53d94b480b8a500c0e4"",
          ""655746010177119f4a097ff7"",
          ""64afdcb83efdfea28601d041""
        ]
      },
      {
        ""nameId"": ""Back_plate"",
        ""zones"": [
          ""Zone BCK. PLATE""
        ],
        ""allowedPlates"": [
          ""656f9d5900d62bcd2e02407c"",
          ""656fa8d700d62bcd2e024084"",
          ""656fa99800d62bcd2e024088"",
          ""656faf0ca0dce000a2020f77"",
          ""656fae5f7c2d57afe200c0d7"",
          ""656fa0fb498d1b7e3e071d9c"",
          ""656fafe3498d1b7e3e071da4"",
          ""656fa76500d62bcd2e024080"",
          ""656fa25e94b480b8a500c0e0"",
          ""656fad8c498d1b7e3e071da0"",
          ""656fa61e94b480b8a500c0e8"",
          ""656fb21fa0dce000a2020f7c"",
          ""656fac30c6baea13cd07e10c"",
          ""656fb0bd7c2d57afe200c0dc"",
          ""656f9fa0498d1b7e3e071d98"",
          ""656fa53d94b480b8a500c0e4"",
          ""655746010177119f4a097ff7"",
          ""64afdcb83efdfea28601d041""
        ]
      },
      {
        ""nameId"": ""Left_side_plate"",
        ""zones"": [
          ""Zone L. PLATE""
        ],
        ""allowedPlates"": [
          ""6557458f83942d705f0c4962"",
          ""64afdb577bb3bfe8fe03fd1d"",
          ""64afd81707e2cf40e903a316""
        ]
      },
      {
        ""nameId"": ""Right_side_plate"",
        ""zones"": [
          ""Zone R. PLATE""
        ],
        ""allowedPlates"": [
          ""6557458f83942d705f0c4962"",
          ""64afdb577bb3bfe8fe03fd1d"",
          ""64afd81707e2cf40e903a316""
        ]
      },
      {
        ""nameId"": ""Soft_armor_front"",
        ""zones"": [
          ""Zone FR. PLATE""
        ],
        ""class"": 2,
        ""durability"": 22,
        ""ergoPenalty"": 0,
        ""name"": ""Soft_armor_front"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      },
      {
        ""nameId"": ""Soft_armor_back"",
        ""zones"": [
          ""Zone BCK. PLATE""
        ],
        ""class"": 2,
        ""durability"": 22,
        ""ergoPenalty"": 0,
        ""name"": ""Soft_armor_back"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      },
      {
        ""nameId"": ""Soft_armor_left"",
        ""zones"": [
          ""Zone Stomach, Left Side""
        ],
        ""class"": 2,
        ""durability"": 10,
        ""ergoPenalty"": 0,
        ""name"": ""Soft_armor_left"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      },
      {
        ""nameId"": ""soft_armor_right"",
        ""zones"": [
          ""Zone Stomach, Right Side""
        ],
        ""class"": 2,
        ""durability"": 10,
        ""ergoPenalty"": 0,
        ""name"": ""soft_armor_right"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Aramid""
      }
    ]
  }
},
""572b7adb24597762ae139821"": {
  ""categories"": [
    ""5448e5284bdc2dcb718b4567"",
    ""566168634bdc2d144c8b456c"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/572b7adb24597762ae139821-icon.webp"",
  ""id"": ""572b7adb24597762ae139821"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/572b7adb24597762ae139821-image.webp"",
  ""link"": ""https://tarkov.dev/item/scav-vest"",
  ""name"": ""572b7adb24597762ae139821 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesChestRig"",
    ""armorSlots"": null,
    ""capacity"": 6,
    ""class"": null,
    ""durability"": null,
    ""ergoPenalty"": 0,
    ""material"": null,
    ""speedPenalty"": 0,
    ""turnPenalty"": 0
  },
  ""shortName"": ""572b7adb24597762ae139821 ShortName"",
  ""weight"": 0.4,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Scav_Vest""
},
""5c093ca986f7740a1867ab12"": {
  ""categories"": [
    ""5448bf274bdc2dfc2f8b456a"",
    ""566168634bdc2d144c8b456c"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5c093ca986f7740a1867ab12-icon.webp"",
  ""id"": ""5c093ca986f7740a1867ab12"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5c093ca986f7740a1867ab12-image.webp"",
  ""link"": ""https://tarkov.dev/item/secure-container-kappa"",
  ""name"": ""5c093ca986f7740a1867ab12 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesContainer"",
    ""capacity"": 12
  },
  ""shortName"": ""5c093ca986f7740a1867ab12 ShortName"",
  ""weight"": 2,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Secure_container_Kappa""
},
""5783c43d2459774bbe137486"": {
  ""categories"": [
    ""5795f317245977243854e041"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5783c43d2459774bbe137486-icon.webp"",
  ""id"": ""5783c43d2459774bbe137486"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5783c43d2459774bbe137486-image.webp"",
  ""link"": ""https://tarkov.dev/item/simple-wallet"",
  ""name"": ""5783c43d2459774bbe137486 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesContainer"",
    ""capacity"": 4
  },
  ""shortName"": ""5783c43d2459774bbe137486 ShortName"",
  ""weight"": 0.15,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Simple_wallet""
},
""5b432be65acfc433000ed01f"": {
  ""categories"": [
    ""5448e5724bdc2ddf718b4568"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5b432be65acfc433000ed01f-icon.webp"",
  ""id"": ""5b432be65acfc433000ed01f"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5b432be65acfc433000ed01f-image.webp"",
  ""link"": ""https://tarkov.dev/item/6b34-anti-fragmentation-glasses"",
  ""name"": ""5b432be65acfc433000ed01f Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesGlasses"",
    ""blindnessProtection"": 0.1,
    ""class"": 0,
    ""durability"": 0,
    ""material"": ""UHMWPE""
  },
  ""shortName"": ""5b432be65acfc433000ed01f ShortName"",
  ""weight"": 0.12,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/6B34_anti-fragmentation_glasses""
},
""603409c80ca681766b6a0fb2"": {
  ""categories"": [
    ""5448e5724bdc2ddf718b4568"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/603409c80ca681766b6a0fb2-icon.webp"",
  ""id"": ""603409c80ca681766b6a0fb2"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/603409c80ca681766b6a0fb2-image.webp"",
  ""link"": ""https://tarkov.dev/item/npp-klass-condor-glasses"",
  ""name"": ""603409c80ca681766b6a0fb2 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesGlasses"",
    ""blindnessProtection"": 0.1,
    ""class"": 1,
    ""durability"": 25,
    ""material"": ""Glass""
  },
  ""shortName"": ""603409c80ca681766b6a0fb2 ShortName"",
  ""weight"": 0.03,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/NPP_KlASS_Condor_glasses""
},
""5a0c27731526d80618476ac4"": {
  ""categories"": [
    ""543be6564bdc2df4348b4568"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5a0c27731526d80618476ac4-icon.webp"",
  ""id"": ""5a0c27731526d80618476ac4"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a0c27731526d80618476ac4-image.webp"",
  ""link"": ""https://tarkov.dev/item/zarya-stun-grenade"",
  ""name"": ""5a0c27731526d80618476ac4 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesGrenade"",
    ""contusionRadius"": 10,
    ""fragments"": 0,
    ""fuse"": 2,
    ""maxExplosionDistance"": 0,
    ""minExplosionDistance"": 0,
    ""type"": ""Flashbang""
  },
  ""shortName"": ""5a0c27731526d80618476ac4 ShortName"",
  ""weight"": 0.175,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/%22Zarya%22_stun_grenade""
},
""618a431df1eb8e24b8741deb"": {
  ""iconLink"": ""https://assets.tarkov.dev/618a431df1eb8e24b8741deb-icon.webp"",
  ""id"": ""618a431df1eb8e24b8741deb"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/618a431df1eb8e24b8741deb-image.webp"",
  ""link"": ""https://tarkov.dev/item/rgo-hand-grenade"",
  ""name"": ""618a431df1eb8e24b8741deb Name"",
  ""shortName"": ""618a431df1eb8e24b8741deb ShortName"",
  ""weight"": 0.53,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/RGO_hand_grenade"",
  ""conflictingItems"": [],
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesGrenade"",
    ""contusionRadius"": 12,
    ""fragments"": 85,
    ""fuse"": 3.5,
    ""maxExplosionDistance"": 7,
    ""minExplosionDistance"": 2,
    ""type"": ""Impact Grenade""
  },
  ""categories"": [
    ""543be6564bdc2df4348b4568"",
    ""54009119af1c881c07000029""
  ]
},
""5e32f56fcb6d5863cc5e5ee4"": {
  ""categories"": [
    ""543be6564bdc2df4348b4568"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5e32f56fcb6d5863cc5e5ee4-icon.webp"",
  ""id"": ""5e32f56fcb6d5863cc5e5ee4"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5e32f56fcb6d5863cc5e5ee4-image.webp"",
  ""link"": ""https://tarkov.dev/item/vog-17-khattabka-improvised-hand-grenade"",
  ""name"": ""5e32f56fcb6d5863cc5e5ee4 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesGrenade"",
    ""contusionRadius"": 9,
    ""fragments"": 100,
    ""fuse"": 3,
    ""maxExplosionDistance"": 6,
    ""minExplosionDistance"": 2,
    ""type"": ""Grenade""
  },
  ""shortName"": ""5e32f56fcb6d5863cc5e5ee4 ShortName"",
  ""weight"": 0.28,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/VOG-17_Khattabka_improvised_hand_grenade""
},
""5a2a57cfc4a2826c6e06d44a"": {
  ""iconLink"": ""https://assets.tarkov.dev/5a2a57cfc4a2826c6e06d44a-icon.webp"",
  ""id"": ""5a2a57cfc4a2826c6e06d44a"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a2a57cfc4a2826c6e06d44a-image.webp"",
  ""link"": ""https://tarkov.dev/item/rdg-2b-smoke-grenade"",
  ""name"": ""5a2a57cfc4a2826c6e06d44a Name"",
  ""shortName"": ""5a2a57cfc4a2826c6e06d44a ShortName"",
  ""weight"": 0.6,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/RDG-2B_smoke_grenade"",
  ""conflictingItems"": [],
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesGrenade"",
    ""contusionRadius"": 0,
    ""fragments"": 0,
    ""fuse"": 3.5,
    ""maxExplosionDistance"": 0,
    ""minExplosionDistance"": 0,
    ""type"": ""Smoke""
  },
  ""categories"": [
    ""543be6564bdc2df4348b4568"",
    ""54009119af1c881c07000029""
  ]
},
""628e4e576d783146b124c64d"": {
  ""categories"": [
    ""5645bcb74bdc2ded0b8b4578"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/628e4e576d783146b124c64d-icon.webp"",
  ""id"": ""628e4e576d783146b124c64d"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/628e4e576d783146b124c64d-image.webp"",
  ""link"": ""https://tarkov.dev/item/peltor-comtac-4-hybrid-headset-coyote-brown"",
  ""name"": ""628e4e576d783146b124c64d Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesHeadphone""
  },
  ""shortName"": ""628e4e576d783146b124c64d ShortName"",
  ""weight"": 0.6,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Peltor_ComTac_4_Hybrid_headset_(Coyote_Brown)""
},
""5bd073c986f7747f627e796c"": {
  ""categories"": [
    ""5a341c4086f77401f2541505"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5bd073c986f7747f627e796c-icon.webp"",
  ""id"": ""5bd073c986f7747f627e796c"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5bd073c986f7747f627e796c-image.webp"",
  ""link"": ""https://tarkov.dev/item/kotton-beanie"",
  ""name"": ""5bd073c986f7747f627e796c Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesHeadwear"",
    ""slots"": []
  },
  ""shortName"": ""5bd073c986f7747f627e796c ShortName"",
  ""weight"": 0.2,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Kotton_beanie""
},
""5a16bb52fcdbcb001a3b00dc"": {
  ""categories"": [
    ""5a341c4086f77401f2541505"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5a16bb52fcdbcb001a3b00dc-icon.webp"",
  ""id"": ""5a16bb52fcdbcb001a3b00dc"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a16bb52fcdbcb001a3b00dc-image.webp"",
  ""link"": ""https://tarkov.dev/item/wilcox-skull-lock-head-mount"",
  ""name"": ""5a16bb52fcdbcb001a3b00dc Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesHeadwear"",
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""5a16b8a9fcdbcb00165aa6ca""
          ]
        },
        ""nameId"": ""mod_nvg"",
        ""name"": ""MOD_NVG""
      }
    ]
  },
  ""shortName"": ""5a16bb52fcdbcb001a3b00dc ShortName"",
  ""weight"": 0.5,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Wilcox_Skull_Lock_head_mount""
},
""59ef13ca86f77445fd0e2483"": {
  ""categories"": [
    ""5a341c4086f77401f2541505"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/59ef13ca86f77445fd0e2483-icon.webp"",
  ""id"": ""59ef13ca86f77445fd0e2483"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/59ef13ca86f77445fd0e2483-image.webp"",
  ""link"": ""https://tarkov.dev/item/jack-o-lantern-tactical-pumpkin-helmet"",
  ""name"": ""59ef13ca86f77445fd0e2483 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesHelmet"",
    ""armorSlots"": [],
    ""blocksHeadset"": true,
    ""class"": 2,
    ""deafening"": ""Low"",
    ""durability"": 40,
    ""ergoPenalty"": 0,
    ""material"": ""UHMWPE"",
    ""ricochetX"": 0,
    ""slots"": [],
    ""speedPenalty"": 0,
    ""turnPenalty"": -0.01
  },
  ""shortName"": ""59ef13ca86f77445fd0e2483 ShortName"",
  ""weight"": 1.2,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Jack-o%27-lantern_tactical_pumpkin_helmet""
},
""5e4bfc1586f774264f7582d3"": {
  ""iconLink"": ""https://assets.tarkov.dev/5e4bfc1586f774264f7582d3-icon.webp"",
  ""id"": ""5e4bfc1586f774264f7582d3"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5e4bfc1586f774264f7582d3-image.webp"",
  ""link"": ""https://tarkov.dev/item/msa-gallet-tc-800-high-cut-combat-helmet-black"",
  ""name"": ""5e4bfc1586f774264f7582d3 Name"",
  ""shortName"": ""5e4bfc1586f774264f7582d3 ShortName"",
  ""weight"": 1.17,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MSA_Gallet_TC_800_High_Cut_combat_helmet_(Black)"",
  ""conflictingItems"": [],
  ""categories"": [
    ""5a341c4086f77401f2541505"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesHelmet"",
    ""blindnessProtection"": 0,
    ""blocksHeadset"": false,
    ""class"": 4,
    ""deafening"": ""None"",
    ""durability"": 36,
    ""ergoPenalty"": -0.01,
    ""ricochetX"": 0.9,
    ""speedPenalty"": 0,
    ""turnPenalty"": -0.02,
    ""material"": ""Combined"",
    ""armorSlots"": [
      {
        ""nameId"": ""Helmet_top"",
        ""zones"": [
          ""Zone Head, Top of the head""
        ],
        ""class"": 4,
        ""durability"": 18,
        ""ergoPenalty"": 0,
        ""name"": ""Helmet_top"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Combined""
      },
      {
        ""nameId"": ""Helmet_back"",
        ""zones"": [
          ""Zone Head, Nape""
        ],
        ""class"": 4,
        ""durability"": 18,
        ""ergoPenalty"": 0,
        ""name"": ""Helmet_back"",
        ""speedPenalty"": 0,
        ""turnPenalty"": 0,
        ""material"": ""Combined""
      }
    ],
    ""slots"": [
      {
        ""nameId"": ""mod_equipment_000"",
        ""name"": ""MOD_EQUIPMENT_000"",
        ""filters"": {
          ""allowedItems"": [
            ""5a16b672fcdbcb001912fa83"",
            ""5a16b7e1fcdbcb00165aa6c9""
          ]
        }
      },
      {
        ""nameId"": ""mod_nvg"",
        ""name"": ""MOD_NVG"",
        ""filters"": {
          ""allowedItems"": [
            ""5c0558060db834001b735271"",
            ""5a16b8a9fcdbcb00165aa6ca""
          ]
        }
      },
      {
        ""nameId"": ""mod_mount"",
        ""name"": ""MOD_MOUNT"",
        ""filters"": {
          ""allowedItems"": [
            ""5a398b75c4a282000a51a266"",
            ""5a398ab9c4a282000c5a9842""
          ]
        }
      }
    ]
  }
},
""5c1d0c5f86f7744bb2683cf0"": {
  ""categories"": [
    ""5c164d2286f774194c5e69fa"",
    ""543be5e94bdc2df1348b4568"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5c1d0c5f86f7744bb2683cf0-icon.webp"",
  ""id"": ""5c1d0c5f86f7744bb2683cf0"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5c1d0c5f86f7744bb2683cf0-image.webp"",
  ""link"": ""https://tarkov.dev/item/terragroup-labs-keycard-blue"",
  ""name"": ""5c1d0c5f86f7744bb2683cf0 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesKey""
  },
  ""shortName"": ""5c1d0c5f86f7744bb2683cf0 ShortName"",
  ""weight"": 0.01,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/TerraGroup_Labs_keycard_(Blue)""
},
""564ca99c4bdc2d16268b4589"": {
  ""categories"": [
    ""5448bc234bdc2d3c308b4569"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/564ca99c4bdc2d16268b4589-icon.webp"",
  ""id"": ""564ca99c4bdc2d16268b4589"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/564ca99c4bdc2d16268b4589-image.webp"",
  ""link"": ""https://tarkov.dev/item/ak-74-545x39-6l20-30-round-magazine"",
  ""name"": ""564ca99c4bdc2d16268b4589 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesMagazine"",
    ""allowedAmmo"": [
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
    ""ammoCheckModifier"": 0,
    ""capacity"": 30,
    ""ergonomics"": -3,
    ""loadModifier"": 0,
    ""malfunctionChance"": 0.07,
    ""slots"": []
  },
  ""shortName"": ""564ca99c4bdc2d16268b4589 ShortName"",
  ""weight"": 0.215,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AK-74_5.45x39_6L20_30-round_magazine""
},
""5e81c4ca763d9f754677befa"": {
  ""categories"": [
    ""5448bc234bdc2d3c308b4569"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5e81c4ca763d9f754677befa-icon.webp"",
  ""id"": ""5e81c4ca763d9f754677befa"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5e81c4ca763d9f754677befa-image.webp"",
  ""link"": ""https://tarkov.dev/item/m1911a1-45-acp-7-round-magazine"",
  ""name"": ""5e81c4ca763d9f754677befa Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesMagazine"",
    ""allowedAmmo"": [
      ""5e81f423763d9f754677bf2e"",
      ""5efb0cabfb3e451d70735af5"",
      ""5efb0fc6aeb21837e749c801"",
      ""5efb0d4f4bc50b58e81710f3"",
      ""5ea2a8e200685063ec28c05a""
    ],
    ""ammoCheckModifier"": -0.2,
    ""capacity"": 7,
    ""ergonomics"": -1,
    ""loadModifier"": -0.25,
    ""malfunctionChance"": 0.04,
    ""slots"": []
  },
  ""shortName"": ""5e81c4ca763d9f754677befa ShortName"",
  ""weight"": 0.16,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/M1911A1_.45_ACP_7-round_magazine""
},
""5894a05586f774094708ef75"": {
  ""categories"": [
    ""5448bc234bdc2d3c308b4569"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5894a05586f774094708ef75-icon.webp"",
  ""id"": ""5894a05586f774094708ef75"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5894a05586f774094708ef75-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-9x19-30-round-magazine"",
  ""name"": ""5894a05586f774094708ef75 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesMagazine"",
    ""allowedAmmo"": [
      ""5efb0da7a29a85116f6ea05f"",
      ""5c3df7d588a4501f290594e5"",
      ""58864a4f2459770fcc257101"",
      ""56d59d3ad2720bdb418b4577"",
      ""5c925fa22e221601da359b7b"",
      ""5a3c16fe86f77452b62de32a"",
      ""5efb0e16aeb21837e749c7ff"",
      ""5c0d56a986f774449d5de529"",
      ""64b7bbb74b75259c590fa897""
    ],
    ""ammoCheckModifier"": -0.5,
    ""capacity"": 30,
    ""ergonomics"": -3,
    ""loadModifier"": 0,
    ""malfunctionChance"": 0.05,
    ""slots"": []
  },
  ""shortName"": ""5894a05586f774094708ef75 ShortName"",
  ""weight"": 0.17,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX_9x19_30-round_magazine""
},
""60dc519adf4c47305f6d410d"": {
  ""iconLink"": ""https://assets.tarkov.dev/60dc519adf4c47305f6d410d-icon.webp"",
  ""id"": ""60dc519adf4c47305f6d410d"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/60dc519adf4c47305f6d410d-image.webp"",
  ""link"": ""https://tarkov.dev/item/mts-255-12-12ga-cylinder"",
  ""name"": ""60dc519adf4c47305f6d410d Name"",
  ""shortName"": ""60dc519adf4c47305f6d410d ShortName"",
  ""weight"": 0.25,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MTs-255-12_12ga_cylinder"",
  ""conflictingSlotIds"": [],
  ""conflictingItems"": [],
  ""categories"": [
    ""610720f290b75a49ff2e5e25"",
    ""5448bc234bdc2d3c308b4569"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesMagazine"",
    ""ammoCheckModifier"": 0,
    ""capacity"": 5,
    ""ergonomics"": -2,
    ""loadModifier"": 0,
    ""malfunctionChance"": 0,
    ""allowedAmmo"": [
      ""560d5e524bdc2d25448b4571"",
      ""5d6e6772a4b936088465b17c"",
      ""5d6e67fba4b9361bc73bc779"",
      ""5d6e6806a4b936088465b17e"",
      ""5d6e68dea4b9361bcc29e659"",
      ""5d6e6911a4b9361bd5780d52"",
      ""5c0d591486f7744c505b416f"",
      ""58820d1224597753c90aeb13"",
      ""5d6e68c4a4b9361b93413f79"",
      ""5d6e68a8a4b9360b6c0d54e2"",
      ""5d6e68e6a4b9361c140bcfe0"",
      ""5d6e6869a4b9361c140bcfde"",
      ""5d6e68b3a4b9361bca7e50b5"",
      ""5d6e6891a4b9361bd473feea"",
      ""5d6e689ca4b9361bc8618956"",
      ""5d6e68d1a4b93622fe60e845"",
      ""64b8ee384b75259c590fa89b""
    ],
    ""slots"": [
      {
        ""nameId"": ""camora_000"",
        ""name"": ""CAMORA_000"",
        ""filters"": {
          ""allowedItems"": [
            ""560d5e524bdc2d25448b4571"",
            ""5d6e6772a4b936088465b17c"",
            ""5d6e67fba4b9361bc73bc779"",
            ""5d6e6806a4b936088465b17e"",
            ""5d6e68dea4b9361bcc29e659"",
            ""5d6e6911a4b9361bd5780d52"",
            ""5c0d591486f7744c505b416f"",
            ""58820d1224597753c90aeb13"",
            ""5d6e68c4a4b9361b93413f79"",
            ""5d6e68a8a4b9360b6c0d54e2"",
            ""5d6e68e6a4b9361c140bcfe0"",
            ""5d6e6869a4b9361c140bcfde"",
            ""5d6e68b3a4b9361bca7e50b5"",
            ""5d6e6891a4b9361bd473feea"",
            ""5d6e689ca4b9361bc8618956"",
            ""5d6e68d1a4b93622fe60e845"",
            ""64b8ee384b75259c590fa89b""
          ]
        }
      },
      {
        ""nameId"": ""camora_001"",
        ""name"": ""CAMORA_001"",
        ""filters"": {
          ""allowedItems"": [
            ""560d5e524bdc2d25448b4571"",
            ""5d6e6772a4b936088465b17c"",
            ""5d6e67fba4b9361bc73bc779"",
            ""5d6e6806a4b936088465b17e"",
            ""5d6e68dea4b9361bcc29e659"",
            ""5d6e6911a4b9361bd5780d52"",
            ""5c0d591486f7744c505b416f"",
            ""58820d1224597753c90aeb13"",
            ""5d6e68c4a4b9361b93413f79"",
            ""5d6e68a8a4b9360b6c0d54e2"",
            ""5d6e68e6a4b9361c140bcfe0"",
            ""5d6e6869a4b9361c140bcfde"",
            ""5d6e68b3a4b9361bca7e50b5"",
            ""5d6e6891a4b9361bd473feea"",
            ""5d6e689ca4b9361bc8618956"",
            ""5d6e68d1a4b93622fe60e845"",
            ""64b8ee384b75259c590fa89b""
          ]
        }
      },
      {
        ""nameId"": ""camora_002"",
        ""name"": ""CAMORA_002"",
        ""filters"": {
          ""allowedItems"": [
            ""560d5e524bdc2d25448b4571"",
            ""5d6e6772a4b936088465b17c"",
            ""5d6e67fba4b9361bc73bc779"",
            ""5d6e6806a4b936088465b17e"",
            ""5d6e68dea4b9361bcc29e659"",
            ""5d6e6911a4b9361bd5780d52"",
            ""5c0d591486f7744c505b416f"",
            ""58820d1224597753c90aeb13"",
            ""5d6e68c4a4b9361b93413f79"",
            ""5d6e68a8a4b9360b6c0d54e2"",
            ""5d6e68e6a4b9361c140bcfe0"",
            ""5d6e6869a4b9361c140bcfde"",
            ""5d6e68b3a4b9361bca7e50b5"",
            ""5d6e6891a4b9361bd473feea"",
            ""5d6e689ca4b9361bc8618956"",
            ""5d6e68d1a4b93622fe60e845"",
            ""64b8ee384b75259c590fa89b""
          ]
        }
      },
      {
        ""nameId"": ""camora_003"",
        ""name"": ""CAMORA_003"",
        ""filters"": {
          ""allowedItems"": [
            ""560d5e524bdc2d25448b4571"",
            ""5d6e6772a4b936088465b17c"",
            ""5d6e67fba4b9361bc73bc779"",
            ""5d6e6806a4b936088465b17e"",
            ""5d6e68dea4b9361bcc29e659"",
            ""5d6e6911a4b9361bd5780d52"",
            ""5c0d591486f7744c505b416f"",
            ""58820d1224597753c90aeb13"",
            ""5d6e68c4a4b9361b93413f79"",
            ""5d6e68a8a4b9360b6c0d54e2"",
            ""5d6e68e6a4b9361c140bcfe0"",
            ""5d6e6869a4b9361c140bcfde"",
            ""5d6e68b3a4b9361bca7e50b5"",
            ""5d6e6891a4b9361bd473feea"",
            ""5d6e689ca4b9361bc8618956"",
            ""5d6e68d1a4b93622fe60e845"",
            ""64b8ee384b75259c590fa89b""
          ]
        }
      },
      {
        ""nameId"": ""camora_004"",
        ""name"": ""CAMORA_004"",
        ""filters"": {
          ""allowedItems"": [
            ""560d5e524bdc2d25448b4571"",
            ""5d6e6772a4b936088465b17c"",
            ""5d6e67fba4b9361bc73bc779"",
            ""5d6e6806a4b936088465b17e"",
            ""5d6e68dea4b9361bcc29e659"",
            ""5d6e6911a4b9361bd5780d52"",
            ""5c0d591486f7744c505b416f"",
            ""58820d1224597753c90aeb13"",
            ""5d6e68c4a4b9361b93413f79"",
            ""5d6e68a8a4b9360b6c0d54e2"",
            ""5d6e68e6a4b9361c140bcfe0"",
            ""5d6e6869a4b9361c140bcfde"",
            ""5d6e68b3a4b9361bca7e50b5"",
            ""5d6e6891a4b9361bd473feea"",
            ""5d6e689ca4b9361bc8618956"",
            ""5d6e68d1a4b93622fe60e845"",
            ""64b8ee384b75259c590fa89b""
          ]
        }
      }
    ]
  }
},
""5c0126f40db834002a125382"": {
  ""categories"": [
    ""5447e1d04bdc2dff2f8b4567"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5c0126f40db834002a125382-icon.webp"",
  ""id"": ""5c0126f40db834002a125382"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5c0126f40db834002a125382-image.webp"",
  ""link"": ""https://tarkov.dev/item/red-rebel-ice-pick"",
  ""name"": ""5c0126f40db834002a125382 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesMelee"",
    ""hitRadius"": 0.6,
    ""slashDamage"": 29,
    ""stabDamage"": 35
  },
  ""shortName"": ""5c0126f40db834002a125382 ShortName"",
  ""weight"": 0.65,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Red_Rebel_ice_pick""
},
""57235b6f24597759bf5a30f1"": {
  ""categories"": [
    ""5a2c3a9486f774688b05e574"",
    ""55818aeb4bdc2ddc698b456a"",
    ""5448fe7a4bdc2d6f028b456b"",
    ""550aa4154bdc2dd8348b456b"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57235b6f24597759bf5a30f1-icon.webp"",
  ""id"": ""57235b6f24597759bf5a30f1"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57235b6f24597759bf5a30f1-image.webp"",
  ""link"": ""https://tarkov.dev/item/anpvs-14-night-vision-monocular"",
  ""name"": ""57235b6f24597759bf5a30f1 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesNightVision""
  },
  ""shortName"": ""57235b6f24597759bf5a30f1 ShortName"",
  ""weight"": 0.65,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AN/PVS-14_Night_Vision_Monocular""
},
""65766adc234b9f6e050a431a"": {
  ""iconLink"": ""https://assets.tarkov.dev/65766adc234b9f6e050a431a-icon.webp"",
  ""id"": ""65766adc234b9f6e050a431a"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/65766adc234b9f6e050a431a-image.webp"",
  ""link"": ""https://tarkov.dev/item/6b43-zabralo-sh-body-armor-emr-default"",
  ""name"": ""65766adc234b9f6e050a431a Name"",
  ""shortName"": ""65766adc234b9f6e050a431a ShortName"",
  ""weight"": 20,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/6B43_Zabralo-Sh_body_armor_(EMR)"",
  ""conflictingItems"": [],
  ""categories"": [
    ""5448e54d4bdc2dcc718b4568"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesPreset"",
    ""moa"": null,
    ""baseItem"": ""545cdb794bdc2d3a198b456a""
  },
  ""containsItems"": [
    {
      ""item"": ""545cdb794bdc2d3a198b456a"",
      ""count"": 1
    },
    {
      ""item"": ""64afc71497cf3a403c01ff38"",
      ""count"": 2
    },
    {
      ""item"": ""64afd81707e2cf40e903a316"",
      ""count"": 2
    }
  ]
},
""618aaeb931ddad66c15eb7e9"": {
  ""categories"": [
    ""5447b5fc4bdc2d87278b4567"",
    ""5422acb9af1c889c16000029"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/618aaeb931ddad66c15eb7e9-icon.webp"",
  ""id"": ""618aaeb931ddad66c15eb7e9"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/618aaeb931ddad66c15eb7e9-image.webp"",
  ""link"": ""https://tarkov.dev/item/as-val-9x39-special-assault-rifle-kobra"",
  ""name"": ""618aaeb931ddad66c15eb7e9 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesPreset"",
    ""baseItem"": ""57c44b372459772d2b39b8ce"",
    ""moa"": 3.44
  },
  ""shortName"": ""618aaeb931ddad66c15eb7e9 ShortName"",
  ""weight"": 3.085,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AS_VAL_9x39_special_assault_rifle""
},
""657660eb86f11bca4106d34f"": {
  ""iconLink"": ""https://assets.tarkov.dev/657660eb86f11bca4106d34f-icon.webp"",
  ""id"": ""657660eb86f11bca4106d34f"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/657660eb86f11bca4106d34f-image.webp"",
  ""link"": ""https://tarkov.dev/item/eagle-industries-mmac-plate-carrier-ranger-green-default"",
  ""name"": ""657660eb86f11bca4106d34f Name"",
  ""shortName"": ""657660eb86f11bca4106d34f ShortName"",
  ""weight"": 5.53,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Eagle_Industries_MMAC_plate_carrier_(Ranger_Green)"",
  ""conflictingItems"": [],
  ""categories"": [
    ""5448e5284bdc2dcb718b4567"",
    ""566168634bdc2d144c8b456c"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesPreset"",
    ""moa"": null,
    ""baseItem"": ""61bc85697113f767765c7fe7""
  },
  ""containsItems"": [
    {
      ""item"": ""61bc85697113f767765c7fe7"",
      ""count"": 1
    },
    {
      ""item"": ""656fad8c498d1b7e3e071da0"",
      ""count"": 2
    }
  ]
},
""584147732459775a2b6d9f12"": {
  ""categories"": [
    ""5447b5f14bdc2d61278b4567"",
    ""5422acb9af1c889c16000029"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/584147732459775a2b6d9f12-icon.webp"",
  ""id"": ""584147732459775a2b6d9f12"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/584147732459775a2b6d9f12-image.webp"",
  ""link"": ""https://tarkov.dev/item/kalashnikov-aks-74u-545x39-assault-rifle-default"",
  ""name"": ""584147732459775a2b6d9f12 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesPreset"",
    ""baseItem"": ""57dc2fa62459775949412633"",
    ""moa"": 3.44
  },
  ""shortName"": ""584147732459775a2b6d9f12 ShortName"",
  ""weight"": 2.694,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Kalashnikov_AKS-74U_5.45x39_assault_rifle"",
  ""containsItems"": [
    {
      ""item"": ""57dc2fa62459775949412633"",
      ""count"": 1
    },
    {
      ""item"": ""57e3dba62459770f0c32322b"",
      ""count"": 1
    },
    {
      ""item"": ""57dc347d245977596754e7a1"",
      ""count"": 1
    },
    {
      ""item"": ""564ca99c4bdc2d16268b4589"",
      ""count"": 1
    },
    {
      ""item"": ""56dff4ecd2720b5f5a8b4568"",
      ""count"": 30
    },
    {
      ""item"": ""57dc324a24597759501edc20"",
      ""count"": 1
    },
    {
      ""item"": ""57dc334d245977597164366f"",
      ""count"": 1
    },
    {
      ""item"": ""59d36a0086f7747e673f3946"",
      ""count"": 1
    },
    {
      ""item"": ""57dc32dc245977596d4ef3d3"",
      ""count"": 1
    }
  ]
},
""5a8ae43686f774377b73cfb3"": {
  ""categories"": [
    ""5447b5e04bdc2d62278b4567"",
    ""5422acb9af1c889c16000029"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5a8ae43686f774377b73cfb3-icon.webp"",
  ""id"": ""5a8ae43686f774377b73cfb3"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a8ae43686f774377b73cfb3-image.webp"",
  ""link"": ""https://tarkov.dev/item/sig-mpx-9x19-submachine-gun-mqb"",
  ""name"": ""5a8ae43686f774377b73cfb3 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesPreset"",
    ""baseItem"": ""58948c8e86f77409493f7266"",
    ""moa"": 6.19
  },
  ""shortName"": ""5a8ae43686f774377b73cfb3 ShortName"",
  ""weight"": 3.87,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/SIG_MPX_9x19_submachine_gun"",
  ""containsItems"": [
    {
      ""item"": ""58948c8e86f77409493f7266"",
      ""count"": 1
    },
    {
      ""item"": ""57c55efc2459772d2c6271e7"",
      ""count"": 1
    },
    {
      ""item"": ""5894a05586f774094708ef75"",
      ""count"": 1
    },
    {
      ""item"": ""5efb0da7a29a85116f6ea05f"",
      ""count"": 20
    },
    {
      ""item"": ""5c3df7d588a4501f290594e5"",
      ""count"": 10
    },
    {
      ""item"": ""5894a5b586f77426d2590767"",
      ""count"": 1
    },
    {
      ""item"": ""57adff4f24597737f373b6e6"",
      ""count"": 1
    },
    {
      ""item"": ""58d2664f86f7747fec5834f6"",
      ""count"": 1
    },
    {
      ""item"": ""58d268fc86f774111273f8c2"",
      ""count"": 1
    },
    {
      ""item"": ""58aeaaa886f7744fc1560f81"",
      ""count"": 1
    },
    {
      ""item"": ""58aeac1b86f77457c419f475"",
      ""count"": 1
    },
    {
      ""item"": ""5894a42086f77426d2590762"",
      ""count"": 1
    },
    {
      ""item"": ""58a56f8d86f774651579314c"",
      ""count"": 2
    },
    {
      ""item"": ""5a7b483fe899ef0016170d15"",
      ""count"": 1
    },
    {
      ""item"": ""58a5c12e86f7745d585a2b9e"",
      ""count"": 1
    },
    {
      ""item"": ""59f8a37386f7747af3328f06"",
      ""count"": 1
    },
    {
      ""item"": ""58ac1bf086f77420ed183f9f"",
      ""count"": 1
    },
    {
      ""item"": ""591aef7986f774139d495f03"",
      ""count"": 1
    },
    {
      ""item"": ""58949edd86f77409483e16a9"",
      ""count"": 1
    }
  ]
},
""5a3b898486f77467720a2f29"": {
  ""categories"": [
    ""5a341c4086f77401f2541505"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5a3b898486f77467720a2f29-icon.webp"",
  ""id"": ""5a3b898486f77467720a2f29"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a3b898486f77467720a2f29-image.webp"",
  ""link"": ""https://tarkov.dev/item/wilcox-skull-lock-head-mount-pvs-14"",
  ""name"": ""5a3b898486f77467720a2f29 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesPreset"",
    ""baseItem"": ""5a16bb52fcdbcb001a3b00dc"",
    ""moa"": null
  },
  ""shortName"": ""5a3b898486f77467720a2f29 ShortName"",
  ""weight"": 1.29,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Wilcox_Skull_Lock_head_mount"",
  ""containsItems"": [
    {
      ""item"": ""5a16bb52fcdbcb001a3b00dc"",
      ""count"": 1
    },
    {
      ""item"": ""5a16b8a9fcdbcb00165aa6ca"",
      ""count"": 1
    },
    {
      ""item"": ""5a16b93dfcdbcbcae6687261"",
      ""count"": 1
    },
    {
      ""item"": ""57235b6f24597759bf5a30f1"",
      ""count"": 1
    }
  ]
},
""58d268fc86f774111273f8c2"": {
  ""categories"": [
    ""55818acf4bdc2dde698b456b"",
    ""5448fe7a4bdc2d6f028b456b"",
    ""550aa4154bdc2dd8348b456b"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58d268fc86f774111273f8c2-icon.webp"",
  ""id"": ""58d268fc86f774111273f8c2"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58d268fc86f774111273f8c2-image.webp"",
  ""link"": ""https://tarkov.dev/item/leupold-deltapoint-reflex-sight"",
  ""name"": ""58d268fc86f774111273f8c2 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesScope"",
    ""ergonomics"": 0,
    ""recoilModifier"": 0,
    ""slots"": [],
    ""zoomLevels"": [
      [
        1
      ]
    ]
  },
  ""shortName"": ""58d268fc86f774111273f8c2 ShortName"",
  ""weight"": 0.053,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Leupold_DeltaPoint_Reflex_Sight""
},
""57adff4f24597737f373b6e6"": {
  ""categories"": [
    ""55818add4bdc2d5b648b456f"",
    ""5448fe7a4bdc2d6f028b456b"",
    ""550aa4154bdc2dd8348b456b"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57adff4f24597737f373b6e6-icon.webp"",
  ""id"": ""57adff4f24597737f373b6e6"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57adff4f24597737f373b6e6-image.webp"",
  ""link"": ""https://tarkov.dev/item/sig-sauer-bravo4-4x30-scope"",
  ""name"": ""57adff4f24597737f373b6e6 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesScope"",
    ""ergonomics"": -2,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""57ae0171245977343c27bfcf"",
            ""58d39d3d86f77445bb794ae7"",
            ""577d128124597739d65d0e56"",
            ""58d2664f86f7747fec5834f6"",
            ""5a33b2c9c4a282000c5a9511""
          ]
        },
        ""nameId"": ""mod_scope"",
        ""name"": ""MOD_SCOPE""
      }
    ],
    ""zoomLevels"": [
      [
        4
      ]
    ]
  },
  ""shortName"": ""57adff4f24597737f373b6e6 ShortName"",
  ""weight"": 0.419,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/SIG_Sauer_BRAVO4_4x30_scope""
},
""61714eec290d254f5e6b2ffc"": {
  ""categories"": [
    ""55818ae44bdc2dde698b456c"",
    ""5448fe7a4bdc2d6f028b456b"",
    ""550aa4154bdc2dd8348b456b"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [
    ""591c4efa86f7741030027726"",
    ""570fd79bd2720bc7458b4583"",
    ""64785e7c19d732620e045e15"",
    ""570fd6c2d2720bc6458b457f"",
    ""558022b54bdc2dac148b458d"",
    ""58491f3324597764bc48fa02"",
    ""584924ec24597768f12ae244"",
    ""5b30b0dc5acfc400153b7124"",
    ""6165ac8c290d254f5e6b2f6c"",
    ""60a23797a37c940de7062d02"",
    ""6477772ea8a38bb2050ed4db"",
    ""5d2da1e948f035477b1ce2ba"",
    ""5c0505e00db834001b735073"",
    ""609a63b6e2ff132951242d09"",
    ""570fd721d2720bc5458b4596"",
    ""59f9d81586f7744c7506ee62"",
    ""584984812459776a704a82a6""
  ],
  ""iconLink"": ""https://assets.tarkov.dev/61714eec290d254f5e6b2ffc-icon.webp"",
  ""id"": ""61714eec290d254f5e6b2ffc"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/61714eec290d254f5e6b2ffc-image.webp"",
  ""link"": ""https://tarkov.dev/item/schmidt-bender-pm-ii-3-12x50-34mm-riflescope"",
  ""name"": ""61714eec290d254f5e6b2ffc Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesScope"",
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
  ""shortName"": ""61714eec290d254f5e6b2ffc ShortName"",
  ""weight"": 0.9,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Schmidt_%26_Bender_PM_II_3-12x50_34mm_riflescope""
},
""5e81c3cbac2bb513793cdc75"": {
  ""categories"": [
    ""5447b5cf4bdc2d65278b4567"",
    ""5422acb9af1c889c16000029"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5e81c3cbac2bb513793cdc75-icon.webp"",
  ""id"": ""5e81c3cbac2bb513793cdc75"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5e81c3cbac2bb513793cdc75-image.webp"",
  ""link"": ""https://tarkov.dev/item/colt-m1911a1-45-acp-pistol"",
  ""name"": ""5e81c3cbac2bb513793cdc75 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeapon"",
    ""caliber"": ""Caliber1143x23ACP"",
    ""defaultPreset"": ""5eb2968186f7746d1f1a4fd5"",
    ""ergonomics"": 75,
    ""fireModes"": [
      ""singlefire""
    ],
    ""fireRate"": 30,
    ""recoilHorizontal"": 355,
    ""recoilVertical"": 451,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""5e81c519cb2b95385c177551"",
            ""5f3e7801153b8571434a924c"",
            ""5f3e77f59103d430b93f94c1""
          ]
        },
        ""nameId"": ""mod_barrel"",
        ""name"": ""MOD_BARREL""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""5e81c6bf763d9f754677beff"",
            ""5ef366938cef260c0642acad"",
            ""626a9cb151cb5849f6002890""
          ]
        },
        ""nameId"": ""mod_pistol_grip"",
        ""name"": ""MOD_PISTOL_GRIP""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""5e81edc13397a21db957f6a1"",
            ""5f3e7823ddc4f03b010e2045""
          ]
        },
        ""nameId"": ""mod_reciever"",
        ""name"": ""MOD_RECIEVER""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""5e81c4ca763d9f754677befa"",
            ""5f3e77b26cda304dcc634057"",
            ""5ef3448ab37dfd6af863525c""
          ]
        },
        ""nameId"": ""mod_magazine"",
        ""name"": ""MOD_MAGAZINE""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""5ef32e4d1c1fd62aea6a150d"",
            ""5e81c6a2ac2bb513793cdc7f"",
            ""5f3e772a670e2a7b01739a52""
          ]
        },
        ""nameId"": ""mod_trigger"",
        ""name"": ""MOD_TRIGGER""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""5e81c550763d9f754677befd"",
            ""5f3e76d86cda304dcc634054"",
            ""5ef35f46382a846010715a96"",
            ""5ef35d2ac64c5d0dfc0571b0"",
            ""5ef35bc243cb350a955a7ccd""
          ]
        },
        ""nameId"": ""mod_hammer"",
        ""name"": ""MOD_HAMMER""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""5e81c539cb2b95385c177553"",
            ""5f3e777688ca2d00ad199d25"",
            ""5ef3553c43cb350a955a7ccb""
          ]
        },
        ""nameId"": ""mod_catch"",
        ""name"": ""MOD_CATCH""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""5ef5d994dfbc9f3c660ded95""
          ]
        },
        ""nameId"": ""mod_mount_000"",
        ""name"": ""MOD_MOUNT_000""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""5ef369b08cef260c0642acaf""
          ]
        },
        ""nameId"": ""mod_mount_001"",
        ""name"": ""MOD_MOUNT_001""
      }
    ]
  },
  ""shortName"": ""5e81c3cbac2bb513793cdc75 ShortName"",
  ""weight"": 0.231,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Colt_M1911A1_.45_ACP_pistol""
},
""57dc2fa62459775949412633"": {
  ""categories"": [
    ""5447b5f14bdc2d61278b4567"",
    ""5422acb9af1c889c16000029"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57dc2fa62459775949412633-icon.webp"",
  ""id"": ""57dc2fa62459775949412633"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57dc2fa62459775949412633-image.webp"",
  ""link"": ""https://tarkov.dev/item/kalashnikov-aks-74u-545x39-assault-rifle"",
  ""name"": ""57dc2fa62459775949412633 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeapon"",
    ""caliber"": ""Caliber545x39"",
    ""defaultPreset"": ""584147732459775a2b6d9f12"",
    ""ergonomics"": 44,
    ""fireModes"": [
      ""fullauto"",
      ""singlefire""
    ],
    ""fireRate"": 650,
    ""recoilHorizontal"": 373,
    ""recoilVertical"": 102,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
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
            ""5998517986f7746017232f7e"",
            ""623c3be0484b5003161840dc"",
            ""628c9ab845c59e5b80768a81"",
            ""628a664bccaab13006640e47"",
            ""63f4da90f31d4a33b87bd054"",
            ""648ae3e356c6310a830fc291"",
            ""651580dc71a4f10aec4b6056""
          ]
        },
        ""nameId"": ""mod_pistol_grip"",
        ""name"": ""MOD_PISTOL_GRIP""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""59ecc28286f7746d7a68aa8c"",
            ""5ab626e4d8ce87272e4c6e43"",
            ""57dc347d245977596754e7a1""
          ]
        },
        ""nameId"": ""mod_stock"",
        ""name"": ""MOD_STOCK""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""6130ca3fd92c473c77020dbd"",
            ""5648ac824bdc2ded0b8b457d""
          ]
        },
        ""nameId"": ""mod_charge"",
        ""name"": ""MOD_CHARGE""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""564ca9df4bdc2d35148b4569"",
            ""564ca99c4bdc2d16268b4589"",
            ""55d480c04bdc2d1d4e8b456a"",
            ""5cbdaf89ae9215000e5b9c94"",
            ""55d481904bdc2d8c2f8b456a"",
            ""55d482194bdc2d1d4e8b456b"",
            ""55d4837c4bdc2d1d4e8b456c"",
            ""5aaa4194e5b5b055d06310a5"",
            ""5bed61680db834001d2c45ab"",
            ""5bed625c0db834001c062946"",
            ""649ec30cb013f04a700e60fb"",
            ""64b9e265c94d0d15c5027e35""
          ]
        },
        ""nameId"": ""mod_magazine"",
        ""name"": ""MOD_MAGAZINE""
      },
      {
        ""filters"": {
          ""allowedItems"": [
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
          ]
        },
        ""nameId"": ""mod_muzzle"",
        ""name"": ""MOD_MUZZLE""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""57dc334d245977597164366f"",
            ""5839a7742459773cf9693481"",
            ""655cb6b5d680a544f30607fa""
          ]
        },
        ""nameId"": ""mod_reciever"",
        ""name"": ""MOD_RECIEVER""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""59d36a0086f7747e673f3946""
          ]
        },
        ""nameId"": ""mod_gas_block"",
        ""name"": ""MOD_GAS_BLOCK""
      }
    ]
  },
  ""shortName"": ""57dc2fa62459775949412633 ShortName"",
  ""weight"": 1.809,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Kalashnikov_AKS-74U_5.45x39_assault_rifle""
},
""624c0b3340357b5f566e8766"": {
  ""categories"": [
    ""5447bedf4bdc2d87278b4568"",
    ""5422acb9af1c889c16000029"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/624c0b3340357b5f566e8766-icon.webp"",
  ""id"": ""624c0b3340357b5f566e8766"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/624c0b3340357b5f566e8766-image.webp"",
  ""link"": ""https://tarkov.dev/item/rsp-30-reactive-signal-cartridge-yellow"",
  ""name"": ""624c0b3340357b5f566e8766 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeapon"",
    ""caliber"": ""Caliber26x75"",
    ""defaultPreset"": null,
    ""ergonomics"": 51,
    ""fireModes"": [
      ""singlefire""
    ],
    ""fireRate"": 30,
    ""recoilHorizontal"": 400,
    ""recoilVertical"": 170,
    ""slots"": []
  },
  ""shortName"": ""624c0b3340357b5f566e8766 ShortName"",
  ""weight"": 0.19,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/RSP-30_reactive_signal_cartridge_(Yellow)""
},
""58948c8e86f77409493f7266"": {
  ""categories"": [
    ""5447b5e04bdc2d62278b4567"",
    ""5422acb9af1c889c16000029"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58948c8e86f77409493f7266-icon.webp"",
  ""id"": ""58948c8e86f77409493f7266"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58948c8e86f77409493f7266-image.webp"",
  ""link"": ""https://tarkov.dev/item/sig-mpx-9x19-submachine-gun"",
  ""name"": ""58948c8e86f77409493f7266 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeapon"",
    ""caliber"": ""Caliber9x19PARA"",
    ""defaultPreset"": ""58dffca786f774083a256ab1"",
    ""ergonomics"": 40,
    ""fireModes"": [
      ""fullauto"",
      ""singlefire""
    ],
    ""fireRate"": 850,
    ""recoilHorizontal"": 269,
    ""recoilVertical"": 51,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""55d4b9964bdc2d1d4e8b456e"",
            ""571659bb2459771fb2755a12"",
            ""602e71bd53a60014f9705bfa"",
            ""6113c3586c780c1e710c90bc"",
            ""6113cc78d3a39d50044c065a"",
            ""6113cce3d92c473c770200c7"",
            ""5cc9bcaed7f00c011c04e179"",
            ""5bb20e18d4351e00320205d5"",
            ""5bb20e0ed4351e3bac1212dc"",
            ""6193dcd0f8ee7e52e4210a28"",
            ""5d025cc1d7ad1a53845279ef"",
            ""5c6d7b3d2e221600114c9b7d"",
            ""57c55efc2459772d2c6271e7"",
            ""57af48872459771f0b2ebf11"",
            ""57c55f092459772d291a8463"",
            ""57c55f112459772d28133310"",
            ""57c55f172459772d27602381"",
            ""5a339805c4a2826c6e06d73d"",
            ""55802f5d4bdc2dac148b458f"",
            ""5d15cf3bd7ad1a67e71518b2"",
            ""59db3a1d86f77429e05b4e92"",
            ""5fbcbd6c187fea44d52eda14"",
            ""59db3acc86f7742a2c4ab912"",
            ""59db3b0886f77429d72fb895"",
            ""615d8faecabb9b7ad90f4d5d"",
            ""5b07db875acfc40dc528a5f6"",
            ""5894a51286f77426d13baf02"",
            ""63f5feead259b42f0b4d6d0f"",
            ""652911675ae2ae97b80fdf3c""
          ]
        },
        ""nameId"": ""mod_pistol_grip"",
        ""name"": ""MOD_PISTOL_GRIP""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""5c5db6742e2216000f1b2852"",
            ""5c5db6552e2216001026119d"",
            ""5894a05586f774094708ef75"",
            ""5c5db6652e221600113fba51""
          ]
        },
        ""nameId"": ""mod_magazine"",
        ""name"": ""MOD_MAGAZINE""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""5894a5b586f77426d2590767""
          ]
        },
        ""nameId"": ""mod_reciever"",
        ""name"": ""MOD_RECIEVER""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""58ac1bf086f77420ed183f9f"",
            ""5894a13e86f7742405482982"",
            ""5fbcc429900b1d5091531dd7"",
            ""5fbcc437d724d907e2077d5c"",
            ""5c5db6ee2e221600113fba54"",
            ""5c5db6f82e2216003a0fe914"",
            ""6529348224cbe3c74a05e5c4""
          ]
        },
        ""nameId"": ""mod_stock"",
        ""name"": ""MOD_STOCK""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""5c5db6b32e221600102611a0"",
            ""58949edd86f77409483e16a9"",
            ""58949fac86f77409483e16aa""
          ]
        },
        ""nameId"": ""mod_charge"",
        ""name"": ""MOD_CHARGE""
      }
    ]
  },
  ""shortName"": ""58948c8e86f77409493f7266 ShortName"",
  ""weight"": 0.64,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/SIG_MPX_9x19_submachine_gun""
},
""620109578d82e67e7911abf2"": {
  ""categories"": [
    ""5447bedf4bdc2d87278b4568"",
    ""5422acb9af1c889c16000029"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/620109578d82e67e7911abf2-icon.webp"",
  ""id"": ""620109578d82e67e7911abf2"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/620109578d82e67e7911abf2-image.webp"",
  ""link"": ""https://tarkov.dev/item/zid-sp-81-26x75-signal-pistol"",
  ""name"": ""620109578d82e67e7911abf2 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeapon"",
    ""caliber"": ""Caliber26x75"",
    ""defaultPreset"": null,
    ""ergonomics"": 51,
    ""fireModes"": [
      ""singlefire""
    ],
    ""fireRate"": 30,
    ""recoilHorizontal"": 400,
    ""recoilVertical"": 170,
    ""slots"": []
  },
  ""shortName"": ""620109578d82e67e7911abf2 ShortName"",
  ""weight"": 0.6,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/ZiD_SP-81_26x75_signal_pistol""
},
""5d2c76ed48f03532f2136169"": {
  ""categories"": [
    ""55818a304bdc2db5418b457d"",
    ""55802f4a4bdc2ddb688b4569"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [
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
    ""5c90c3622e221601da359851"",
    ""628a7b23b0f75035732dd565"",
    ""5bf3f59f0db834001a6fa060"",
    ""649ec2cec93611967b03495e""
  ],
  ""iconLink"": ""https://assets.tarkov.dev/5d2c76ed48f03532f2136169-icon.webp"",
  ""id"": ""5d2c76ed48f03532f2136169"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5d2c76ed48f03532f2136169-image.webp"",
  ""link"": ""https://tarkov.dev/item/ak-akademia-bastion-dust-cover"",
  ""name"": ""5d2c76ed48f03532f2136169 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 5,
    ""recoilModifier"": -0.01,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""57ac965c24597706be5f975c"",
            ""57aca93d2459771f2c7e26db"",
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
            ""5dff77c759400025ea5150cf"",
            ""626bb8532c923541184624b4"",
            ""62811f461d5df4475f46a332"",
            ""63fc449f5bd61c6cf3784a88"",
            ""6477772ea8a38bb2050ed4db"",
            ""6478641c19d732620e045e17"",
            ""64785e7c19d732620e045e15"",
            ""65392f611406374f82152ba5"",
            ""653931da5db71d30ab1d6296"",
            ""655f13e0a246670fb0373245"",
            ""6567e751a715f85433025998""
          ]
        },
        ""nameId"": ""mod_scope"",
        ""name"": ""MOD_SCOPE""
      }
    ]
  },
  ""shortName"": ""5d2c76ed48f03532f2136169 ShortName"",
  ""weight"": 0.237,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AK_AKademia_Bastion_dust_cover""
},
""57e3dba62459770f0c32322b"": {
  ""categories"": [
    ""55818a684bdc2ddd698b456d"",
    ""55802f4a4bdc2ddb688b4569"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57e3dba62459770f0c32322b-icon.webp"",
  ""id"": ""57e3dba62459770f0c32322b"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57e3dba62459770f0c32322b-image.webp"",
  ""link"": ""https://tarkov.dev/item/ak-bakelite-pistol-grip-6p4-sb9"",
  ""name"": ""57e3dba62459770f0c32322b Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 6,
    ""recoilModifier"": 0,
    ""slots"": []
  },
  ""shortName"": ""57e3dba62459770f0c32322b ShortName"",
  ""weight"": 0.07,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AK_bakelite_pistol_grip_(6P4_Sb.9)""
},
""57dc324a24597759501edc20"": {
  ""categories"": [
    ""550aa4bf4bdc2dd6348b456b"",
    ""5448fe394bdc2d0d028b456c"",
    ""550aa4154bdc2dd8348b456b"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57dc324a24597759501edc20-icon.webp"",
  ""id"": ""57dc324a24597759501edc20"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57dc324a24597759501edc20-image.webp"",
  ""link"": ""https://tarkov.dev/item/aks-74u-545x39-muzzle-brake-6p26-0-20"",
  ""name"": ""57dc324a24597759501edc20 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": -2,
    ""recoilModifier"": -0.06,
    ""slots"": []
  },
  ""shortName"": ""57dc324a24597759501edc20 ShortName"",
  ""weight"": 0.1,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AKS-74U_5.45x39_muzzle_brake_(6P26_0-20)""
},
""57dc334d245977597164366f"": {
  ""categories"": [
    ""55818a304bdc2db5418b457d"",
    ""55802f4a4bdc2ddb688b4569"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [
    ""57486e672459770abd687134"",
    ""5c82342f2e221644f31c060e"",
    ""576fd4ec2459777f0b518431"",
    ""5c82343a2e221644f31c0611"",
    ""5c61a40d2e2216001403158d"",
    ""5c90c3622e221601da359851""
  ],
  ""iconLink"": ""https://assets.tarkov.dev/57dc334d245977597164366f-icon.webp"",
  ""id"": ""57dc334d245977597164366f"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57dc334d245977597164366f-image.webp"",
  ""link"": ""https://tarkov.dev/item/aks-74u-dust-cover-6p26-sb7"",
  ""name"": ""57dc334d245977597164366f Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 5,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""57ffb0062459777a045af529""
          ]
        },
        ""nameId"": ""mod_mount_000"",
        ""name"": ""MOD_MOUNT_000""
      }
    ]
  },
  ""shortName"": ""57dc334d245977597164366f ShortName"",
  ""weight"": 0.136,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AKS-74U_dust_cover_(6P26_Sb.7)""
},
""59d36a0086f7747e673f3946"": {
  ""categories"": [
    ""56ea9461d2720b67698b456f"",
    ""550aa4154bdc2dd8348b456b"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/59d36a0086f7747e673f3946-icon.webp"",
  ""id"": ""59d36a0086f7747e673f3946"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/59d36a0086f7747e673f3946-image.webp"",
  ""link"": ""https://tarkov.dev/item/aks-74u-gas-tube-6p26-sb1-2"",
  ""name"": ""59d36a0086f7747e673f3946 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 0,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""5d15ce51d7ad1a1eff619092"",
            ""5a957c3fa2750c00137fa5f7"",
            ""57dc32dc245977596d4ef3d3"",
            ""57ffa9f4245977728561e844"",
            ""647db1eca8d3399c380d195c""
          ]
        },
        ""nameId"": ""mod_handguard"",
        ""name"": ""MOD_HANDGUARD""
      }
    ]
  },
  ""shortName"": ""59d36a0086f7747e673f3946 ShortName"",
  ""weight"": 0.03,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AKS-74U_gas_tube_(6P26_Sb.1-2)""
},
""57dc347d245977596754e7a1"": {
  ""categories"": [
    ""55818a594bdc2db9688b456a"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57dc347d245977596754e7a1-icon.webp"",
  ""id"": ""57dc347d245977596754e7a1"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57dc347d245977596754e7a1-image.webp"",
  ""link"": ""https://tarkov.dev/item/aks-74u-metal-skeleton-stock-6p26-sb5"",
  ""name"": ""57dc347d245977596754e7a1 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 10,
    ""recoilModifier"": -0.21,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""5a0c59791526d8dba737bba7"",
            ""6494094948796d891603e59f""
          ]
        },
        ""nameId"": ""mod_stock_000"",
        ""name"": ""MOD_STOCK_000""
      }
    ]
  },
  ""shortName"": ""57dc347d245977596754e7a1 ShortName"",
  ""weight"": 0.218,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AKS-74U_metal_skeleton_stock_(6P26_Sb.5)""
},
""57dc32dc245977596d4ef3d3"": {
  ""categories"": [
    ""55818a104bdc2db9688b4569"",
    ""55802f4a4bdc2ddb688b4569"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57dc32dc245977596d4ef3d3-icon.webp"",
  ""id"": ""57dc32dc245977596d4ef3d3"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57dc32dc245977596d4ef3d3-image.webp"",
  ""link"": ""https://tarkov.dev/item/aks-74u-wooden-handguard-6p26-sb6"",
  ""name"": ""57dc32dc245977596d4ef3d3 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 4,
    ""recoilModifier"": 0,
    ""slots"": []
  },
  ""shortName"": ""57dc32dc245977596d4ef3d3 ShortName"",
  ""weight"": 0.116,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AKS-74U_wooden_handguard_(6P26_Sb.6)""
},
""5a16b93dfcdbcbcae6687261"": {
  ""categories"": [
    ""55818b224bdc2dde698b456f"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5a16b93dfcdbcbcae6687261-icon.webp"",
  ""id"": ""5a16b93dfcdbcbcae6687261"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a16b93dfcdbcbcae6687261-image.webp"",
  ""link"": ""https://tarkov.dev/item/anpvs-14-dual-dovetail-mount"",
  ""name"": ""5a16b93dfcdbcbcae6687261 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 0,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""57235b6f24597759bf5a30f1""
          ]
        },
        ""nameId"": ""mod_nvg"",
        ""name"": ""MOD_NVG""
      }
    ]
  },
  ""shortName"": ""5a16b93dfcdbcbcae6687261 ShortName"",
  ""weight"": 0.07,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AN/PVS-14_Dual_Dovetail_Mount""
},
""591aef7986f774139d495f03"": {
  ""categories"": [
    ""55818a594bdc2db9688b456a"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/591aef7986f774139d495f03-icon.webp"",
  ""id"": ""591aef7986f774139d495f03"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/591aef7986f774139d495f03-image.webp"",
  ""link"": ""https://tarkov.dev/item/ar-15-troy-m7a1-pdw-stock-black"",
  ""name"": ""591aef7986f774139d495f03 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 18,
    ""recoilModifier"": -0.18,
    ""slots"": []
  },
  ""shortName"": ""591aef7986f774139d495f03 ShortName"",
  ""weight"": 0.4,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/AR-15_TROY_M7A1_PDW_stock""
},
""59d790f486f77403cb06aec6"": {
  ""categories"": [
    ""55818b084bdc2d5b648b4571"",
    ""550aa4154bdc2dd8348b456b"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/59d790f486f77403cb06aec6-icon.webp"",
  ""id"": ""59d790f486f77403cb06aec6"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/59d790f486f77403cb06aec6-image.webp"",
  ""link"": ""https://tarkov.dev/item/armytek-predator-pro-v3-xhp35-hi-flashlight"",
  ""name"": ""59d790f486f77403cb06aec6 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": -2,
    ""recoilModifier"": 0,
    ""slots"": []
  },
  ""shortName"": ""59d790f486f77403cb06aec6 ShortName"",
  ""weight"": 0.12,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Armytek_Predator_Pro_v3_XHP35_HI_flashlight""
},
""58d2664f86f7747fec5834f6"": {
  ""categories"": [
    ""55818b224bdc2dde698b456f"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58d2664f86f7747fec5834f6-icon.webp"",
  ""id"": ""58d2664f86f7747fec5834f6"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58d2664f86f7747fec5834f6-image.webp"",
  ""link"": ""https://tarkov.dev/item/deltapoint-cross-slot-mount-base"",
  ""name"": ""58d2664f86f7747fec5834f6 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 0,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""58d268fc86f774111273f8c2""
          ]
        },
        ""nameId"": ""mod_scope"",
        ""name"": ""MOD_SCOPE""
      }
    ]
  },
  ""shortName"": ""58d2664f86f7747fec5834f6 ShortName"",
  ""weight"": 0.045,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/DeltaPoint_Cross_Slot_Mount_base""
},
""59f8a37386f7747af3328f06"": {
  ""categories"": [
    ""55818af64bdc2d5b648b4570"",
    ""550aa4154bdc2dd8348b456b"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/59f8a37386f7747af3328f06-icon.webp"",
  ""id"": ""59f8a37386f7747af3328f06"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/59f8a37386f7747af3328f06-image.webp"",
  ""link"": ""https://tarkov.dev/item/fortis-shift-tactical-foregrip"",
  ""name"": ""59f8a37386f7747af3328f06 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 8,
    ""recoilModifier"": -0.015,
    ""slots"": []
  },
  ""shortName"": ""59f8a37386f7747af3328f06 ShortName"",
  ""weight"": 0.09,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Fortis_Shift_tactical_foregrip""
},
""57c55efc2459772d2c6271e7"": {
  ""categories"": [
    ""55818a684bdc2ddd698b456d"",
    ""55802f4a4bdc2ddb688b4569"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57c55efc2459772d2c6271e7-icon.webp"",
  ""id"": ""57c55efc2459772d2c6271e7"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57c55efc2459772d2c6271e7-image.webp"",
  ""link"": ""https://tarkov.dev/item/hogue-overmolded-rubber-grip-black"",
  ""name"": ""57c55efc2459772d2c6271e7 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 9,
    ""recoilModifier"": 0,
    ""slots"": []
  },
  ""shortName"": ""57c55efc2459772d2c6271e7 ShortName"",
  ""weight"": 0.08,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Hogue_OverMolded_Rubber_Grip""
},
""57d17e212459775a1179a0f5"": {
  ""categories"": [
    ""55818b224bdc2dde698b456f"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/57d17e212459775a1179a0f5-icon.webp"",
  ""id"": ""57d17e212459775a1179a0f5"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/57d17e212459775a1179a0f5-image.webp"",
  ""link"": ""https://tarkov.dev/item/kiba-arms-25mm-accessory-ring-mount"",
  ""name"": ""57d17e212459775a1179a0f5 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": -1,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""59d790f486f77403cb06aec6"",
            ""57d17c5e2459775a5c57d17d""
          ]
        },
        ""nameId"": ""mod_flashlight"",
        ""name"": ""MOD_FLASHLIGHT""
      }
    ]
  },
  ""shortName"": ""57d17e212459775a1179a0f5 ShortName"",
  ""weight"": 0.085,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Kiba_Arms_25mm_accessory_ring_mount""
},
""5894a5b586f77426d2590767"": {
  ""categories"": [
    ""55818a304bdc2db5418b457d"",
    ""55802f4a4bdc2ddb688b4569"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5894a5b586f77426d2590767-icon.webp"",
  ""id"": ""5894a5b586f77426d2590767"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5894a5b586f77426d2590767-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-gen1-9x19-upper-receiver"",
  ""name"": ""5894a5b586f77426d2590767 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 5,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""57ac965c24597706be5f975c"",
            ""57aca93d2459771f2c7e26db"",
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
            ""5dff77c759400025ea5150cf"",
            ""626bb8532c923541184624b4"",
            ""62811f461d5df4475f46a332"",
            ""63fc449f5bd61c6cf3784a88"",
            ""6477772ea8a38bb2050ed4db"",
            ""6478641c19d732620e045e17"",
            ""64785e7c19d732620e045e15"",
            ""65392f611406374f82152ba5"",
            ""653931da5db71d30ab1d6296"",
            ""655f13e0a246670fb0373245"",
            ""6567e751a715f85433025998""
          ]
        },
        ""nameId"": ""mod_scope"",
        ""name"": ""MOD_SCOPE""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""5c5db5852e2216003a0fe71a"",
            ""5c5db5962e2216000e5e46eb"",
            ""58aeaaa886f7744fc1560f81"",
            ""5894a2c386f77427140b8342"",
            ""5c5db5b82e2216003a0fe71d"",
            ""5c5db5c62e22160012542255""
          ]
        },
        ""nameId"": ""mod_barrel"",
        ""name"": ""MOD_BARREL""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""5c59529a2e221602b177d160"",
            ""5c5db6302e2216000e5e47f0"",
            ""5c5db63a2e2216000f1b284a"",
            ""5c5db5f22e2216000e5e47e8"",
            ""5c5db5fc2e2216000f1b2842"",
            ""5894a42086f77426d2590762""
          ]
        },
        ""nameId"": ""mod_handguard"",
        ""name"": ""MOD_HANDGUARD""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""5ba26b17d4351e00367f9bdd"",
            ""5dfa3d7ac41b2312ea33362a"",
            ""5c1780312e221602b66cc189"",
            ""5fb6564947ce63734e3fa1da"",
            ""5bc09a18d4351e003562b68e"",
            ""5c18b9192e2216398b5a8104"",
            ""5fc0fa957283c4046c58147e"",
            ""5894a81786f77427140b8347""
          ]
        },
        ""nameId"": ""mod_sight_rear"",
        ""name"": ""MOD_SIGHT_REAR""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""57fd23e32459772d0805bcf1"",
            ""544909bb4bdc2d6f028b4577"",
            ""5c06595c0db834001a66af6c"",
            ""5a7b483fe899ef0016170d15"",
            ""61605d88ffa6e502ac5e7eeb"",
            ""5c5952732e2216398b5abda2"",
            ""644a3df63b0b6f03e101e065""
          ]
        },
        ""nameId"": ""mod_tactical_000"",
        ""name"": ""MOD_TACTICAL_000""
      }
    ]
  },
  ""shortName"": ""5894a5b586f77426d2590767 ShortName"",
  ""weight"": 0.488,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX_GEN1_9x19_upper_receiver""
},
""5894a42086f77426d2590762"": {
  ""categories"": [
    ""55818a104bdc2db9688b4569"",
    ""55802f4a4bdc2ddb688b4569"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5894a42086f77426d2590762-icon.webp"",
  ""id"": ""5894a42086f77426d2590762"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5894a42086f77426d2590762-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-gen1-handguard"",
  ""name"": ""5894a42086f77426d2590762 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 7,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""5ba26b01d4351e0085325a51"",
            ""5dfa3d950dee1b22f862eae0"",
            ""5c17804b2e2216152006c02f"",
            ""5fb6567747ce63734e3fa1dc"",
            ""5bc09a30d4351e00367fb7c8"",
            ""5c18b90d2e2216152142466b"",
            ""5fc0fa362770a0045c59c677"",
            ""5894a73486f77426d259076c""
          ]
        },
        ""nameId"": ""mod_sight_front"",
        ""name"": ""MOD_SIGHT_FRONT""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""58a56f8d86f774651579314c""
          ]
        },
        ""nameId"": ""mod_mount_000"",
        ""name"": ""MOD_MOUNT_000""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""58a5c12e86f7745d585a2b9e""
          ]
        },
        ""nameId"": ""mod_mount_001"",
        ""name"": ""MOD_MOUNT_001""
      },
      {
        ""filters"": {
          ""allowedItems"": [
            ""58a56f8d86f774651579314c""
          ]
        },
        ""nameId"": ""mod_mount_002"",
        ""name"": ""MOD_MOUNT_002""
      }
    ]
  },
  ""shortName"": ""5894a42086f77426d2590762 ShortName"",
  ""weight"": 0.302,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX_GEN1_handguard""
},
""58a56f8d86f774651579314c"": {
  ""categories"": [
    ""55818b224bdc2dde698b456f"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58a56f8d86f774651579314c-icon.webp"",
  ""id"": ""58a56f8d86f774651579314c"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58a56f8d86f774651579314c-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-gen1-handguard-2-inch-rail"",
  ""name"": ""58a56f8d86f774651579314c Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 0,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""5a800961159bd4315e3a1657"",
            ""57fd23e32459772d0805bcf1"",
            ""544909bb4bdc2d6f028b4577"",
            ""5c06595c0db834001a66af6c"",
            ""5cc9c20cd7f00c001336c65d"",
            ""5d2369418abbc306c62e0c80"",
            ""5b07dd285acfc4001754240d"",
            ""56def37dd2720bec348b456a"",
            ""5a7b483fe899ef0016170d15"",
            ""61605d88ffa6e502ac5e7eeb"",
            ""5a5f1ce64f39f90b401987bc"",
            ""560d657b4bdc2da74d8b4572"",
            ""5b3a337e5acfc4704b4a19a0"",
            ""5c5952732e2216398b5abda2"",
            ""57d17e212459775a1179a0f5"",
            ""6267c6396b642f77f56f5c1c"",
            ""6272370ee4013c5d7e31f418"",
            ""6272379924e29f06af4d5ecb"",
            ""626becf9582c3e319310b837"",
            ""644a3df63b0b6f03e101e065"",
            ""646f6322f43d0c5d62063715""
          ]
        },
        ""nameId"": ""mod_tactical"",
        ""name"": ""MOD_TACTICAL""
      }
    ]
  },
  ""shortName"": ""58a56f8d86f774651579314c ShortName"",
  ""weight"": 0.07,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX_GEN1_handguard_2_inch_rail""
},
""58a5c12e86f7745d585a2b9e"": {
  ""categories"": [
    ""55818b224bdc2dde698b456f"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58a5c12e86f7745d585a2b9e-icon.webp"",
  ""id"": ""58a5c12e86f7745d585a2b9e"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58a5c12e86f7745d585a2b9e-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-gen1-handguard-4-inch-rail"",
  ""name"": ""58a5c12e86f7745d585a2b9e Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 0,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""5c7fc87d2e221644f31c0298"",
            ""5cda9bcfd7f00c0c0b53e900"",
            ""59f8a37386f7747af3328f06"",
            ""619386379fb0c665d5490dbe"",
            ""5c87ca002e221600114cb150"",
            ""588226d124597767ad33f787"",
            ""588226dd24597767ad33f789"",
            ""588226e62459776e3e094af7"",
            ""588226ef24597767af46e39c"",
            ""59fc48e086f77463b1118392"",
            ""5fce0cf655375d18a253eff0"",
            ""5cf4fb76d7f00c065703d3ac"",
            ""5b057b4f5acfc4771e1bd3e9"",
            ""5c791e872e2216001219c40a"",
            ""558032614bdc2de7118b4585"",
            ""58c157be86f77403c74b2bb6"",
            ""58c157c886f774032749fb06"",
            ""5f6340d3ca442212f4047eb2"",
            ""591af28e86f77414a27a9e1d"",
            ""5c1cd46f2e22164bef5cfedb"",
            ""5c1bc4812e22164bef5cfde7"",
            ""5c1bc5612e221602b5429350"",
            ""5c1bc5af2e221602b412949b"",
            ""5c1bc5fb2e221602b1779b32"",
            ""5c1bc7432e221602b412949d"",
            ""5c1bc7752e221602b1779b34"",
            ""64806bdd26c80811d408d37a"",
            ""64807a29e5ffe165600abc97"",
            ""648067db042be0705c0b3009"",
            ""65169d5b30425317755f8e25"",
            ""655df24fdf80b12750626d0a"",
            ""655dccfdbdcc6b5df71382b6""
          ]
        },
        ""nameId"": ""mod_foregrip"",
        ""name"": ""MOD_FOREGRIP""
      }
    ]
  },
  ""shortName"": ""58a5c12e86f7745d585a2b9e ShortName"",
  ""weight"": 0.05,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX_GEN1_handguard_4_inch_rail""
},
""58949edd86f77409483e16a9"": {
  ""categories"": [
    ""55818a6f4bdc2db9688b456b"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58949edd86f77409483e16a9-icon.webp"",
  ""id"": ""58949edd86f77409483e16a9"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58949edd86f77409483e16a9-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-double-latch-charging-handle"",
  ""name"": ""58949edd86f77409483e16a9 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 1,
    ""recoilModifier"": 0,
    ""slots"": []
  },
  ""shortName"": ""58949edd86f77409483e16a9 ShortName"",
  ""weight"": 0.033,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX_double_latch_charging_handle""
},
""58aeac1b86f77457c419f475"": {
  ""categories"": [
    ""550aa4cd4bdc2dd8348b456c"",
    ""5448fe394bdc2d0d028b456c"",
    ""550aa4154bdc2dd8348b456b"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58aeac1b86f77457c419f475-icon.webp"",
  ""id"": ""58aeac1b86f77457c419f475"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58aeac1b86f77457c419f475-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpx-sd-9x19-integrated-sound-suppressor"",
  ""name"": ""58aeac1b86f77457c419f475 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": -5,
    ""recoilModifier"": -0.11,
    ""slots"": []
  },
  ""shortName"": ""58aeac1b86f77457c419f475 ShortName"",
  ""weight"": 0.6,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX-SD_9x19_integrated_sound_suppressor""
},
""58ac1bf086f77420ed183f9f"": {
  ""categories"": [
    ""55818a594bdc2db9688b456a"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/58ac1bf086f77420ed183f9f-icon.webp"",
  ""id"": ""58ac1bf086f77420ed183f9f"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/58ac1bf086f77420ed183f9f-image.webp"",
  ""link"": ""https://tarkov.dev/item/mpxmcx-retractable-stock-adapter"",
  ""name"": ""58ac1bf086f77420ed183f9f Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": -2,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""57ade1442459771557167e15"",
            ""5a33ca0fc4a282000d72292f"",
            ""5c0faeddd174af02a962601f"",
            ""5649be884bdc2d79388b4577"",
            ""5d120a10d7ad1a4e1026ba85"",
            ""5b0800175acfc400153aebd4"",
            ""5947e98b86f774778f1448bc"",
            ""5947eab886f77475961d96c5"",
            ""5ef1ba28c64c5d0dfc0571a5"",
            ""602e3f1254072b51b239f713"",
            ""5c793fb92e221644f31bfb64"",
            ""5c793fc42e221600114ca25d"",
            ""591aef7986f774139d495f03"",
            ""591af10186f774139d495f0e"",
            ""627254cc9c563e6e442c398f"",
            ""638de3603a1a4031d8260b8c""
          ]
        },
        ""nameId"": ""mod_stock"",
        ""name"": ""MOD_STOCK""
      }
    ]
  },
  ""shortName"": ""58ac1bf086f77420ed183f9f ShortName"",
  ""weight"": 0.2,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MPX/MCX_retractable_stock_adapter""
},
""5a16b8a9fcdbcb00165aa6ca"": {
  ""categories"": [
    ""55818b224bdc2dde698b456f"",
    ""55802f3e4bdc2de7118b4584"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5a16b8a9fcdbcb00165aa6ca-icon.webp"",
  ""id"": ""5a16b8a9fcdbcb00165aa6ca"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a16b8a9fcdbcb00165aa6ca-image.webp"",
  ""link"": ""https://tarkov.dev/item/norotos-titanium-advanced-tactical-mount"",
  ""name"": ""5a16b8a9fcdbcb00165aa6ca Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": 0,
    ""recoilModifier"": 0,
    ""slots"": [
      {
        ""filters"": {
          ""allowedItems"": [
            ""5c0695860db834001b735461"",
            ""5a16b93dfcdbcbcae6687261"",
            ""5c11046cd174af02a012e42b""
          ]
        },
        ""nameId"": ""mod_nvg"",
        ""name"": ""MOD_NVG""
      }
    ]
  },
  ""shortName"": ""5a16b8a9fcdbcb00165aa6ca ShortName"",
  ""weight"": 0.07,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Norotos_Titanium_Advanced_Tactical_Mount""
},
""5a7b483fe899ef0016170d15"": {
  ""categories"": [
    ""55818b164bdc2ddc698b456c"",
    ""550aa4154bdc2dd8348b456b"",
    ""5448fe124bdc2da5018b4567"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5a7b483fe899ef0016170d15-icon.webp"",
  ""id"": ""5a7b483fe899ef0016170d15"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5a7b483fe899ef0016170d15-image.webp"",
  ""link"": ""https://tarkov.dev/item/surefire-xc1-tactical-flashlight"",
  ""name"": ""5a7b483fe899ef0016170d15 Name"",
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesWeaponMod"",
    ""accuracyModifier"": 0,
    ""ergonomics"": -1,
    ""recoilModifier"": 0,
    ""slots"": []
  },
  ""shortName"": ""5a7b483fe899ef0016170d15 ShortName"",
  ""weight"": 0.05,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/SureFire_XC1_tactical_flashlight""
},
""5f9949d869e2777a0e779ba5"": {
  ""categories"": [
    ""5b3f15d486f77432d0509248"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5f9949d869e2777a0e779ba5-icon.webp"",
  ""id"": ""5f9949d869e2777a0e779ba5"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5f9949d869e2777a0e779ba5-image.webp"",
  ""link"": ""https://tarkov.dev/item/armband-rivals-2020"",
  ""name"": ""5f9949d869e2777a0e779ba5 Name"",
  ""properties"": null,
  ""shortName"": ""5f9949d869e2777a0e779ba5 ShortName"",
  ""weight"": 0.05,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Armband_(Rivals_2020)""
},
""569668774bdc2da2298b4568"": {
  ""categories"": [
    ""543be5dd4bdc2deb348b4569"",
    ""5661632d4bdc2d903d8b456b"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/569668774bdc2da2298b4568-icon.webp"",
  ""id"": ""569668774bdc2da2298b4568"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/569668774bdc2da2298b4568-image.webp"",
  ""link"": ""https://tarkov.dev/item/euros"",
  ""name"": ""569668774bdc2da2298b4568 Name"",
  ""properties"": null,
  ""shortName"": ""569668774bdc2da2298b4568 ShortName"",
  ""stackMaxSize"": 50000,
  ""weight"": 0,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Euros""
},
""5696686a4bdc2da3298b456a"": {
  ""iconLink"": ""https://assets.tarkov.dev/5696686a4bdc2da3298b456a-icon.webp"",
  ""id"": ""5696686a4bdc2da3298b456a"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5696686a4bdc2da3298b456a-image.webp"",
  ""link"": ""https://tarkov.dev/item/dollars"",
  ""name"": ""5696686a4bdc2da3298b456a Name"",
  ""shortName"": ""5696686a4bdc2da3298b456a ShortName"",
  ""stackMaxSize"": 50000,
  ""weight"": 0,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Dollars"",
  ""conflictingSlotIds"": [],
  ""properties"": null,
  ""conflictingItems"": [],
  ""categories"": [
    ""543be5dd4bdc2deb348b4569"",
    ""5661632d4bdc2d903d8b456b"",
    ""54009119af1c881c07000029""
  ]
},
""5d235b4d86f7742e017bc88a"": {
  ""iconLink"": ""https://assets.tarkov.dev/5d235b4d86f7742e017bc88a-icon.webp"",
  ""id"": ""5d235b4d86f7742e017bc88a"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5d235b4d86f7742e017bc88a-image.webp"",
  ""link"": ""https://tarkov.dev/item/gp-coin"",
  ""name"": ""5d235b4d86f7742e017bc88a Name"",
  ""shortName"": ""5d235b4d86f7742e017bc88a ShortName"",
  ""stackMaxSize"": 100,
  ""weight"": 0.01,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/GP_coin"",
  ""conflictingSlotIds"": [],
  ""properties"": null,
  ""conflictingItems"": [],
  ""categories"": [
    ""543be5dd4bdc2deb348b4569"",
    ""5661632d4bdc2d903d8b456b"",
    ""54009119af1c881c07000029""
  ]
},
""5991b51486f77447b112d44f"": {
  ""categories"": [
    ""5447e0e74bdc2d3c308b4567"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5991b51486f77447b112d44f-icon.webp"",
  ""id"": ""5991b51486f77447b112d44f"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5991b51486f77447b112d44f-image.webp"",
  ""link"": ""https://tarkov.dev/item/ms2000-marker"",
  ""name"": ""5991b51486f77447b112d44f Name"",
  ""properties"": null,
  ""shortName"": ""5991b51486f77447b112d44f ShortName"",
  ""weight"": 0.15,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/MS2000_Marker""
},
""5e54f76986f7740366043752"": {
  ""categories"": [
    ""5a341c4686f77469e155819e"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [],
  ""iconLink"": ""https://assets.tarkov.dev/5e54f76986f7740366043752-icon.webp"",
  ""id"": ""5e54f76986f7740366043752"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/5e54f76986f7740366043752-image.webp"",
  ""link"": ""https://tarkov.dev/item/shroud-half-mask"",
  ""name"": ""5e54f76986f7740366043752 Name"",
  ""properties"": null,
  ""shortName"": ""5e54f76986f7740366043752 ShortName"",
  ""weight"": 0.1,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Shroud_half-mask""
},
""67f90180f07898267b0a4ed7"": {
  ""iconLink"": ""https://assets.tarkov.dev/67f90180f07898267b0a4ed7-icon.webp"",
  ""id"": ""67f90180f07898267b0a4ed7"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/67f90180f07898267b0a4ed7-image.webp"",
  ""link"": ""https://tarkov.dev/item/arena-cup-series-balaclava"",
  ""name"": ""67f90180f07898267b0a4ed7 Name"",
  ""shortName"": ""67f90180f07898267b0a4ed7 ShortName"",
  ""weight"": 0.1,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Arena_Cup_Series_balaclava"",
  ""conflictingSlotIds"": [],
  ""properties"": null,
  ""conflictingItems"": [],
  ""categories"": [
    ""5a341c4686f77469e155819e"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ]
},
""657089638db3adca1009f4ca"": {
  ""iconLink"": ""https://assets.tarkov.dev/657089638db3adca1009f4ca-icon.webp"",
  ""id"": ""657089638db3adca1009f4ca"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/657089638db3adca1009f4ca-image.webp"",
  ""link"": ""https://tarkov.dev/item/atomic-defense-cqcm-up-armored-ballistic-mask-black"",
  ""name"": ""657089638db3adca1009f4ca Name"",
  ""shortName"": ""657089638db3adca1009f4ca ShortName"",
  ""weight"": 2.1,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Atomic_Defense_CQCM_up_armored_ballistic_mask_(Black)"",
  ""categories"": [
    ""5a341c4686f77469e155819e"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""conflictingItems"": [
    ""66b5f65ca7f72d197e70bcd6"",
    ""66b5f666cad6f002ab7214c2"",
    ""66b5f661af44ca0014063c05"",
    ""5e01ef6886f77445f643baa4"",
    ""5e00c1ad86f774747333222c""
  ],
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesHelmet"",
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
    ""material"": ""UHMWPE""
  }
},
""656fad8c498d1b7e3e071da0"": {
  ""iconLink"": ""https://assets.tarkov.dev/656fad8c498d1b7e3e071da0-icon.webp"",
  ""id"": ""656fad8c498d1b7e3e071da0"",
  ""inspectImageLink"": ""https://assets.tarkov.dev/656fad8c498d1b7e3e071da0-image.webp"",
  ""link"": ""https://tarkov.dev/item/monoclete-level-iii-pe-ballistic-plate"",
  ""name"": ""656fad8c498d1b7e3e071da0 Name"",
  ""shortName"": ""656fad8c498d1b7e3e071da0 ShortName"",
  ""weight"": 1.35,
  ""wikiLink"": ""https://escapefromtarkov.fandom.com/wiki/Monoclete_level_III_PE_ballistic_plate"",
  ""conflictingItems"": [],
  ""categories"": [
    ""644120aa86ffbe10ee032b6f"",
    ""57bef4c42459772e8d35a53b"",
    ""543be5f84bdc2dd4348b456a"",
    ""566162e44bdc2d3f298b4573"",
    ""54009119af1c881c07000029""
  ],
  ""properties"": {
    ""propertiesType"": ""ItemPropertiesArmorAttachment"",
    ""blindnessProtection"": 0,
    ""class"": 4,
    ""durability"": 40,
    ""ergoPenalty"": -0.01,
    ""slots"": [],
    ""speedPenalty"": -0.01,
    ""turnPenalty"": 0,
    ""zones"": [
      ""Zone FR. PLATE"",
      ""Zone BCK. PLATE""
    ],
    ""material"": ""UHMWPE""
  }
}";
    }
}
