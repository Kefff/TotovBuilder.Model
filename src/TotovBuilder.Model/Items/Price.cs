using System;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Configuration;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a price.
    /// </summary>
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
}
