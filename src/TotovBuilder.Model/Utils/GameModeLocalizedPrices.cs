using TotovBuilder.Model.Items;

namespace TotovBuilder.Model.Utils
{
    /// <summary>
    /// Represents a localized prices for a game mode.
    /// </summary>
    public class GameModeLocalizedPrices
    {
        /// <summary>
        /// Game mode.
        /// </summary>
        public string GameMode { get; set; } = string.Empty;

        /// <summary>
        /// Language.
        /// </summary>
        public string Language { get; set; } = string.Empty;

        /// <summary>
        /// Items.
        /// </summary>
        public Price[] Prices { get; set; } = [];
    }
}
