using System;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents headwear.
    /// </summary>
    [JsonConverter(typeof(HeadwearJsonConverter<IHeadwear, Headwear>))]
    public class Headwear : Item, IHeadwear
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
        [JsonPropertyName("h")]
        public bool BlocksHeadphones { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("de")]
        public string Deafening { get; set; } = "None";

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
        [JsonPropertyName("r")]
        public string RicochetChance { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("t")]
        public double TurningSpeedModifierPercentage { get; set; }
    }
}
