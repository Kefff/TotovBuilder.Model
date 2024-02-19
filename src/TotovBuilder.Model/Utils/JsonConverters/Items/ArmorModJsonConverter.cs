using System;
using System.Collections.Generic;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="IArmorMod"/> interface.
    /// </summary>
    /// <typeparam name="TInterface">Type of the interface implemented by the item.</typeparam>
    /// <typeparam name="TClass">Type of the item.</typeparam>
    public sealed class ArmorModJsonConverter<TInterface, TClass> : ReducedJsonConverter<TInterface, TClass>
        where TInterface : IArmorMod
        where TClass : class, TInterface
    {
        /// <summary>
        /// List of functions indicating whether the associated property must be excluded from the serialization.
        /// </summary>
        public static readonly Dictionary<string, Func<TInterface, bool>> PropertyExclusionConditions = new Dictionary<string, Func<TInterface, bool>>()
        {
            { nameof(IArmorMod.BlindnessProtectionPercentage), am => am.BlindnessProtectionPercentage == 0 },
        };

        /// <inheritdoc/>
        protected override Dictionary<string, Func<TInterface, bool>> GetPropertyExclusionConditions()
        {
            return ConcatenateDictionaries(
                PropertyExclusionConditions,
                ArmorJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                ItemJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                ModdableJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                WearableJsonConverter<TInterface, TClass>.PropertyExclusionConditions);
        }
    }
}
