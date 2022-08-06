using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a grenade.
    /// </summary>
    public class Grenade : Item, IGrenade
    {
        /// <inheritdoc/>
        public double ExplosionDelay { get; set; }

        /// <inheritdoc/>
        public double FragmentsAmount { get; set; }

        /// <inheritdoc/>
        public double MaximumExplosionRange { get; set; }

        /// <inheritdoc/>
        public double MinimumExplosionRange { get; set; }

        /// <inheritdoc/>
        public string Type { get; set; } = string.Empty;
    }
}
