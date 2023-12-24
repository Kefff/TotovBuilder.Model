using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TotovBuilder.Model.Utils
{
    /// <summary>
    /// Represent the base class for a JSON converter that exclude some properties under certain conditions.
    /// Mainly used for avoiding serializing properties that are set with their default value or empty arrays in order to save space.
    /// </summary>
    /// <typeparam name="T">Type of the element to serialize.</typeparam>
    public abstract class ReducedSerializationBaseConverter<T> : JsonConverter<T>
    {
        /// <summary>
        /// List of functions indicating whether the associated property must be excluded from the serialization.
        /// </summary>
        protected abstract Dictionary<string, Func<T, bool>> PropertyExclusionConditions { get; }

        /// <summary>
        /// List of functions for customizing the value used for serializing the associated property.
        /// </summary>
        protected abstract Dictionary<string, Func<T, object?>> PropertyValuesObtentions { get; }

        /// <inheritdoc/>
        [ExcludeFromCodeCoverage]
        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Should never be called
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, T objectToSerialize, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            foreach (PropertyInfo propertyToSerialize in objectToSerialize!.GetType().GetProperties())
            {
                bool isExcluded = PropertyExclusionConditions.TryGetValue(propertyToSerialize.Name, out Func<T, bool>? propertyExclusionCondition)
                    && propertyExclusionCondition(objectToSerialize);

                if (isExcluded)
                {
                    continue;
                }

                string propertyName = propertyToSerialize.GetCustomAttribute<JsonPropertyNameAttribute>()!.Name;
                object? propertyValueToSerialize;

                if (PropertyValuesObtentions.TryGetValue(propertyToSerialize.Name, out Func<T, object?>? propertyValuesObtention))
                {
                    propertyValueToSerialize = propertyValuesObtention(objectToSerialize);
                }
                else
                {
                    propertyValueToSerialize = propertyToSerialize.GetValue(objectToSerialize);
                }
                
                writer.WritePropertyName(propertyName);
                JsonSerializer.Serialize(writer, propertyValueToSerialize, options);
            }

            writer.WriteEndObject();
        }
    }
}
