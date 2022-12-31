namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents a currency.
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// Icon name.
        /// </summary>
        public string IconName { get; set; } = string.Empty;

        /// <summary>
        /// ID of the item corresponding to the currency.
        /// </summary>
        public string? ItemId { get; set; }

        /// <summary>
        /// Indicates whether the currency is the main currency.
        /// </summary>
        public bool MainCurrency { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Value determining the position of the currency when a price containing multiple currencies is displayed.
        /// </summary>
        public int SortOrder { get; set; }
    }
}
