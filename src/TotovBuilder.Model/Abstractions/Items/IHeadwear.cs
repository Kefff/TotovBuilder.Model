namespace TotovBuilder.Model.Abstractions.Items
{
    /// <summary>
    /// Provides the functionalities of headwear.
    /// </summary>
    public interface IHeadwear : IArmor
    {
        /// <summary>
        /// Indicates whether headphones are block by the helmet.
        /// </summary>
        bool BlocksHeadphones { get; set; }

        /// <summary>
        /// Severity of the hearing impairement caused by the helmet.
        /// </summary>
        string Deafening { get; set; }

        /// <summary>
        /// Ricochet chance.
        /// </summary>
        public string RicochetChance { get; set; }
    }
}
