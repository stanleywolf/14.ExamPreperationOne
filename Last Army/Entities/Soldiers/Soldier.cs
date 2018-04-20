using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

public abstract class Soldier : ISoldier
{
    private const double MaxEndurance = 100;
    private const int BaseRegenerateIncrease = 10;

    public string Name { get; private set; }
    public int Age { get; private set; }
    public double Experience { get; private set; }

    private double endurance;
    public double Endurance
    {
        get { return endurance; }
        private set { endurance = Math.Min(value, MaxEndurance); }
    }

    protected abstract double OverallSkillMultiplier { get; }
    public double OverallSkill => (this.Age + this.Experience) * this.OverallSkillMultiplier;

    public IDictionary<string, IAmmunition> Weapons { get; }
    protected abstract IReadOnlyList<string> WeaponsAllowed { get; }

    protected virtual int RegenerateIncreace => BaseRegenerateIncrease;

    protected Soldier(string name, int age, double experience, double endurance)
    {
        this.Name = name;
        this.Age = age;
        this.Experience = experience;
        this.Endurance = endurance;
        this.Weapons= new Dictionary<string, IAmmunition>();
        foreach (var weapon in WeaponsAllowed)
        {
            this.Weapons.Add(weapon,null);
        }
    }

    public void Regenerate()
    {
        this.Endurance += this.Age + RegenerateIncreace;
    }

    public bool ReadyForMission(IMission mission)
    {
        if (this.Endurance < mission.EnduranceRequired)
        {
            return false;
        }

        bool hasAllEquipment = this.Weapons.Values.All(weapon => weapon != null);

        if (!hasAllEquipment)
        {
            return false;
        }

        return this.Weapons.Values.All(weapon => weapon.WearLevel > 0);
    }

    public void CompleteMission(IMission mission)
    {
        this.Experience += mission.EnduranceRequired;
        this.Endurance -= mission.EnduranceRequired;
        foreach (var weapon in this.Weapons.Values.Where(w => w != null).ToList())
        {
            weapon.DecreaseWearLevel(mission.WearLevelDecrement);
            if (weapon.WearLevel <= 0)
            {
                Weapons[weapon.Name] = null;
            }
        }
    }

    //private void AmmunitionRevision(double missionWearLevelDecrement)
    //{
    //    IEnumerable<string> keys = this.Weapons.Keys.ToList();
    //    foreach (string weaponName in keys)
    //    {
    //        this.Weapons[weaponName].DecreaseWearLevel(missionWearLevelDecrement);

    //        if (this.Weapons[weaponName].WearLevel <= 0)
    //        {
    //            this.Weapons[weaponName] = null;
    //        }
    //    }
    //}

    public override string ToString() => string.Format(OutputMassages.SoldierToString, this.Name, this.OverallSkill);
}