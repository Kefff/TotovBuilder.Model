namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents values related to Tarkov gameplay.
    /// </summary>
    public class TarkovValues
    {
        /// <summary>
        /// Player character chest HP.
        /// </summary>
        public int ChestHp { get; set; }

        /// <summary>
        /// Currencies.
        /// </summary>
        public Currency[] Currencies { get; set; } = [];

        /// <summary>
        /// Weight at which the character is heavily encumbered.
        /// </summary>
        public int HeavyEncumbermentWeight { get; set; }

        /// <summary>
        /// Weight at which the character is lightly encumbered.
        /// </summary>
        public int LightEncumbermentWeight { get; set; }

        /// <summary>
        /// Maximum level an armor can have.
        /// </summary>
        public int MaxArmorLevel { get; set; }

        /// <summary>
        /// Merchants.
        /// </summary>
        public Merchant[] Merchants { get; set; } = [];

        /// <summary>
        /// Ricochet chances.
        /// </summary>
        public RicochetChance[] RicochetChances { get; set; } = [];
    }
}
