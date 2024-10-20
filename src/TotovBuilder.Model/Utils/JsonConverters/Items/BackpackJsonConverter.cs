﻿using System;
using System.Collections.Generic;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="IBackpack"/> interface.
    /// </summary>
    public sealed class BackpackJsonConverter<TInterface, TClass> : ReducedJsonConverter<TInterface, TClass>
        where TInterface : IBackpack
        where TClass : class, TInterface
    {
        /// <inheritdoc/>
        protected override Dictionary<string, Func<TInterface, bool>> GetPropertyExclusionConditions()
        {
            return ConcatenateDictionaries(
                ContainerJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                ItemJsonConverter<TInterface, TClass>.PropertyExclusionConditions,
                WearableJsonConverter<TInterface, TClass>.PropertyExclusionConditions);
        }
    }
}
