namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents an Escape From Tarkov game mode.
    /// </summary>
    public class GameMode
    {
        /// <summary>
        /// Name.
        /// </summary>
        /// <remarks>
        /// No name corresponds to the default game mode (classic PVP).
        /// </remarks>
        public string? Name { get; set; } = null;

        /// <summary>
        /// Value to use as the game mode in queries made to the API.
        /// </summary>
        public string QueryValue { get; set; } = string.Empty;
    }
}
