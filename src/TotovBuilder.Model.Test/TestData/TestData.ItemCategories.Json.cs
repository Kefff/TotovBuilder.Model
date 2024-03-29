﻿namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public partial class TestData
    {
        public const string ItemCategoriesJson = @"[
  {
    ""id"": ""ammunition"",
    ""types"": [
      {
        ""id"": ""5485a8684bdc2da71d8b4567"",
        ""name"": ""Ammo""
      }
    ]
  },
  {
    ""id"": ""armband"",
    ""types"": [
      {
        ""id"": ""5b3f15d486f77432d0509248"",
        ""name"": ""ArmBand""
      }
    ]
  },
  {
    ""id"": ""armor"",
    ""types"": [
      {
        ""id"": ""5448e54d4bdc2dcc718b4568"",
        ""name"": ""Armor""
      }
    ]
  },
  {
    ""id"": ""armorMod"",
    ""types"": [
      {
        ""id"": ""57bef4c42459772e8d35a53b"",
        ""name"": ""ArmoredEquipment""
      }
    ]
  },
  {
    ""id"": ""backpack"",
    ""types"": [
      {
        ""id"": ""5448e53e4bdc2d60728b4567"",
        ""name"": ""Backpack""
      }
    ]
  },
  {
    ""id"": ""container"",
    ""types"": [
      {
        ""id"": ""5795f317245977243854e041"",
        ""name"": ""SimpleContainer""
      }
    ]
  },
  {
    ""id"": ""currency"",
    ""types"": [
      {
        ""id"": ""543be5dd4bdc2deb348b4569"",
        ""name"": ""Money""
      }
    ]
  },
  {
    ""id"": ""eyewear"",
    ""types"": [
      {
        ""id"": ""5448e5724bdc2ddf718b4568"",
        ""name"": ""Visors""
      }
    ]
  },
  {
    ""id"": ""faceCover"",
    ""types"": [
      {
        ""id"": ""5a341c4686f77469e155819e"",
        ""name"": ""FaceCover""
      }
    ]
  },
  {
    ""id"": ""grenade"",
    ""types"": [
      {
        ""id"": ""543be6564bdc2df4348b4568"",
        ""name"": ""ThrowWeap""
      }
    ]
  },
  {
    ""id"": ""headphones"",
    ""types"": [
      {
        ""id"": ""5645bcb74bdc2ded0b8b4578"",
        ""name"": ""Headphones""
      }
    ]
  },
  {
    ""id"": ""headwear"",
    ""types"": [
      {
        ""id"": ""5a341c4086f77401f2541505"",
        ""name"": ""Headwear""
      }
    ]
  },
  {
    ""id"": ""magazine"",
    ""types"": [
      {
        ""id"": ""610720f290b75a49ff2e5e25"",
        ""name"": ""CylinderMagazine""
      },
      {
        ""id"": ""5448bc234bdc2d3c308b4569"",
        ""name"": ""Magazine""
      }
    ]
  },
  {
    ""id"": ""mainWeapon"",
    ""types"": [
      {
        ""id"": ""5447b5fc4bdc2d87278b4567"",
        ""name"": ""AssaultCarbine""
      },
      {
        ""id"": ""5447b5f14bdc2d61278b4567"",
        ""name"": ""AssaultRifle""
      },
      {
        ""id"": ""5447bedf4bdc2d87278b4568"",
        ""name"": ""GrenadeLauncher""
      },
      {
        ""id"": ""5447bed64bdc2d97278b4568"",
        ""name"": ""MachineGun""
      },
      {
        ""id"": ""5447b6194bdc2d67278b4567"",
        ""name"": ""MarksmanRifle""
      },
      {
        ""id"": ""617f1ef5e8b54b0998387733"",
        ""name"": ""Revolver""
      },
      {
        ""id"": ""5447b6094bdc2dc3278b4567"",
        ""name"": ""Shotgun""
      },
      {
        ""id"": ""5447b5e04bdc2d62278b4567"",
        ""name"": ""Smg""
      },
      {
        ""id"": ""5447b6254bdc2dc3278b4568"",
        ""name"": ""SniperRifle""
      }
    ]
  },
  {
    ""id"": ""meleeWeapon"",
    ""types"": [
      {
        ""id"": ""5447e1d04bdc2dff2f8b4567"",
        ""name"": ""Knife""
      }
    ]
  },
  {
    ""id"": ""mod"",
    ""types"": [
      {
        ""id"": ""55818b084bdc2d5b648b4571"",
        ""name"": ""Flashlight""
      },
      {
        ""id"": ""55818b224bdc2dde698b456f"",
        ""name"": ""Mount""
      },
      {
        ""id"": ""5a2c3a9486f774688b05e574"",
        ""name"": ""NightVision""
      },
      {
        ""id"": ""5d21f59b6dbe99052b54ef83"",
        ""name"": ""ThermalVision""
      }
    ]
  },
  {
    ""id"": ""other"",
    ""types"": []
  },
  {
    ""id"": ""rangedWeaponMod"",
    ""types"": [
      {
        ""id"": ""55818add4bdc2d5b648b456f"",
        ""name"": ""AssaultScope""
      },
      {
        ""id"": ""5a74651486f7744e73386dd1"",
        ""name"": ""AuxiliaryMod""
      },
      {
        ""id"": ""555ef6e44bdc2de9068b457e"",
        ""name"": ""Barrel""
      },
      {
        ""id"": ""55818afb4bdc2dde698b456d"",
        ""name"": ""Bipod""
      },
      {
        ""id"": ""55818a6f4bdc2db9688b456b"",
        ""name"": ""Charge""
      },
      {
        ""id"": ""55818ad54bdc2ddc698b4569"",
        ""name"": ""Collimator""
      },
      {
        ""id"": ""55818acf4bdc2dde698b456b"",
        ""name"": ""CompactCollimator""
      },
      {
        ""id"": ""550aa4bf4bdc2dd6348b456b"",
        ""name"": ""FlashHider""
      },
      {
        ""id"": ""55818af64bdc2d5b648b4570"",
        ""name"": ""Foregrip""
      },
      {
        ""id"": ""56ea9461d2720b67698b456f"",
        ""name"": ""Gasblock""
      },
      {
        ""id"": ""55818a104bdc2db9688b4569"",
        ""name"": ""Handguard""
      },
      {
        ""id"": ""55818ac54bdc2d5b648b456e"",
        ""name"": ""IronSight""
      },
      {
        ""id"": ""55818b014bdc2ddc698b456b"",
        ""name"": ""Launcher""
      },
      {
        ""id"": ""550aa4dd4bdc2dc9348b4569"",
        ""name"": ""MuzzleCombo""
      },
      {
        ""id"": ""55818ae44bdc2dde698b456c"",
        ""name"": ""OpticScope""
      },
      {
        ""id"": ""55818a684bdc2ddd698b456d"",
        ""name"": ""PistolGrip""
      },
      {
        ""id"": ""55818a304bdc2db5418b457d"",
        ""name"": ""Receiver""
      },
      {
        ""id"": ""550aa4cd4bdc2dd8348b456c"",
        ""name"": ""Silencer""
      },
      {
        ""id"": ""55818aeb4bdc2ddc698b456a"",
        ""name"": ""SpecialScope""
      },
      {
        ""id"": ""55818a594bdc2db9688b456a"",
        ""name"": ""Stock""
      },
      {
        ""id"": ""55818b164bdc2ddc698b456c"",
        ""name"": ""TacticalCombo""
      }
    ]
  },
  {
    ""id"": ""secondaryWeapon"",
    ""types"": [
      {
        ""id"": ""5447b5cf4bdc2d65278b4567"",
        ""name"": ""Pistol""
      }
    ]
  },
  {
    ""id"": ""securedContainer"",
    ""types"": [
      {
        ""id"": ""5448bf274bdc2dfc2f8b456a"",
        ""name"": ""MobContainer""
      }
    ]
  },
  {
    ""id"": ""special"",
    ""types"": [
      {
        ""id"": ""5f4fbaaca5573a5ac31db429"",
        ""name"": ""Compass""
      },
      {
        ""id"": ""5447e0e74bdc2d3c308b4567"",
        ""name"": ""Special item""
      }
    ]
  },
  {
    ""id"": ""vest"",
    ""types"": [
      {
        ""id"": ""5448e5284bdc2dcb718b4567"",
        ""name"": ""Vest""
      }
    ]
  }
]
";
    }
}
