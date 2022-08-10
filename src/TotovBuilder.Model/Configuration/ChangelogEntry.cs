using System;

namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents a changelog entry.
    /// </summary>
    public class ChangelogEntry
    {
        /// <summary>
        /// Changes.
        /// </summary>
        public ChangelogChange[] Changes { get; set; } = Array.Empty<ChangelogChange>();

        /// <summary>
        /// Date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Version.
        /// </summary>
        public string Version { get; set; } = string.Empty;
    }
}
