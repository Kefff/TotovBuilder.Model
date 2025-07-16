using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents an item.
    /// </summary>
    [JsonConverter(typeof(ItemJsonConverter<IItem, Item>))]
    public class Item : IItem
    {
        /// <inheritdoc/>
        [JsonPropertyName("c")]
        public string CategoryId { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("co")]
        public string[] ConflictingItemIds { get; set; } = [];

        /// <inheritdoc/>
        [JsonPropertyName("ic")]
        public string IconLink { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("i")]
        public string Id { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("im")]
        public string ImageLink { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("a")]
        public double MaxStackableAmount { get; set; } = 1;

        /// <inheritdoc/>
        [JsonPropertyName("m")]
        public string MarketLink { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("n")]
        public string Name { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("s")]
        public string ShortName { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("w")]
        public double Weight { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("wi")]
        public string WikiLink { get; set; } = string.Empty;
    }
}
