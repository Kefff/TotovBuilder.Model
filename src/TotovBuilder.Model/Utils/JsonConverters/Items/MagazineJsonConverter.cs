using System;
using System.Collections.Generic;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="IMagazine"/> interface.
    /// </summary>
    /// <typeparam name="TInterface">Type of the interface implemented by the item.</typeparam>
    /// <typeparam name="TClass">Type of the item.</typeparam>
    public sealed class MagazineJsonConverter<TInterface, TClass> : ReducedJsonConverter<TInterface, TClass>
        where TInterface : IMagazine
        where TClass : class, TInterface
    {
        /// <summary>
        /// List of functions indicating whether the associated property must be excluded from the serialization.
        /// </summary>
        public static readonly Dictionary<string, Func<TInterface, bool>> PropertyExclusionConditions = new Dictionary<string, Func<TInterface, bool>>()
        {
            { nameof(IMagazine.CheckSpeedPercentageModifier), m => m.CheckSpeedPercentageModifier == 0 },
            { nameof(IMagazine.LoadSpeedPercentageModifier), m => m.LoadSpeedPercentageModifier == 0 },
            { nameof(IMagazine.MalfunctionPercentage), m => m.MalfunctionPercentage == 0 }
        };

        /// <inheritdoc/>
        protected override Dictionary<string, Func<TInterface, bool>> GetPropertyExclusionConditions()
        {
            return ConcatenateDictionaries(
                PropertyExclusionConditions,
                ItemJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                ContainerJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                ModJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                ModdableJsonConverter<TInterface, TClass>.PropertyExclusionConditions);
        }
    }
}
