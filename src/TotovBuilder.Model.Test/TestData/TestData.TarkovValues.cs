using System.Threading;
using System.Xml.Linq;
using TotovBuilder.Model.Configuration;
using TotovBuilder.Model.Items;
using static System.Formats.Asn1.AsnWriter;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public static TarkovValues TarkovValues { get; } = new TarkovValues()
        {
            ChestHp = 85,
            Currencies =
            [
                new Currency()
                {
                  IconName =  "balance-scale",
                  ItemId = "",
                  MainCurrency = false,
                  Name = "barter",
                  SortOrder = 0,
                },
                new Currency()
                {
                  IconName = "dollar-sign",
                  ItemId = "5696686a4bdc2da3298b456a",
                  MainCurrency = false,
                  Name = "USD",
                  SortOrder = 3,
                  Symbol = "$"
                },
                new Currency()
                {
                  IconName = "euro-sign",
                  ItemId = "569668774bdc2da2298b4568",
                  MainCurrency = false,
                  Name = "EUR",
                  SortOrder = 2,
                  Symbol = "€"
                },
                new Currency()
                {
                  ItemId = "5d235b4d86f7742e017bc88a",
                  MainCurrency = false,
                  Name = "GPCOIN",
                  SortOrder = 4
                },
                new Currency()
                {
                  IconName = "ruble-sign",
                  ItemId = "5449016a4bdc2d6f028b456f",
                  MainCurrency = true,
                  Name = "RUB",
                  SortOrder = 1,
                  Symbol = "₽"
                }
            ],
            HeavyEncumbermentWeight = 65,
            LightEncumbermentWeight = 24,
            MaxArmorLevel = 6,
            Merchants =
            [
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "prapor",
                    Order = 1,
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "therapist",
                    Order = 2,
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 1,
                    MinLevel = 1,
                    Name = "fence",
                    Order = 3,
                    ShowInFilter = false
                },
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "skier",
                    Order = 4,
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "peacekeeper",
                    Order = 5,
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "mechanic",
                    Order = 6,
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "ragman",
                    Order = 7,
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "jaeger",
                    Order = 8,
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "ref",
                    Order = 9,
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 0,
                    MinLevel = 0,
                    Name = "flea-market",
                    Order = 10,
                    ShowInFilter = true
                }
            ],
            RicochetChances =
            [
                new RicochetChance()
                {
                    Name = "High",
                    XMaxValue = 1,
                    XMinValue = 0.9
                },
                new RicochetChance()
                {
                    Name = "Medium",
                    XMaxValue = 0.8,
                    XMinValue = 0.7
                },
                new RicochetChance()
                {
                    Name = "Low",
                    XMaxValue = 0.6,
                    XMinValue = 0.1
                }
            ]
        };
    }
}
