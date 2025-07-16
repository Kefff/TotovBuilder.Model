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
            { nameof(IGrenade.Impact), g => !g.Impact },
            { nameof(IGrenade.Blinding), g => !g.Blinding },
            { nameof(IGrenade.Smoke), g => !g.Smoke },
            { nameof(IGrenade.MaximumExplosionRange), g => g.MaximumExplosionRange == 0 },
            { nameof(IGrenade.MinimumExplosionRange), g => g.MinimumExplosionRange == 0 }
        };

        /// <summary>
        /// List of functions for customizing the value used for serializing the associated property.
        /// </summary>
        public static readonly Dictionary<string, Func<TInterface, object?>> PropertyValuesObtentions = new()
        {
            { nameof(IGrenade.Blinding), a => 1 },
            { nameof(IGrenade.Impact), a => 1 },
            { nameof(IGrenade.Smoke), a => 1 }
        };

        /// <inheritdoc/>
        protected override Dictionary<string, Func<TInterface, bool>> GetPropertyExclusionConditions()
        {
            return ConcatenateDictionaries(
                PropertyExclusionConditions,
                ItemJsonConverter<TInterface, TClass>.PropertyExclusionConditions);
        }

        /// <inheritdoc/>
        protected override Dictionary<string, Func<TInterface, object?>> GetPropertyValueObtentions()
        {
            return PropertyValuesObtentions;
        }
    }
}
