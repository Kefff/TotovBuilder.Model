namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents an Escape From Tarkov language.
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Name.
        /// </summary>
        /// <remarks>
        /// No name corresponds to the default language (english).
        /// </remarks>
        public string? Name { get; set; } = null;

        /// <summary>
        /// Value to use as the game mode in queries made to the API.
        /// </summary>
        public string QueryValue { get; set; } = string.Empty;
    }
}
