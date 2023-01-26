﻿using TotovBuilder.Model.Builds;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public static InventoryItem[] Presets { get; } = new InventoryItem[]
        {
            new InventoryItem()
            {
                ItemId = "57dc2fa62459775949412633",
                ModSlots = new InventoryItemModSlot[]
                {
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "57e3dba62459770f0c32322b",
                        },
                        ModSlotName = "mod_pistol_grip"
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "57dc347d245977596754e7a1",
                        },
                        ModSlotName = "mod_stock"
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "564ca99c4bdc2d16268b4589",
                        },
                        ModSlotName = "mod_magazine"
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "57dc324a24597759501edc20",
                        },
                        ModSlotName = "mod_muzzle"
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "57dc334d245977597164366f",
                        },
                        ModSlotName = "mod_reciever"
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "59d36a0086f7747e673f3946",
                            ModSlots = new InventoryItemModSlot[]
                            {
                                new InventoryItemModSlot()
                                {
                                    Item = new InventoryItem()
                                    {
                                        ItemId = "57dc32dc245977596d4ef3d3"
                                    },
                                    ModSlotName = "mod_handguard"
                                }
                            }
                        },
                        ModSlotName = "mod_gas_block"
                    }
                }
            },
        };

        public const string PresetsJson = @"[
  {
    ""content"": [],
    ""ignorePrice"": false,
    ""itemId"": ""57dc2fa62459775949412633"",
    ""modSlots"": [
      {
        ""item"": {
          ""content"": [],
          ""ignorePrice"": false,
          ""itemId"": ""57e3dba62459770f0c32322b"",
          ""modSlots"": [],
          ""quantity"": 1
        },
        ""modSlotName"": ""mod_pistol_grip""
      },
      {
        ""item"": {
          ""content"": [],
          ""ignorePrice"": false,
          ""itemId"": ""57dc347d245977596754e7a1"",
          ""modSlots"": [],
          ""quantity"": 1
        },
        ""modSlotName"": ""mod_stock""
      },
      {
        ""item"": {
          ""content"": [],
          ""ignorePrice"": false,
          ""itemId"": ""564ca99c4bdc2d16268b4589"",
          ""modSlots"": [],
          ""quantity"": 1
        },
        ""modSlotName"": ""mod_magazine""
      },
      {
        ""item"": {
          ""content"": [],
          ""ignorePrice"": false,
          ""itemId"": ""57dc324a24597759501edc20"",
          ""modSlots"": [],
          ""quantity"": 1
        },
        ""modSlotName"": ""mod_muzzle""
      },
      {
        ""item"": {
          ""content"": [],
          ""ignorePrice"": false,
          ""itemId"": ""57dc334d245977597164366f"",
          ""modSlots"": [],
          ""quantity"": 1
        },
        ""modSlotName"": ""mod_reciever""
      },
      {
        ""item"": {
          ""content"": [],
          ""ignorePrice"": false,
          ""itemId"": ""59d36a0086f7747e673f3946"",
          ""modSlots"": [
            {
              ""item"": {
                ""content"": [],
                ""ignorePrice"": false,
                ""itemId"": ""57dc32dc245977596d4ef3d3"",
                ""modSlots"": [],
                ""quantity"": 1
              },
              ""modSlotName"": ""mod_handguard""
            }
          ],
          ""quantity"": 1
        },
        ""modSlotName"": ""mod_gas_block""
      }
    ],
    ""quantity"": 1
  }
]";
    }
}
