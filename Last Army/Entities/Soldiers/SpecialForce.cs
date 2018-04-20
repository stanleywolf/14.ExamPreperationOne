using System.Collections.Generic;
using System.Text;

public class SpecialForce : Soldier
{
    private const int regenerateIncreace = 30;
    private const double overallSkillMiltiplier = 3.5;

    protected override double OverallSkillMultiplier => overallSkillMiltiplier;
    protected override IReadOnlyList<string> WeaponsAllowed => weaponsAllowed;
    protected override int RegenerateIncreace => regenerateIncreace;

    private readonly List<string> weaponsAllowed = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "MachineGun",
        "RPG",
        "Helmet",
        "Knife",
        "NightVision"
    };

    public SpecialForce(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
    }
}