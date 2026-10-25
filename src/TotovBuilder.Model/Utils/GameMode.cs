namespace TotovBuilder.Model.Utils
{
    /// <summary>
    /// Represents a game mode.
    /// </summary>
    public class GameMode
    {
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Value to use when make an API request.
        /// </summary>
        public string ApiQueryValue { get; set; } = string.Empty;

        /// <summary>
        /// Name of the game mode whose prices are used when this game mode is not available.
        /// Only temporary game modes, like seasons, have one.
        /// </summary>
        public string? FallbackGameModeName { get; set; }
    }
}
