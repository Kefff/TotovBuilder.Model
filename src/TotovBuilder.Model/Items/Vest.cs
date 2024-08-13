using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a vest.
    /// </summary>
    [JsonConverter(typeof(VestJsonConverter<IVest, Vest>))]
    public class Vest : Item, IVest
    {
        /// <inheritdoc/>
        [JsonPropertyName("ac")]
        public double ArmorClass { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("aa")]
        public string[] ArmoredAreas { get; set; } = [];

        /// <inheritdoc/>
        [JsonPropertyName("bi")]
        public string? BaseItemId { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("bp")]
        public double BlindnessProtectionPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("dp")]
        public string? DefaultPresetId { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("d")]
        public double Durability { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("e")]
        public double ErgonomicsModifierPercentage { get; set; }

        [JsonPropertyName("ma")]
        public string Material { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("mo")]
        public ModSlot[] ModSlots { get; set; } = [];

        /// <inheritdoc/>
        [JsonPropertyName("ms")]
        public double MovementSpeedModifierPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("t")]
        public double TurningSpeedModifierPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ca")]
        public double Capacity { get; set; }
    }
}
