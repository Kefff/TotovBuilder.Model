using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a grenade.
    /// </summary>
    [JsonConverter(typeof(GrenadeJsonConverter<IGrenade, Grenade>))]
    public class Grenade : Item, IGrenade
    {
        /// <inheritdoc/>
        [JsonPropertyName("b")]
        public bool Blinding { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("d")]
        public double ExplosionDelay { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("f")]
        public double FragmentsAmount { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ip")]
        public bool Impact { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ma")]
        public double MaximumExplosionRange { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("mi")]
        public double MinimumExplosionRange { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("sm")]
        public bool Smoke { get; set; }
    }
}
