using System;
using System.Collections.Generic;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="IRangedWeaponMod"/> interface.
    /// </summary>
    /// <typeparam name="TInterface">Type of the interface implemented by the item.</typeparam>
    /// <typeparam name="TClass">Type of the item.</typeparam>
    public sealed class RangedWeaponModJsonConverter<TInterface, TClass> : ReducedJsonConverter<TInterface, TClass>
        where TInterface : IRangedWeaponMod
        where TClass : class, TInterface
    {
        /// <summary>
        /// List of functions indicating whether the associated property must be excluded from the serialization.
        /// </summary>
        public static readonly Dictionary<string, Func<TInterface, bool>> PropertyExclusionConditions = new()
        {
            { nameof(IRangedWeaponMod.AccuracyModifierPercentage), rwm => rwm.AccuracyModifierPercentage == 0 },
            { nameof(IRangedWeaponMod.RecoilModifierPercentage), rwm => rwm.RecoilModifierPercentage == 0 }
        };

        /// <inheritdoc/>
        protected override Dictionary<string, Func<TInterface, bool>> GetPropertyExclusionConditions()
        {
            return ConcatenateDictionaries(
                PropertyExclusionConditions,
                ItemJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                ModdableJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                ModJsonConverter<TInterface, TClass>.PropertyExclusionConditions);
        }
    }
}
