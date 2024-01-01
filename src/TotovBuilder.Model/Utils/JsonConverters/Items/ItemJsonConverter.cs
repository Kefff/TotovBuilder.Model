using System;
using System.Collections.Generic;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="IItem"/> class.
    /// </summary>
    /// <typeparam name="TInterface">Type of the interface implemented by the item.</typeparam>
    /// <typeparam name="TClass">Type of the item.</typeparam>
    public sealed class ItemJsonConverter<TInterface, TClass> : ReducedJsonConverter<TInterface, TClass>
        where TInterface : IItem
        where TClass : class, TInterface
    {
        /// <summary>
        /// List of functions indicating whether the associated property must be excluded from the serialization.
        /// </summary>
        public static readonly Dictionary<string, Func<TInterface, bool>> PropertyExclusionConditions = new Dictionary<string, Func<TInterface, bool>>()
        {
            { nameof(IItem.CategoryId), i => i.CategoryId == "other" },
            { nameof(IItem.ConflictingItemIds), i => i.ConflictingItemIds.Length == 0 },
            { nameof(IItem.MaxStackableAmount), i => i.MaxStackableAmount == 1 },
            { nameof(IItem.Weight), i => i.Weight == 0 }
        };

        /// <inheritdoc/>
        protected override Dictionary<string, Func<TInterface, bool>> GetPropertyExclusionConditions()
        {
            return PropertyExclusionConditions;
        }
    }
}
