using TotovBuilder.Model.Configuration;

namespace TotovBuilder.Model.Test
{
    /// <summary>
    /// Represents test data.
    /// </summary>
    public partial class TestData
    {
        public static ItemMissingProperties[] ItemMissingProperties { get; } = new ItemMissingProperties[]
        {
            new ItemMissingProperties()
            {
                Id = "601aa3d2b2bcb34913271e6d",
                MaxStackableAmount = 60
            },
            new ItemMissingProperties()
            {
                Id = "569668774bdc2da2298b4568",
                MaxStackableAmount = 50000
            }
        };
    }
}
