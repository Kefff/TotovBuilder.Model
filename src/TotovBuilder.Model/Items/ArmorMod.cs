using System;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents an armor mod.
    /// </summary>
    public class ArmorMod : Item, IArmorMod
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
        public double ErgonomicsPercentageModifier { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ma")]
        public string Material { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("mo")]
        public ModSlot[] ModSlots { get; set; } = Array.Empty<ModSlot>();

        /// <inheritdoc/>
        [JsonPropertyName("ms")]
        public double MovementSpeedPercentageModifier { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("r")]
        public string RicochetChance { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("t")]
        public double TurningSpeedPercentageModifier { get; set; }
    }
}
