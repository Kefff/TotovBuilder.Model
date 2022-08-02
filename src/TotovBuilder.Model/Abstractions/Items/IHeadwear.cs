﻿namespace TotovBuilder.Model.Abstractions.Items
{
    /// <summary>
    /// Provides the functionalities of headwear.
    /// </summary>
    public interface IHeadwear : IArmor, IModdable
    {
        /// <summary>
        /// Indicates whether the headwear impairs earing or not.
        /// </summary>
        string Deafening { get; set; }
    }
}
