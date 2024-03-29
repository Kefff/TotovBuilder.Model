﻿using System;
using System.Collections.Generic;
using TotovBuilder.Model.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="Price"/> class.
    /// </summary>
    public sealed class PriceJsonConverter : ReducedJsonConverter<Price, Price>
    {
        /// <inheritdoc/>
        protected override Dictionary<string, Func<Price, bool>> GetPropertyExclusionConditions()
        {
            Dictionary<string, Func<Price, bool>> propertyExclusionConditions = base.GetPropertyExclusionConditions();
            propertyExclusionConditions.Add(nameof(Price.BarterItems), p => p.BarterItems.Length == 0);
            propertyExclusionConditions.Add(nameof(Price.CurrencyName), p => p.CurrencyName == "RUB");
            propertyExclusionConditions.Add(nameof(Price.Merchant), p => p.Merchant == "flea-market");
            propertyExclusionConditions.Add(nameof(Price.MerchantLevel), p => p.MerchantLevel == 0);
            propertyExclusionConditions.Add(nameof(Price.Quest), p => p.Quest == null);
            propertyExclusionConditions.Add(nameof(Price.Value), p => p.Value == 0);
            propertyExclusionConditions.Add(nameof(Price.ValueInMainCurrency), p => p.ValueInMainCurrency == 0);

            return propertyExclusionConditions;
        }
    }
}
