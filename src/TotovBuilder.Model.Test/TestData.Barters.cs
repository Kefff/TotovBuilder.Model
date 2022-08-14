using TotovBuilder.Model.Items;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public static Price[] Barters = new Price[]
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
                QuestId = "59675d6c86f7740a842fc482"
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

        public const string BartersJson = @"{
  ""data"": {
    ""barters"": [
      {
        ""level"": 1,
        ""requiredItems"": [
          {
            ""item"": {
              ""id"": ""5e32f56fcb6d5863cc5e5ee4""
            },
            ""quantity"": 2
          },
          {
            ""item"": {
              ""id"": ""5b432be65acfc433000ed01f""
            },
            ""quantity"": 1
          }
        ],
        ""rewardItems"": [
          {
            ""item"": {
              ""id"": ""545cdb794bdc2d3a198b456a""
            },
            ""quantity"": 1
          }
        ],
        ""trader"": {
          ""normalizedName"": ""prapor""
        },
        ""taskUnlock"": {
          ""id"": ""59675d6c86f7740a842fc482""
        }
      },
      {
        ""level"": 3,
        ""requiredItems"": [
          {
            ""item"": {
              ""id"": ""5f9949d869e2777a0e779ba5""
            },
            ""quantity"": 4
          }
        ],
        ""rewardItems"": [
          {
            ""item"": {
              ""id"": ""545cdb794bdc2d3a198b456a""
            },
            ""quantity"": 1
          }
        ],
        ""trader"": {
          ""normalizedName"": ""mechanic""
        },
        ""taskUnlock"": null
      },
      {
        ""level"": 1,
        ""requiredItems"": [
          {
            ""item"": {
              ""id"": ""5e4bfc1586f774264f7582d3""
            },
            ""quantity"": 1
          }
        ],
        ""rewardItems"": [
          {
            ""item"": {
              ""id"": ""5e32f56fcb6d5863cc5e5ee4""
            },
            ""quantity"": 2
          },
          {
            ""item"": {
              ""id"": ""5f9949d869e2777a0e779ba5""
            },
            ""quantity"": 1
          }
        ],
        ""trader"": {
          ""normalizedName"": ""skier""
        },
        ""taskUnlock"": null
      }
    ]
  }
}";
    }
}
