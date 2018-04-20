﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Corporal:Soldier
{
    private const double overallSkillMiltiplier = 2.5;

    protected override double OverallSkillMultiplier => overallSkillMiltiplier;
    protected override IReadOnlyList<string> WeaponsAllowed => weaponsAllowed;

    private readonly List<string> weaponsAllowed = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "MachineGun",
        "Helmet",
        "Knife",
    };

    public Corporal(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
    }
}