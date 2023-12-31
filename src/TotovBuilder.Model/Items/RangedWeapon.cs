using System;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a ranged weapon.
    /// </summary>
    [JsonConverter(typeof(RangedWeaponJsonConverter<IRangedWeapon, RangedWeapon>))]
    public class RangedWeapon : Item, IRangedWeapon
    {
        /// <inheritdoc/>
        [JsonPropertyName("bi")]
        public string? BaseItemId { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ca")]
        public string Caliber { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("dp")]
        public string? DefaultPresetId { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("e")]
        public double Ergonomics { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("fm")]
        public string[] FireModes { get; set; } = Array.Empty<string>();

        /// <inheritdoc/>
        [JsonPropertyName("r")]
        public double FireRate { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("h")]
        public double HorizontalRecoil { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ma")]
        public double? MinuteOfAngle { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("mo")]
        public ModSlot[] ModSlots { get; set; } = Array.Empty<ModSlot>();

        /// <inheritdoc/>
        [JsonPropertyName("v")]
        public double VerticalRecoil { get; set; }
    }
}
