using System;
using FluentAssertions;
using TotovBuilder.Model.Builds;
using Xunit;

namespace TotovBuilder.Model.Test.Builds
{
    /// <summary>
    /// Represents test on the <see cref="InventoryItem"/> class.
    /// </summary>
    public class InventoryItemTest : SerializationTestBase
    {
        [Fact]
        public void Serialization_ShouldSerializeObject()
        {
            // Arrange
            InventoryItem inventoryItem = InventoryItem;

            // Act
            string result = Serialize(inventoryItem);

            // Assert
            result.Should().Be("{\"c\":[{\"i\":\"584147732459775a2b6d9f12\",\"m\":[{\"i\":{\"i\":\"57e3dba62459770f0c32322b\"},\"n\":\"mod_pistol_grip\"}]}],\"p\":\"\",\"i\":\"5ab8ebf186f7742d8b372e80\",\"q\":2}");
        }

        [Fact]
        public void Serialization_ShouldSerializeArray()
        {
            // Arrange
            InventoryItem[] inventoryItems = new InventoryItem[]
            {
                InventoryItem
            };

            // Act
            string result = Serialize(inventoryItems);

            // Assert
            result.Should().Be("[{\"c\":[{\"i\":\"584147732459775a2b6d9f12\",\"m\":[{\"i\":{\"i\":\"57e3dba62459770f0c32322b\"},\"n\":\"mod_pistol_grip\"}]}],\"p\":\"\",\"i\":\"5ab8ebf186f7742d8b372e80\",\"q\":2}]");
        }

        private readonly InventoryItem InventoryItem = new InventoryItem()
        {
            Content = new InventoryItem[]
            {
                new InventoryItem()
                {
                    ItemId = "584147732459775a2b6d9f12", // Kalashnikov AKS-74U 5.45x39 assault rifle
                    ModSlots = new InventoryItemModSlot[]
                    {
                        new InventoryItemModSlot()
                        {
                            Item = new InventoryItem()
                            {
                                ItemId = "57e3dba62459770f0c32322b", // AK bakelite pistol grip (6P4 Sb.9)
                            },
                            ModSlotName = "mod_pistol_grip"
                        }
                    }
                }
            },
            IgnorePrice = true,
            ItemId = "5ab8ebf186f7742d8b372e80", // SSO Attack 2 raid backpack
            Quantity = 2,
        };
    }
}
