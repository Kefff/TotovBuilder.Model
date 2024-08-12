namespace TotovBuilder.Model.Abstractions.Items
{
    /// <summary>
    /// Provides the functionalities of eyewear.
    /// </summary>
    public interface IEyewear : IArmor
    {
        /// <summary>
        /// Blindness protection percentage.
        /// </summary>
        double BlindnessProtectionPercentage { get; set; }
    }
}
