﻿using System;
using System.Collections.Generic;
using System.Text.Json;
using TotovBuilder.Model.Abstractions.Items;
using TotovBuilder.Model.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="ModSlot"/> interface.
    /// </summary>
    public sealed class ModSlotJsonConverter : ReducedJsonConverter<ModSlot, ModSlot>
    {
        /// <summary>
        /// List of functions indicating whether the associated property must be excluded from the serialization.
        /// </summary>
        public static readonly Dictionary<string, Func<ModSlot, bool>> PropertyExclusionConditions = new Dictionary<string, Func<ModSlot, bool>>()
        {
            { nameof(ModSlot.CompatibleItemIds), c => c.CompatibleItemIds.Length == 0 },
            { nameof(ModSlot.MaxStackableAmount), c => c.MaxStackableAmount == 1 },
            { nameof(ModSlot.Required), c => !c.Required }
        };

        /// <summary>
        /// List of functions for customizing the value used for serializing the associated property.
        /// </summary>
        public static readonly Dictionary<string, Func<ModSlot, object?>> PropertyValuesObtentions = new Dictionary<string, Func<ModSlot, object?>>()
        {
            { nameof(ModSlot.Required), a => 1 }
        };
        
        /// <inheritdoc/>
        public override ModSlot? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            ModSlot modSlot = new ModSlot();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    break;
                }

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string? propertyName = reader.GetString();

                    // Read the property value based on the property name
                    switch (propertyName)
                    {
                        case "i":
                            modSlot.CompatibleItemIds = JsonSerializer.Deserialize<string[]>(ref reader, options)!;
                            break;
                        case "a":
                            modSlot.MaxStackableAmount = JsonSerializer.Deserialize<double>(ref reader, options);
                            break;
                        case "n":
                            modSlot.Name = JsonSerializer.Deserialize<string>(ref reader, options)!;
                            break;
                        case "r":
                            modSlot.Required = JsonSerializer.Deserialize<bool>(ref reader, options);
                            break;
                    }
                }
            }
            
            return modSlot;
        }

        /// <inheritdoc/>
        protected override Dictionary<string, Func<ModSlot, bool>> GetPropertyExclusionConditions()
        {
            return PropertyExclusionConditions;
        }

        /// <inheritdoc/>
        protected override Dictionary<string, Func<ModSlot, object?>> GetPropertyValueObtentions()
        {
            return PropertyValuesObtentions;
        }
    }
}