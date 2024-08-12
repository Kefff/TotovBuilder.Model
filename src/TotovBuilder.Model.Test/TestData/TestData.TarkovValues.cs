using TotovBuilder.Model.Configuration;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public static TarkovValues TarkovValues { get; } = new TarkovValues()
        {
            ArmorPenetrationEfficiencies =
            [
                "> 20",
                "13 - 20",
                "9 - 13",
                "5 - 9",
                "3 - 5",
                "1 - 3",
                "< 1"
            ],
            ChestHp = 85,
            Currencies =
            [
                new Currency()
                {
                    IconName = "dollar-sign",
                    ItemId = "5696686a4bdc2da3298b456a",
                    MainCurrency = false,
                    Name = "USD"
                },
                new Currency()
                {
                    IconName = "euro-sign",
                    ItemId = "569668774bdc2da2298b4568",
                    MainCurrency = false,
                    Name = "EUR"
                },
                new Currency()
                {
                    IconName = "ruble-sign",
                    ItemId = "5449016a4bdc2d6f028b456f",
                    MainCurrency = true,
                    Name = "RUB"
                }
            ],
            HeavyEncumbermentWeight = 65,
            LightEncumbermentWeight = 24,
            Merchants =
            [
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "prapor",
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "therapist",
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "skier",
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 1,
                    MinLevel = 1,
                    Name = "fence",
                    ShowInFilter = false
                },
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "peacekeeper",
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "mechanic",
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "ragman",
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 4,
                    MinLevel = 1,
                    Name = "jaeger",
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 0,
                    MinLevel = 0,
                    Name = "flea-market",
                    ShowInFilter = true
                },
                new Merchant()
                {
                    MaxLevel = 0,
                    MinLevel = 0,
                    Name = "items-without-merchant",
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
