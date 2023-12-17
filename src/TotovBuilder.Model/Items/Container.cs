using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents an item that can contain other items.
    /// </summary>
    public class Container : Item, IContainer
    {
        /// <inheritdoc/>
        [JsonPropertyName("ca")]
        public double Capacity { get; set; }
    }
}
