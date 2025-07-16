namespace TotovBuilder.Model.Items
{
    /// <summary>
    /// Represents an item category.
    /// </summary>
    public class ItemCategory
    {
        /// <summary>
        /// ID.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Tarkov item categories included in this item category.
        /// </summary>
        public ItemType[] Types { get; set; } = [];

        /// <summary>
        /// IDs of additional items that should be included in this item category.
        /// For example, pistol Chiappa Rhino 50DS .357 revolver is not included in type "Pistol" in the game when it should.
        /// </summary>
        public string[] AdditionalItemIds { get; set; } = [];
    }
}
