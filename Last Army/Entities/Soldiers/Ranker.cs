using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ranker:Soldier
{
    private const double overallSkillMiltiplier = 1.5;
    protected override double OverallSkillMultiplier => overallSkillMiltiplier;
    public Ranker(string name, int age, double experience, double endurance) : base(name, age, experience, endurance)
    {
    }
    private readonly List<string> weaponsAllowed = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "Helmet",
    };


    protected override IReadOnlyList<string> WeaponsAllowed => weaponsAllowed;
}