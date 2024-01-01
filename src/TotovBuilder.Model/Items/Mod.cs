using System;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a mod.
    /// </summary>
    [JsonConverter(typeof(ModJsonConverter<IMod, Mod>))]
    public class Mod : Item, IMod
    {
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
    }
}
