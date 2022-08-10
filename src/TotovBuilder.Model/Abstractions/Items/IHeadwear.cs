namespace TotovBuilder.Model.Abstractions.Items
{
    /// <summary>
    /// Provides the functionalities of headwear.
    /// </summary>
    public interface IHeadwear : IArmor, IModdable
    {
        /// <summary>
        /// Severity of the hearing impairement caused by the helmet.
        /// </summary>
        string Deafening { get; set; }
    }
}
