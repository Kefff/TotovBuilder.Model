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
    }
}
