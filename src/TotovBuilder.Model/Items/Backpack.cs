using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a backpack.
    /// </summary>
    [JsonConverter(typeof(BackpackJsonConverter<IBackpack, Backpack>))]
    public class Backpack : Item, IBackpack
    {
        /// <inheritdoc/>
        [JsonPropertyName("ca")]
        public double Capacity { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("e")]
        public double ErgonomicsModifierPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ms")]
        public double MovementSpeedModifierPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("t")]
        public double TurningSpeedModifierPercentage { get; set; }
    }
}
