using System;
using System.Collections.Generic;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="IGrenade"/> interface.
    /// </summary>
    /// <typeparam name="TInterface">Type of the interface implemented by the item.</typeparam>
    /// <typeparam name="TClass">Type of the item.</typeparam>
    public sealed class GrenadeJsonConverter<TInterface, TClass> : ReducedJsonConverter<TInterface, TClass>
        where TInterface : IGrenade
        where TClass : class, TInterface
    {
        /// <summary>
        /// List of functions indicating whether the associated property must be excluded from the serialization.
        /// </summary>
        public static readonly Dictionary<string, Func<TInterface, bool>> PropertyExclusionConditions = new()
        {
            { nameof(IGrenade.FragmentsAmount), g => g.FragmentsAmount == 0 },
            { nameof(IGrenade.MaximumExplosionRange), g => g.MaximumExplosionRange == 0 },
            { nameof(IGrenade.MinimumExplosionRange), g => g.MinimumExplosionRange == 0 }
        };

        /// <inheritdoc/>
        protected override Dictionary<string, Func<TInterface, bool>> GetPropertyExclusionConditions()
        {
            return ConcatenateDictionaries(
                PropertyExclusionConditions,
                ItemJsonConverter<TInterface, TClass>.PropertyExclusionConditions);
        }
    }
}
