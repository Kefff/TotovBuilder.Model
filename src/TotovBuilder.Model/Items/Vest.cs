﻿using System;
using System.Text.Json.Serialization;
using TotovBuilder.Model.Abstractions.Items;
using TotovBuilder.Model.Utils.JsonConverters.Items;

namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents a vest.
    /// </summary>
    [JsonConverter(typeof(VestJsonConverter<IVest, Vest>))]
    public class Vest : Item, IVest
    {
        /// <inheritdoc/>
        [JsonPropertyName("ac")]
        public double ArmorClass { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("aa")]
        public string[] ArmoredAreas { get; set; } = Array.Empty<string>();

        /// <inheritdoc/>
        [JsonPropertyName("d")]
        public double Durability { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("e")]
        public double ErgonomicsPercentageModifier { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ma")]
        public string Material { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("ms")]
        public double MovementSpeedPercentageModifier { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("r")]
        public string RicochetChance { get; set; } = string.Empty;

        /// <inheritdoc/>
        [JsonPropertyName("t")]
        public double TurningSpeedPercentageModifier { get; set; }

        /// <inheritdoc/>
        [JsonPropertyName("ca")]
        public double Capacity { get; set; }
    }
}
