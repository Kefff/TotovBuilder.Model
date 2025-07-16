using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace TotovBuilder.Model.Test.Utils.JsonConverters
{
    /// <summary>
    /// Represents a base class for testing serialization.
    /// </summary>
    public abstract class SerializationTestBase
    {
        private static readonly JsonSerializerOptions SerializationOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        /// <summary>
        /// Serializes an object.
        /// </summary>
        /// <typeparam name="T">Type of the object to serialize.</typeparam>
        /// <param name="objectToSerialize">Object to serialize.</param>
        /// <returns>Serialized object.</returns>
        protected static string Serialize<T>(T objectToSerialize)
        {
            string serializedData;

            if (typeof(IEnumerable).IsAssignableFrom(typeof(T)))
            {
                serializedData = JsonSerializer.Serialize(
                    objectToSerialize as IEnumerable<object>, // Cast required otherwise properties of classes inheriting from Item are not serialized. See https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/polymorphism?pivots=dotnet-7-0
                    SerializationOptions);
            }
            else
            {
                serializedData = JsonSerializer.Serialize(
                    objectToSerialize as object, // Cast required otherwise properties of classes inheriting from Item are not serialized. See https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/polymorphism?pivots=dotnet-7-0
                    SerializationOptions);
            }

            return serializedData;
        }
    }
}
