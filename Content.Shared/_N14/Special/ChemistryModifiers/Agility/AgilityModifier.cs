/*
using Content.Shared.Chemistry.Components;
using Content.Shared.Chemistry.Reagent;
using Content.Shared.Movement.Systems;
using Robust.Shared.Prototypes;
using Robust.Shared.Timing;
using Content.Shared._N14.Special;

namespace Content.Shared._N14.Special.ChemistryModifiers;

    /// <summary>
    /// Default metabolism for stimulants and tranqs. Attempts to find a AgilityModifier on the target,
    /// adding one if not there and to change the Agility
    /// </summary>
public sealed partial class AgilityModifierReagent : ReagentEffect
{

    [DataField("agilityModifier")]
    public int AgilityModifier { get; set; } = 0;

    /// <summary>
    /// How long the modifier applies (in seconds) when metabolized.
    /// </summary>
    [DataField("statusLifetime")]
    public float StatusLifetime = 2f;

    protected override string? ReagentEffectGuidebookText(IPrototypeManager prototype, IEntitySystemManager entSys)
    {
        return Loc.GetString("reagent-effect-guidebook-agility-modifier",
            ("chance", Probability),
            ("agility", AgilityModifier),
            ("time", StatusLifetime));
    }

    /// <summary>
    /// Remove reagent at set rate, changes the Agility modifier and adds a AgilityModifierMetabolismComponent if not already there.
    /// </summary>
    public override void Effect(ReagentEffectArgs args)
    {
        var status = args.EntityManager.EnsureComponent<AgilityModifierMetabolismComponent>(args.SolutionEntity);

        // Only refresh movement if we need to.
        var modified = !status.AgilityModifier.Equals(AgilityModifier);

        status.AgilityModifier = AgilityModifier;

        // only going to scale application time
        var statusLifetime = StatusLifetime;
        statusLifetime *= args.Scale;

        IncreaseTimer(status, statusLifetime);

        if (modified)
            EntitySystem.Get<SpecialModifierSystem>().RefreshClothingSpecialModifiers(args.SolutionEntity);

    }
    public void IncreaseTimer(AgilityModifierMetabolismComponent status, float time)
    {
        var gameTiming = IoCManager.Resolve<IGameTiming>();

        var offsetTime = Math.Max(status.ModifierTimer.TotalSeconds, gameTiming.CurTime.TotalSeconds);

        status.ModifierTimer = TimeSpan.FromSeconds(offsetTime + time);
        status.Dirty();
    }
}
*/
