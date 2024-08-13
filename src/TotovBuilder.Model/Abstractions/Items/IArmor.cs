namespace TotovBuilder.Model.Abstractions.Items
{
    /// <summary>
    /// Provides the functionalities of an armor.
    /// </summary>
    public interface IArmor : IModdable, IWearable
    {
        /// <summary>
        /// Armor class (without ballistic plates).
        /// </summary>
        double ArmorClass { get; set; }

        /// <summary>
        /// List of areas protected by the armor.
        /// </summary>
        string[] ArmoredAreas { get; set; }

        /// <summary>
        /// Blindness protection percentage.
        /// </summary>
        double BlindnessProtectionPercentage { get; set; }

        /// <summary>
        /// Durability
        /// </summary>
        double Durability { get; set; }

        /// <summary>
        /// Material which composes the armor.
        /// </summary>
        string Material { get; set; }
    }
}
