using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Utils
{
    /// <summary>
    /// Represents a localized items.
    /// </summary>
    public class LocalizedItems
    {
        /// <summary>
        /// Language.
        /// </summary>
        public string Language { get; set; } = string.Empty;

        /// <summary>
        /// Items.
        /// </summary>
        public IItem[] Items { get; set; } = [];
    }
}
