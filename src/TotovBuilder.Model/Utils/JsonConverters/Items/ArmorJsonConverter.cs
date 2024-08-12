using System;
using System.Collections.Generic;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="IArmor"/> interface.
    /// </summary>
    /// <typeparam name="TInterface">Type of the interface implemented by the item.</typeparam>
    /// <typeparam name="TClass">Type of the item.</typeparam>
    public sealed class ArmorJsonConverter<TInterface, TClass> : ReducedJsonConverter<TInterface, TClass>
        where TInterface : IArmor
        where TClass : class, TInterface
    {
        /// <summary>
        /// List of functions indicating whether the associated property must be excluded from the serialization.
        /// </summary>
        public static readonly Dictionary<string, Func<TInterface, bool>> PropertyExclusionConditions = new()
        {
            { nameof(IArmor.ArmorClass), a => a.ArmorClass == 0 },
            { nameof(IArmor.ArmoredAreas), a => a.ArmoredAreas.Length == 0 },
            { nameof(IArmor.Durability), a => a.Durability == 0 },
            { nameof(IArmor.Material), a => a.Material == string.Empty }
        };

        /// <inheritdoc/>
        protected override Dictionary<string, Func<TInterface, bool>> GetPropertyExclusionConditions()
        {
            return ConcatenateDictionaries(
                PropertyExclusionConditions,
                ItemJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                ModdableJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                WearableJsonConverter<TInterface, TClass>.PropertyExclusionConditions);
        }
    }
}
