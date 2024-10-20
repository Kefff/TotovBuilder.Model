﻿using System;
using System.Collections.Generic;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="IVest"/> interface.
    /// </summary>
    /// <typeparam name="TInterface">Type of the interface implemented by the item.</typeparam>
    /// <typeparam name="TClass">Type of the item.</typeparam>
    public sealed class VestJsonConverter<TInterface, TClass> : ReducedJsonConverter<TInterface, TClass>
        where TInterface : IVest
        where TClass : class, TInterface
    {
        /// <inheritdoc/>
        protected override Dictionary<string, Func<TInterface, bool>> GetPropertyExclusionConditions()
        {
            return ConcatenateDictionaries(
                ItemJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                ArmorJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                ContainerJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                ModdableJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                WearableJsonConverter<TInterface, TClass>.PropertyExclusionConditions);
        }
    }
}
