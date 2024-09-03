using System;
using System.Collections.Generic;
using System.Linq;
using TotovBuilder.Model.Abstractions.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="IAmmunition"/> interface.
    /// </summary>
    /// <typeparam name="TInterface">Type of the interface implemented by the item.</typeparam>
    /// <typeparam name="TClass">Type of the item.</typeparam>
    public sealed class AmmunitionJsonConverter<TInterface, TClass> : ReducedJsonConverter<TInterface, TClass>
        where TInterface : IAmmunition
        where TClass : class, TInterface
    {
        /// <summary>
        /// List of functions indicating whether the associated property must be excluded from the serialization.
        /// </summary>
        public static readonly Dictionary<string, Func<TInterface, bool>> PropertyExclusionConditions = new()
        {
            { nameof(IAmmunition.AccuracyModifierPercentage), a => a.AccuracyModifierPercentage == 0 },
            { nameof(IAmmunition.ArmorDamagePercentage), a => a.ArmorDamagePercentage == 0 },
            { nameof(IAmmunition.ArmorPenetrations), a => a.ArmorPenetrations.Length == 0 || a.ArmorPenetrations.All(ap => ap == 0) },
            { nameof(IAmmunition.Blinding), a => !a.Blinding },
            { nameof(IAmmunition.DurabilityBurnModifierPercentage), a => a.DurabilityBurnModifierPercentage == 0 },
            { nameof(IAmmunition.FleshDamage), a => a.FleshDamage == 0 },
            { nameof(IAmmunition.FragmentationChance), a => a.FragmentationChance == 0 },
            { nameof(IAmmunition.HeavyBleedingChance), a => a.HeavyBleedingChance == 0 },
            { nameof(IAmmunition.LightBleedingChance), a => a.LightBleedingChance == 0 },
            { nameof(IAmmunition.PenetrationPower), a => a.PenetrationPower == 0 },
            { nameof(IAmmunition.Projectiles), a => a.Projectiles == 1 },
            { nameof(IAmmunition.RecoilModifier), a => a.RecoilModifier == 0 },
            { nameof(IAmmunition.Subsonic), a => !a.Subsonic },
            { nameof(IAmmunition.Tracer), a => !a.Tracer },

        };

        /// <summary>
        /// List of functions for customizing the value used for serializing the associated property.
        /// </summary>
        public static readonly Dictionary<string, Func<TInterface, object?>> PropertyValuesObtentions = new()
        {
            { nameof(IAmmunition.Blinding), a => 1 },
            { nameof(IAmmunition.Subsonic), a => 1 },
            { nameof(IAmmunition.Tracer), a => 1 }
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
