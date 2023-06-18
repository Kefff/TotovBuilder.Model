using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a backpack.
    /// </summary>
    public class Backpack : Item, IBackpack
    {
        /// <inheritdoc/>
        public double Capacity { get; set; }

        /// <inheritdoc/>
        public double ErgonomicsPercentageModifier { get; set; }

        /// <inheritdoc/>
        public double MovementSpeedPercentageModifier { get; set; }

        /// <inheritdoc/>
        public double TurningSpeedPercentageModifier { get; set; }
    }
}
