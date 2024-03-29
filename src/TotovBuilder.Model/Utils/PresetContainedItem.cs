﻿using TotovBuilder.Model.Items;

namespace TotovBuilder.Model.Utils
{
    /// <summary>
    /// Represents a preset contained item.
    /// </summary>
    public class PresetContainedItem
    {
        /// <summary>
        /// Item.
        /// </summary>
        public Item Item { get; set; }

        /// <summary>
        /// Quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresetContainedItem"/> class.
        /// </summary>
        /// <param name="item">Item.</param>
        /// <param name="quantity">Quantity.</param>
        public PresetContainedItem(Item item, int quantity = 1)
        {
            Item = item;
            Quantity = quantity;
        }
    }
}
