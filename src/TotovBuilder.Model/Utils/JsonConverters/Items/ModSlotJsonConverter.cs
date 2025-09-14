using System;
using System.Collections.Generic;
using TotovBuilder.Model.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="ModSlot"/> interface.
    /// </summary>
    public sealed class ModSlotJsonConverter : ReducedJsonConverter<ModSlot, ModSlot>
    {
        /// <summary>
        /// List of functions indicating whether the associated property must be excluded from the serialization.
        /// </summary>
        public static readonly Dictionary<string, Func<ModSlot, bool>> PropertyExclusionConditions = new()
        {
            { nameof(ModSlot.Caption), ms => string.IsNullOrWhiteSpace(ms.Caption) },
            { nameof(ModSlot.CompatibleItemIds), ms => ms.CompatibleItemIds.Length == 0 },
            { nameof(ModSlot.MaxStackableAmount), ms => ms.MaxStackableAmount == 1 },
            { nameof(ModSlot.Required), ms => !ms.Required }
        };

        /// <summary>
        /// List of functions for customizing the value used for serializing the associated property.
        /// </summary>
        public static readonly Dictionary<string, Func<ModSlot, object?>> PropertyValuesObtentions = new()
        {
            { nameof(ModSlot.Required), ms => 1 }
        };

        /// <inheritdoc/>
        protected override Dictionary<string, Func<ModSlot, bool>> GetPropertyExclusionConditions()
        {
            return PropertyExclusionConditions;
        }

        /// <inheritdoc/>
        protected override Dictionary<string, Func<ModSlot, object?>> GetPropertyValueObtentions()
        {
            return PropertyValuesObtentions;
        }
    }
}
