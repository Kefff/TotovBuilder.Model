using System;
using System.Collections.Generic;

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
        public Dictionary<string, string>[] Changes { get; set; } = [];

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
