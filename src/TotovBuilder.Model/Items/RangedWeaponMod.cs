using System;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a ranged weapon mod.
    /// </summary>
    public class RangedWeaponMod : Item, IRangedWeaponMod
    {
        /// <inheritdoc/>
        [JsonPropertyName("ac")]
        public double AccuracyPercentageModifier { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("bi")]
        public string? BaseItemId { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("dp")]
        public string? DefaultPresetId { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("e")]
        public double ErgonomicsModifier { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("mo")]
        public ModSlot[] ModSlots { get; set; } = Array.Empty<ModSlot>();

        /// <inheritdoc/>
        [JsonPropertyName("r")]
        public double RecoilPercentageModifier { get; set; }
    }
}
