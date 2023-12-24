using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Configuration;
using TotovBuilder.Model.Utils;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a price.
    /// </summary>
    [JsonConverter(typeof(PriceJsonConverter))]
    public class Price
    {
        /// <summary>
        /// Barter items.
        /// </summary>
        [JsonPropertyName("b")]
        public BarterItem[] BarterItems { get; set; } = Array.Empty<BarterItem>();

        /// <summary>
        /// Name of the currency.
        /// </summary>
        [JsonPropertyName("c")]
        public string CurrencyName { get; set; } = string.Empty;

        /// <summary>
        /// Item ID.
        /// </summary>
        [JsonPropertyName("i")]
        public string ItemId { get; set; } = string.Empty;

        /// <summary>
        /// Merchant.
        /// </summary>
        [JsonPropertyName("m")]
        public string Merchant { get; set; } = string.Empty;

        /// <summary>
        /// Merchant level.
        /// </summary>
        [JsonPropertyName("ml")]
        public double MerchantLevel { get; set; }

        /// <summary>
        /// ID of the quest unlocking the trade.
        /// </summary>
        [JsonPropertyName("q")]
        public Quest? Quest { get; set; }

        /// <summary>
        /// Value. 
        /// </summary>
        [JsonPropertyName("v")]
        public double Value { get; set; }

        /// <summary>
        /// Value in main currency
        /// </summary>
        [JsonPropertyName("vm")]
        public double ValueInMainCurrency { get; set; }
    }

    /// <summary>
    /// Represents a JSON converter for the <see cref="Price"/> class.
    /// </summary>
    public class PriceJsonConverter : ReducedSerializationBaseConverter<Price>
    {
        /// <inheritdoc/>
        protected override Dictionary<string, Func<Price, bool>> PropertyExclusionConditions { get; } = new Dictionary<string, Func<Price, bool>>()
        {
            { nameof(Price.BarterItems), p => p.BarterItems.Length == 0 },
            { nameof(Price.CurrencyName), p => p.CurrencyName == "RUB" },
            { nameof(Price.Quest), p => p.Quest == null },
            { nameof(Price.Merchant), ii => ii.Merchant == "flea-market" },
            { nameof(Price.MerchantLevel), ii => ii.MerchantLevel == 0 },
            { nameof(Price.Value), ii => ii.Value == 0 },
            { nameof(Price.ValueInMainCurrency), ii => ii.ValueInMainCurrency == 0 }
        };
    }
}