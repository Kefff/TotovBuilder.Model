using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TotovBuilder.Model.Utils.JsonConverters
{
    /// <summary>
    /// Represent the base class for a JSON converter that exclude some properties under certain conditions.
    /// Mainly used for avoiding serializing properties that are set with their default value or empty arrays in order to save space.
    /// </summary>
    /// <typeparam name="TInterface">Type of the interface of the class to serialize.</typeparam>
    /// <typeparam name="TClass">Type of the class to serialize.</typeparam>
    public abstract class ReducedJsonConverter<TInterface, TClass> : JsonConverter<TClass>
        where TClass : class, TInterface
    {
        /// <inheritdoc/>
        [ExcludeFromCodeCoverage(Justification = "Should never be called.")]
        public override TClass? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, TClass objectToSerialize, JsonSerializerOptions options)
        {
            Dictionary<string, Func<TInterface, bool>> propertyExclusionConditions = GetPropertyExclusionConditions();
            Dictionary<string, Func<TInterface, object?>> propertyValuesObtentions = GetPropertyValueObtentions();

            writer.WriteStartObject();

            foreach (PropertyInfo propertyToSerialize in objectToSerialize!.GetType().GetProperties())
            {
                bool isExcluded = propertyExclusionConditions.TryGetValue(propertyToSerialize.Name, out Func<TInterface, bool>? propertyExclusionCondition)
                    && propertyExclusionCondition(objectToSerialize);

                if (isExcluded)
                {
                    continue;
                }

                string propertyName = propertyToSerialize.GetCustomAttribute<JsonPropertyNameAttribute>()!.Name;
                object? propertyValueToSerialize;

                if (propertyValuesObtentions.TryGetValue(propertyToSerialize.Name, out Func<TInterface, object?>? propertyValuesObtention))
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

        /// <summary>
        /// Gets the list of functions indicating whether the associated property must be excluded from the serialization.
        /// </summary>
        /// <returns>List of functions indicating whether the associated property must be excluded from the serialization.</returns>
        protected virtual Dictionary<string, Func<TInterface, bool>> GetPropertyExclusionConditions()
        {
            return [];
        }

        /// <summary>
        /// Gets the list of functions for customizing the value used for serializing the associated property.
        /// </summary>
        /// <returns>List of functions for customizing the value used for serializing the associated property.</returns>
        protected virtual Dictionary<string, Func<TInterface, object?>> GetPropertyValueObtentions()
        {
            return [];
        }

        /// <summary>
        /// Adds the entries of several dictionaries to a main dictionary.
        /// </summary>
        /// <typeparam name="TMainInterface">Type of the elements of the main dictionary.</typeparam>
        /// <typeparam name="TResult">Return type of the function of the result of the concatenation.</typeparam>
        /// <param name="firstDictionary">First dictionary.</param>
        /// <param name="secondDictionary">Second dictionary.</param>
        /// <returns>Concatenanted dictionaries.</returns>
        protected static Dictionary<string, Func<TMainInterface, TResult>> ConcatenateDictionaries<TMainInterface, TResult>(
            Dictionary<string, Func<TMainInterface, TResult>> mainDictionary,
            params Dictionary<string, Func<TMainInterface, TResult>>[] dictionariesToAppend)
        {
            foreach (Dictionary<string, Func<TMainInterface, TResult>> dictionaryToAppend in dictionariesToAppend)
            {
                mainDictionary = mainDictionary.Concat(dictionaryToAppend).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            }

            return mainDictionary;
        }
    }
}
