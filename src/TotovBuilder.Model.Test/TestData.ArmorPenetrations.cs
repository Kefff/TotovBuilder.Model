using TotovBuilder.Model.Configuration;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public static ArmorPenetration[] ArmorPenetrations { get; } = new ArmorPenetration[]
        {
            new ArmorPenetration()
            {
                AmmunitionId = "5d6e6772a4b936088465b17c",
                AmmunitionName = "12/70 5.25mm Buckshot",
                Values = new double[] { 3, 3, 3, 3, 3, 3 }
            },
            new ArmorPenetration()
            {
              AmmunitionId = "5d6e6806a4b936088465b17e",
              AmmunitionName = "12/70 8.5mm Magnum buckshot",
              Values = new double[] { 3, 3, 3, 3, 3, 3 }
            },
            new ArmorPenetration()
            {
                AmmunitionId = "5e85a9f4add9fe03027d9bf1",
                AmmunitionName = "23x75mm \"Zvezda\" flashbang round",
                Values = new double[] { 0, 0, 0, 0, 0, 0 }
            },
            new ArmorPenetration()
            {
                AmmunitionId = "5e81f423763d9f754677bf2e",
                AmmunitionName = ".45 ACP Match FMJ",
                Values = new double[] { 6, 6, 3, 1, 0, 0 }
            },
            new ArmorPenetration()
            {
                AmmunitionId = "6196365d58ef8c428c287da1",
                AmmunitionName = ".300 Whisper",
                Values = new double[] { 6, 4, 2, 1, 0, 0 }
            },
            new ArmorPenetration()
            {
                AmmunitionId = "56dff4ecd2720b5f5a8b4568",
                AmmunitionName = "5.45x39mm US gs",
                Values = new double[] { 6, 3, 0, 0, 0, 0 }
            },
            new ArmorPenetration()
            {
                AmmunitionId = "601aa3d2b2bcb34913271e6d",
                AmmunitionName = "7.62x39mm MAI AP",
                Values = new double[] { 6, 6, 6, 6, 6, 5 }
            }
        };

        public const string ArmorPenetrationsJson = @"[
  {
    ""ammunitionId"": ""5d6e6772a4b936088465b17c"",
    ""ammunitionName"": ""12/70 5.25mm Buckshot"",
    ""values"": [3, 3, 3, 3, 3, 3]
  },
  {
      ""ammunitionId"": ""5d6e6806a4b936088465b17e"",
      ""ammunitionName"": ""12/70 8.5mm Magnum buckshot"",
      ""values"": [3, 3, 3, 3, 3, 3]
  },
  {
    ""ammunitionId"": ""5e85a9f4add9fe03027d9bf1"",
    ""ammunitionName"": ""23x75mm \""Zvezda\"" flashbang round"",
    ""values"": [0, 0, 0, 0, 0, 0]
  },
  {
    ""ammunitionId"": ""5e81f423763d9f754677bf2e"",
    ""ammunitionName"": "".45 ACP Match FMJ"",
    ""values"": [6, 6, 3, 1, 0, 0]
  },
  {
    ""ammunitionId"": ""6196365d58ef8c428c287da1"",
    ""ammunitionName"": "".300 Whisper"",
    ""values"": [6, 4, 2, 1, 0, 0]
  },
  {
    ""ammunitionId"": ""56dff4ecd2720b5f5a8b4568"",
    ""ammunitionName"": ""5.45x39mm US gs"",
    ""values"": [6, 3, 0, 0, 0, 0]
  },
  {
    ""ammunitionId"": ""601aa3d2b2bcb34913271e6d"",
    ""ammunitionName"": ""7.62x39mm MAI AP"",
    ""values"": [6, 6, 6, 6, 6, 5]
  }
]";
    }
}
