using System;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a magazine.
    /// </summary>
    [JsonConverter(typeof(MagazineJsonConverter<IMagazine, Magazine>))]
    public class Magazine : Item, IMagazine
    {
        /// <inheritdoc/>
        [JsonPropertyName("aa")]
        public string[] AcceptedAmmunitionIds { get; set; } = Array.Empty<string>();

        /// <inheritdoc/>
        [JsonPropertyName("bi")]
        public string? BaseItemId { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ca")]
        public double Capacity { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("cs")]
        public double CheckSpeedModifierPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("dp")]
        public string? DefaultPresetId { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("e")]
        public double ErgonomicsModifier { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("l")]
        public double LoadSpeedModifierPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ma")]
        public double MalfunctionPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("mo")]
        public ModSlot[] ModSlots { get; set; } = Array.Empty<ModSlot>();
    }
}
