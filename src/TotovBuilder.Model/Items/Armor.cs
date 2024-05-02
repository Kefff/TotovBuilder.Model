using System;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents an armor.
    /// </summary>
    [JsonConverter(typeof(ArmorJsonConverter<IArmor, Armor>))]
    public class Armor : Item, IArmor
    {
        /// <inheritdoc/>
        [JsonPropertyName("ac")]
        public double ArmorClass { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("aa")]
        public string[] ArmoredAreas { get; set; } = Array.Empty<string>();

        /// <inheritdoc/>
        [JsonPropertyName("bi")]
        public string? BaseItemId { get; set; }

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
        public ModSlot[] ModSlots { get; set; } = Array.Empty<ModSlot>();

        /// <inheritdoc/>
        [JsonPropertyName("ms")]
        public double MovementSpeedModifierPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("t")]
        public double TurningSpeedModifierPercentage { get; set; }
    }
}
