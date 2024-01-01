using System;
using System.Collections.Generic;
using TotovBuilder.Model.Items;

namespace TotovBuilder.Model.Utils.JsonConverters.Items
{
    /// <summary>
    /// Represents a JSON converter for the <see cref="BarterItem"/> class.
    /// </summary>
    public sealed class BarterItemJsonConverter : ReducedJsonConverter<BarterItem, BarterItem>
    {
        /// <inheritdoc/>
        protected override Dictionary<string, Func<BarterItem, bool>> GetPropertyExclusionConditions()
        {
            Dictionary<string, Func<BarterItem, bool>> propertyExclusionConditions = base.GetPropertyExclusionConditions();
            propertyExclusionConditions.Add(nameof(BarterItem.Quantity), bi => bi.Quantity == 1);

            return propertyExclusionConditions;
        }
    }
}
