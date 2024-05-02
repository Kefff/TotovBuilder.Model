using System;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a ranged weapon mod.
    /// </summary>
    [JsonConverter(typeof(RangedWeaponModJsonConverter<IRangedWeaponMod, RangedWeaponMod>))]
    public class RangedWeaponMod : Item, IRangedWeaponMod
    {
        /// <inheritdoc/>
        [JsonPropertyName("ac")]
        public double AccuracyModifierPercentage { get; set; }

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
        public double RecoilModifierPercentage { get; set; }
    }
}
