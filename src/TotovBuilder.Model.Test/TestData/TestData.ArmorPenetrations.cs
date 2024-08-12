using TotovBuilder.Model.Configuration;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public static partial class TestData
    {
        public static ArmorPenetration[] ArmorPenetrations { get; } =
        [
            new ArmorPenetration()
            {
                AmmunitionId = "5d6e6772a4b936088465b17c",
                AmmunitionName = "12/70 5.25mm Buckshot",
                Values = [3, 3, 3, 3, 3, 3]
            },
            new ArmorPenetration()
            {
                AmmunitionId = "5d6e6806a4b936088465b17e",
                AmmunitionName = "12/70 8.5mm Magnum buckshot",
                Values = [3, 3, 3, 3, 3, 3]
            },
            new ArmorPenetration()
            {
                AmmunitionId = "5e85a9f4add9fe03027d9bf1",
                AmmunitionName = "23x75mm \"Zvezda\" flashbang round",
                Values = [0, 0, 0, 0, 0, 0]
            },
            new ArmorPenetration()
            {
                AmmunitionId = "5e81f423763d9f754677bf2e",
                AmmunitionName = ".45 ACP Match FMJ",
                Values = [6, 6, 3, 1, 0, 0]
            },
            new ArmorPenetration()
            {
                AmmunitionId = "6196365d58ef8c428c287da1",
                AmmunitionName = ".300 Whisper",
                Values = [6, 4, 2, 1, 0, 0]
            },
            new ArmorPenetration()
            {
                AmmunitionId = "56dff4ecd2720b5f5a8b4568",
                AmmunitionName = "5.45x39mm US gs",
                Values = [6, 3, 0, 0, 0, 0]
            },
            new ArmorPenetration()
            {
                AmmunitionId = "601aa3d2b2bcb34913271e6d",
                AmmunitionName = "7.62x39mm MAI AP",
                Values = [6, 6, 6, 6, 6, 5]
            },
            new ArmorPenetration()
            {
                AmmunitionId = "5efb0da7a29a85116f6ea05f",
                AmmunitionName = "9x19mm PBP gzh",
                Values = [6, 6, 6, 5, 4, 3]
            },
            new ArmorPenetration()
            {
                AmmunitionId = "5c3df7d588a4501f290594e5",
                AmmunitionName = "9x19mm Green Tracer",
                Values = [6, 3, 1, 0, 0, 0]
            }
        ];
    }
}
