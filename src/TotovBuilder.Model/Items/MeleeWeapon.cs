using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a melee weapon.
    /// </summary>
    public class MeleeWeapon : Item, IMeleeWeapon
    {
        /// <inheritdoc/>
        [JsonPropertyName("ch")]
        public double ChopDamage { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("r")]
        public double HitRadius { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("st")]
        public double StabDamage { get; set; }
    }
}
