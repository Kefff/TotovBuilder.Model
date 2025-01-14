﻿namespace TotovBuilder.Model.Configuration
{
    /// <summary>
    /// Represents a merchant.
    /// </summary>
    public class Merchant
    {
        /// <summary>
        /// Maximum reachable reputation level.
        /// </summary>
        public int MaxLevel { get; set; }

        /// <summary>
        /// Minimum reputation level.
        /// </summary>
        public int MinLevel { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Order of appearance.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Indicates whether the merchant must be shown in the merchants filter.
        /// </summary>
        public bool ShowInFilter { get; set; } = false;
    }
}
