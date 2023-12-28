using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents an item that can contain other items.
    /// </summary>
    [JsonConverter(typeof(ContainerJsonConverter<IContainer, Container>))]
    public class Container : Item, IContainer
    {
        /// <inheritdoc/>
        [JsonPropertyName("ca")]
        public double Capacity { get; set; }
    }
}
