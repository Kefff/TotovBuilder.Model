namespace TotovBuilder.Model.Abstractions.Items
{
    /// <summary>
    /// Provides the functionalities of a grenade.
    /// </summary>
    public interface IGrenade : IItem
    {
        /// <summary>
        /// Delay before explosion in seconds.
        /// </summary>
        double ExplosionDelay { get; set; }

        /// <summary>
        /// Number of fragments.
        /// </summary>
        double FragmentsAmount { get; set; }

        /// <summary>
        /// Explodes on impact.
        /// </summary>
        bool Impact { get; set; }

        /// <summary>
        /// Maximum explosion range in meters.
        /// </summary>
        double MaximumExplosionRange { get; set; }

        /// <summary>
        /// Minimum explosion range in meters.
        /// </summary>
        double MinimumExplosionRange { get; set; }
    }
}
