using TotovBuilder.Model.Configuration;
using TotovBuilder.Model.Items;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public static Price[] Barters { get; } = new Price[]
        {
            new Price()
            {
                BarterItems = new BarterItem[]
                {
                    new BarterItem()
                    {
                        ItemId = "5e32f56fcb6d5863cc5e5ee4",
                        Quantity = 2
                    },
                    new BarterItem()
                    {
                        ItemId = "5b432be65acfc433000ed01f",
                        Quantity = 1
                    }
                },
                ItemId = "545cdb794bdc2d3a198b456a",
                CurrencyName = "barter",
                Merchant = "prapor",
                MerchantLevel = 1,
                Quest = new Quest()
                {
                    Id = "59675d6c86f7740a842fc482",
                    Name = "Ice Cream Cones",
                    WikiLink = "https://escapefromtarkov.fandom.com/wiki/Ice_Cream_Cones"
                }
            },
            new Price()
            {
                BarterItems = new BarterItem[]
                {
                    new BarterItem()
                    {
                        ItemId = "5f9949d869e2777a0e779ba5",
                        Quantity = 4
                    }
                },
                ItemId = "545cdb794bdc2d3a198b456a",
                CurrencyName = "barter",
                Merchant = "mechanic",
                MerchantLevel = 3
            },
            new Price()
            {
                BarterItems = new BarterItem[]
                {
                    new BarterItem()
                    {
                        ItemId = "5e4bfc1586f774264f7582d3",
                        Quantity = 0.5
                    }
                },
                ItemId = "5e32f56fcb6d5863cc5e5ee4",
                CurrencyName = "barter",
                Merchant = "skier",
                MerchantLevel = 1
            },
            new Price()
            {
                BarterItems = new BarterItem[]
                {
                    new BarterItem()
                    {
                        ItemId = "5e4bfc1586f774264f7582d3",
                        Quantity = 0.5
                    }
                },
                CurrencyName = "barter",
                ItemId = "5f9949d869e2777a0e779ba5",
                Merchant = "skier",
                MerchantLevel = 1
            }
        };
    }
}
