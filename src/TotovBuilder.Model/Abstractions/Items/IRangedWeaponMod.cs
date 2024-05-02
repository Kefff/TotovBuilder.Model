namespace TotovBuilder.Model.Abstractions.Items
{
    /// <summary>
    /// Provides the functionalities of a ranged weapon mod.
    /// <summary>
    public interface IRangedWeaponMod : IMod
    {
        /// <summary>
        /// Modifier added to the weapon accuracy in percentage.
        /// <summary>
        double AccuracyModifierPercentage { get; set; }

        /// <summary>
        /// Modifier added to the weapon recoil in percentage.
        /// <summary>
        double RecoilModifierPercentage { get; set; }
    }
}
