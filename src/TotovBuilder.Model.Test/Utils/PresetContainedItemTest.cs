using FluentAssertions;
using TotovBuilder.Model.Items;
using TotovBuilder.Model.Utils;
using Xunit;

namespace TotovBuilder.Model.Test.Utils
{
    /// <summary>
    /// Represents tests on the <see cref="PresetContainedItem"/> class.
    /// </summary>
    public class PresetContainedItemTest
    {
        [Fact]
        public void Constructor_ShouldCreateInstance()
        {
            // Arrange
            Item item = new();

            // Act
            PresetContainedItem presetContainedItem = new(item, 2);

            // Assert
            presetContainedItem.Item.Should().Be(item);
            presetContainedItem.Quantity.Should().Be(2);
        }
    }
}
