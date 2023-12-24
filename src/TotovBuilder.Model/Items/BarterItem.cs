using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Utils;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a barter item.
    /// </summary>
    [JsonConverter(typeof(BarterItemJsonConverter))]
    public class BarterItem
    {
        /// <summary>
        /// ID.
        /// </summary>
        [JsonPropertyName("i")]
        public string ItemId { get; set; } = string.Empty;

        /// <summary>
        /// Quantity.
        /// </summary>
        [JsonPropertyName("q")]
        public double Quantity { get; set; }
    }

    /// <summary>
    /// Represents a JSON converter for the <see cref="BarterItem"/> class.
    /// </summary>
    public class BarterItemJsonConverter : ReducedSerializationBaseConverter<BarterItem>
    {
        /// <inheritdoc/>
        protected override Dictionary<string, Func<BarterItem, bool>> PropertyExclusionConditions { get; } = new Dictionary<string, Func<BarterItem, bool>>()
        {
            { nameof(BarterItem.Quantity), bi => bi.Quantity == 1 }
        };
    }
}
