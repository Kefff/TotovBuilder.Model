using System;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents ammunition.
    /// </summary>
    public class Ammunition : Item, IAmmunition
    {
        /// <inheritdoc/>
        [JsonPropertyName("ac")]
        public double AccuracyPercentageModifier { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ad")]
        public double ArmorDamagePercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ap")]
        public double[] ArmorPenetrations { get; set; } = Array.Empty<double>();

        /// <inheritdoc/>
        [JsonPropertyName("b")]
        public bool Blinding { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ca")]
        public string Caliber { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("d")]
        public double DurabilityBurnPercentageModifier { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("f")]
        public double FleshDamage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("fr")]
        public double FragmentationChancePercentage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("h")]
        public double HeavyBleedingPercentageChance { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("l")]
        public double LightBleedingPercentageChance { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("pp")]
        public double PenetrationPower { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("pr")]
        public double Projectiles { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("r")]
        public double RecoilPercentageModifier { get; set; }

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
