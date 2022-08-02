namespace TotovBuilder.Model.Abstractions.Items
{
    /// <summary>
    /// Provides the functionalities of an armor mod.
    /// </summary>
    public interface IArmorMod : IArmor, IModdable
    {
        /// <summary>
        /// Blindness protection percentage.
        /// </summary>
        double BlindnessProtectionPercentage { get; set; }
    }
}
