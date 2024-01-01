using System;
using System.Collections.Generic;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="IWearable"/> interface.
    /// </summary>
    /// <typeparam name="TInterface">Type of the interface implemented by the item.</typeparam>
    /// <typeparam name="TClass">Type of the item.</typeparam>
    public sealed class WearableJsonConverter<TInterface, TClass> : ReducedJsonConverter<TInterface, TClass>
        where TInterface : IWearable
        where TClass : class, TInterface
    {
        /// <summary>
        /// List of functions indicating whether the associated property must be excluded from the serialization.
        /// </summary>
        public static readonly Dictionary<string, Func<TInterface, bool>> PropertyExclusionConditions = new Dictionary<string, Func<TInterface, bool>>()
        {
            { nameof(IWearable.ErgonomicsPercentageModifier), v => v.ErgonomicsPercentageModifier == 0 },
            { nameof(IWearable.MovementSpeedPercentageModifier), v => v.MovementSpeedPercentageModifier == 0 },
            { nameof(IWearable.TurningSpeedPercentageModifier), v => v.TurningSpeedPercentageModifier == 0 }
        };
    }
}
