using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents eyewear.
    /// </summary>
    public class Eyewear : Item, IEyewear
    {
        /// <inheritdoc/>
        [JsonPropertyName("bp")]
        public double BlindnessProtectionPercentage { get; set; }
    }
}
