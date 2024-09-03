namespace TotovBuilder.Model.Abstractions.Items
{
    /// <summary>
    /// Provides the functionalities of ammunition.
    /// </summary>
    public interface IAmmunition : IItem
    {
        /// <summary>
        /// Modifier added to the weapon accuracy in percentage.
        /// </summary>
        double AccuracyModifierPercentage { get; set; }

        /// <summary>
        /// Armor damage percentage.
        /// </summary>
        double ArmorDamagePercentage { get; set; }

        /// <summary>
        /// List of the penetration effectiveness by armor class.
        /// </summary>
        double[] ArmorPenetrations { get; set; }

        /// <summary>
        /// Indicates whether the ammunitions can blind opponents.
        /// </summary>
        bool Blinding { get; set; }

        /// <summary>
        /// Caliber.
        /// </summary>
        string Caliber { get; set; }

        /// <summary>
        /// Durability burn modifier percentage.
        /// </summary>
        double DurabilityBurnModifierPercentage { get; set; }

        /// <summary>
        /// Damage done the the body when penetrating armor.
        /// </summary>
        double FleshDamage { get; set; }

        /// <summary>
        /// Percentage of chance to fragment and inflict additional damage to the body.
        /// </summary>
        double FragmentationChance { get; set; }

        /// <summary>
        /// Percentage of chance to inflict a heavy bleeding when hitting flesh.
        /// </summary>
        double HeavyBleedingChance { get; set; }

        /// <summary>
        /// Percentage of chance to inflict a light bleeding when hitting flesh.
        /// </summary>
        double LightBleedingChance { get; set; }

        /// <summary>
        /// Armor penetration power.
        /// </summary>
        double PenetrationPower { get; set; }

        /// <summary>
        /// Number of projectiles.
        /// Usually 1 except for shotgun buckshot ammunition which fires multiple pellets.
        /// </summary>
        double Projectiles { get; set; }

        /// <summary>
        /// Modifier added to the weapon recoil in percentage.
        /// </summary>
        double RecoilModifier { get; set; }

        /// <summary>
        /// Indicates whether the ammunition is subsonic or not.
        /// </summary>
        bool Subsonic { get; set; }

        /// <summary>
        /// Indicates whether the ammunition is will have a coloured trail while flying.
        /// </summary>
        bool Tracer { get; set; }

        /// <summary>
        /// Bullet velocity.
        /// </summary>
        double Velocity { get; set; }
    }
}
