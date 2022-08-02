using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents eyewear.
    /// </summary>
    public class Eyewear : Item, IEyewear
    {
        /// <inheritdoc/>
        public double BlindnessProtectionPercentage { get; set; }
    }
}
