using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents ammunition.
    /// </summary>
    [JsonConverter(typeof(AmmunitionJsonConverter<IAmmunition, Ammunition>))]
    public class Ammunition : Item, IAmmunition
    {
        /// <inheritdoc/>
        [JsonPropertyName("ac")]
        public double AccuracyModifierPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ad")]
        public double ArmorDamagePercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ap")]
        public double[] ArmorPenetrations { get; set; } = [];

        /// <inheritdoc/>
        [JsonPropertyName("b")]
        public bool Blinding { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ca")]
        public string Caliber { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("d")]
        public double DurabilityBurnModifierPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("f")]
        public double FleshDamage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("fr")]
        public double FragmentationChance { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("h")]
        public double HeavyBleedingChance { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("l")]
        public double LightBleedingChance { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("pp")]
        public double PenetrationPower { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("p")]
        public double Projectiles { get; set; } = 1;

        /// <inheritdoc/>
        [JsonPropertyName("r")]
        public double RecoilModifierPercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("su")]
        public bool Subsonic { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("t")]
        public bool Tracer { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("v")]
        public double Velocity { get; set; }
    }
}
