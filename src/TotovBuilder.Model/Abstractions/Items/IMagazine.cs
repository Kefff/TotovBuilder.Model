namespace TotovBuilder.Model.Abstractions.Items
{
    /// <summary>
    /// Provides the functionalities of a magazine.
    /// </summary>
    public interface IMagazine : IContainer, IMod
    {
        /// <summary>
        /// IDs of accepted ammunition.
        /// </summary>
        string[] AcceptedAmmunitionIds { get; set; }

        /// <summary>
        /// Modifier added to the check speed in percentage.
        /// </summary>
        double CheckSpeedModifierPercentage { get; set; }

        /// <summary>
        /// Modifier added to the loading speed in percentage.
        /// </summary>
        double LoadSpeedModifierPercentage { get; set; }

        /// <summary>
        /// Malfunction chance in percentage.
        /// </summary>
        double MalfunctionPercentage { get; set; }
    }
}
