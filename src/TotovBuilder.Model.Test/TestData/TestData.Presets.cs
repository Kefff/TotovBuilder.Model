using TotovBuilder.Model.Builds;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public static InventoryItem[] Presets { get; } =
        [
            new InventoryItem()
            {
                ItemId = "584147732459775a2b6d9f12",
                ModSlots =
                [
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
                            ItemId = "57dc347d245977596754e7a1"
                        },
                        ModSlotName = "mod_stock"
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            Content =
                            [
                                new InventoryItem()
                                {
                                    ItemId = "56dff4ecd2720b5f5a8b4568",
                                    Quantity = 30
                                }
                            ],
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
                            ItemId = "57dc334d245977597164366f"
                        },
                        ModSlotName = "mod_reciever"
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "59d36a0086f7747e673f3946",
                            ModSlots =
                            [
                                new InventoryItemModSlot()
                                {
                                    Item = new InventoryItem()
                                    {
                                        ItemId = "57dc32dc245977596d4ef3d3"
                                    },
                                    ModSlotName = "mod_handguard"
                                }
                            ]
                        },
                        ModSlotName = "mod_gas_block"
                    }
                ]
            },
            new InventoryItem()
            {
                ItemId = "5a8ae43686f774377b73cfb3",
                ModSlots =
                [
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "57c55efc2459772d2c6271e7"
                        },
                        ModSlotName = "mod_pistol_grip"
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            Content =
                            [
                                new InventoryItem()
                                {
                                    ItemId = "5efb0da7a29a85116f6ea05f",
                                    Quantity = 30.0
                                }
                            ],
                            ItemId = "5894a05586f774094708ef75"
                        },
                        ModSlotName = "mod_magazine"
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "5894a5b586f77426d2590767",
                            ModSlots =
                            [
                                new InventoryItemModSlot()
                                {
                                    Item = new InventoryItem()
                                    {
                                        ItemId = "57adff4f24597737f373b6e6",
                                        ModSlots =
                                        [
                                            new InventoryItemModSlot()
                                            {
                                                Item = new InventoryItem()
                                                {
                                                    ItemId = "58d2664f86f7747fec5834f6",
                                                    ModSlots =
                                                    [
                                                        new InventoryItemModSlot()
                                                        {
                                                            Item = new InventoryItem()
                                                            {
                                                                ItemId = "58d268fc86f774111273f8c2"
                                                            },
                                                            ModSlotName = "mod_scope"
                                                        }
                                                    ]
                                                },
                                                ModSlotName = "mod_scope"
                                            }
                                        ]
                                    },
                                    ModSlotName = "mod_scope"
                                },
                                new InventoryItemModSlot()
                                {
                                    Item = new InventoryItem()
                                    {
                                        ItemId = "58aeaaa886f7744fc1560f81",
                                        ModSlots =
                                        [
                                            new InventoryItemModSlot()
                                            {
                                                Item = new InventoryItem()
                                                {
                                                    ItemId = "58aeac1b86f77457c419f475"
                                                },
                                                ModSlotName = "mod_muzzle"
                                            }
                                        ]
                                    },
                                    ModSlotName = "mod_barrel"
                                },
                                new InventoryItemModSlot()
                                {
                                    Item = new InventoryItem()
                                    {
                                        ItemId = "5894a42086f77426d2590762",
                                        ModSlots =
                                        [
                                            new InventoryItemModSlot()
                                            {
                                                Item = new InventoryItem()
                                                {
                                                    ItemId = "58a56f8d86f774651579314c"
                                                },
                                                ModSlotName = "mod_mount_000"
                                            },
                                            new InventoryItemModSlot()
                                            {
                                                Item = new InventoryItem()
                                                {
                                                    ItemId = "58a5c12e86f7745d585a2b9e",
                                                    ModSlots =
                                                    [
                                                        new InventoryItemModSlot()
                                                        {
                                                            Item = new InventoryItem()
                                                            {
                                                                ItemId = "59f8a37386f7747af3328f06"
                                                            },
                                                            ModSlotName = "mod_foregrip"
                                                        }
                                                    ]
                                                },
                                                ModSlotName = "mod_mount_001"
                                            },
                                            new InventoryItemModSlot()
                                            {
                                                Item = new InventoryItem()
                                                {
                                                    ItemId = "58a56f8d86f774651579314c",
                                                    ModSlots =
                                                    [
                                                        new InventoryItemModSlot()
                                                        {
                                                            Item = new InventoryItem()
                                                            {
                                                                ItemId = "5a7b483fe899ef0016170d15"
                                                            },
                                                            ModSlotName = "mod_tactical"
                                                        }
                                                    ]
                                                },
                                                ModSlotName = "mod_mount_002"
                                            },
                                        ]
                                    },
                                    ModSlotName = "mod_handguard"
                                }
                            ]
                        },
                        ModSlotName = "mod_reciever",
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "58ac1bf086f77420ed183f9f",
                            ModSlots =
                            [
                                new InventoryItemModSlot()
                                {
                                    Item = new InventoryItem()
                                    {
                                        ItemId = "591aef7986f774139d495f03"
                                    },
                                    ModSlotName = "mod_stock"
                                }
                            ]
                        },
                        ModSlotName = "mod_stock"
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "58949edd86f77409483e16a9"
                        },
                        ModSlotName = "mod_charge"
                    }
                ]
            },
            new InventoryItem()
            {
                ItemId = "5a3b898486f77467720a2f29",
                ModSlots =
                [
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "5a16b8a9fcdbcb00165aa6ca",
                            ModSlots =
                            [
                                new InventoryItemModSlot()
                                {
                                    Item = new InventoryItem()
                                    {
                                        ItemId = "5a16b93dfcdbcbcae6687261",
                                        ModSlots =
                                        [
                                            new InventoryItemModSlot()
                                            {
                                                Item = new InventoryItem()
                                                {
                                                    ItemId = "57235b6f24597759bf5a30f1"
                                                },
                                                ModSlotName = "mod_nvg"
                                            }
                                        ]
                                    },
                                    ModSlotName = "mod_nvg"
                                }
                            ]
                        },
                        ModSlotName = "mod_nvg"
                    }
                ]
            },
            new InventoryItem()
            {
                ItemId = "657660eb86f11bca4106d34f",
                ModSlots =
                [
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "656fad8c498d1b7e3e071da0"
                        },
                        ModSlotName = "front_plate"
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "656fad8c498d1b7e3e071da0",
                        },
                        ModSlotName = "back_plate"
                    }
                ]
            },
            new InventoryItem()
            {
                ItemId = "65766adc234b9f6e050a431a",
                ModSlots =
                [
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "64afc71497cf3a403c01ff38"
                        },
                        ModSlotName = "front_plate"
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "64afc71497cf3a403c01ff38"
                        },
                        ModSlotName = "back_plate"
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "64afd81707e2cf40e903a316"
                        },
                        ModSlotName = "left_side_plate"
                    },
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "64afd81707e2cf40e903a316"
                        },
                        ModSlotName = "right_side_plate"
                    }
                ]
            },
            new InventoryItem()
            {
                ItemId = "test-preset-face-shield-alone"
            },
            new InventoryItem()
            {
                ItemId = "test-preset-gas-tube-handguard",
                ModSlots =
                [
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "57dc32dc245977596d4ef3d3"
                        },
                        ModSlotName = "mod_handguard"
                    }
                ]
            },
            new InventoryItem()
            {
                ItemId = "test-preset-ring-flashlight",
                ModSlots =
                [
                    new InventoryItemModSlot()
                    {
                        Item = new InventoryItem()
                        {
                            ItemId = "59d790f486f77403cb06aec6"
                        },
                        ModSlotName = "mod_flashlight"
                    }
                ]
            }
        ];
    }
}
