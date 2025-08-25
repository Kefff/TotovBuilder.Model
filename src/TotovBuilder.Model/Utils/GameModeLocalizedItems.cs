using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Utils
{
    /// <summary>
    /// Represents a localized items for a game mode.
    /// </summary>
    public class GameModeLocalizedItems
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
