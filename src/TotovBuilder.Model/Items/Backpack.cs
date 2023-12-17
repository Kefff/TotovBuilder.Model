using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a backpack.
    /// </summary>
    public class Backpack : Item, IBackpack
    {
        /// <inheritdoc/>
        [JsonPropertyName("ca")]
        public double Capacity { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("e")]
        public double ErgonomicsPercentageModifier { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ms")]
        public double MovementSpeedPercentageModifier { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("t")]
        public double TurningSpeedPercentageModifier { get; set; }
    }
}
