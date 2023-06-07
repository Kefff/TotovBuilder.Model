namespace TotovBuilder.Model.Abstractions.Items
{
    /// <summary>
    /// Provides the functionalities of a wearable piece of equipment.
    /// </summary>
    public interface IWearable : IItem
    {
        /// <summary>
        /// Modifier added to the weapon ergonomics in percentage.
        /// </summary>
        double ErgonomicsPercentageModifier { get; set; }

        /// <summary>
        /// Modifier added to the character movement speed in percentage.
        /// </summary>
        double MovementSpeedPercentageModifier { get; set; }

        /// <summary>
        /// Modifier added to the character turning speed in percentage.
        /// </summary>
        double TurningSpeedPercentageModifier { get; set; }
    }
}
