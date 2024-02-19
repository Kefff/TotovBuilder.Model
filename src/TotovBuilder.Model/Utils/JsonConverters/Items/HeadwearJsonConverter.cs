using System;
using System.Collections.Generic;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="IHeadwear"/> interface.
    /// </summary>
    /// <typeparam name="TInterface">Type of the interface implemented by the item.</typeparam>
    /// <typeparam name="TClass">Type of the item.</typeparam>
    public sealed class HeadwearJsonConverter<TInterface, TClass> : ReducedJsonConverter<TInterface, TClass>
        where TInterface : IHeadwear
        where TClass : class, TInterface
    {
        /// <summary>
        /// List of functions indicating whether the associated property must be excluded from the serialization.
        /// </summary>
        public static readonly Dictionary<string, Func<TInterface, bool>> PropertyExclusionConditions = new Dictionary<string, Func<TInterface, bool>>()
        {
            { nameof(IHeadwear.BlocksHeadphones), h => !h.BlocksHeadphones },
            { nameof(IHeadwear.Deafening), h => h.Deafening == "None" },
            { nameof(IHeadwear.RicochetChance), a => a.RicochetChance == string.Empty }
        };

        /// <summary>
        /// List of functions for customizing the value used for serializing the associated property.
        /// </summary>
        public static readonly Dictionary<string, Func<TInterface, object?>> PropertyValuesObtentions = new Dictionary<string, Func<TInterface, object?>>()
        {
            { nameof(IHeadwear.BlocksHeadphones), a => 1 }
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

        /// <inheritdoc/>
        protected override Dictionary<string, Func<TInterface, object?>> GetPropertyValueObtentions()
        {
            return PropertyValuesObtentions;
        }
    }
}
