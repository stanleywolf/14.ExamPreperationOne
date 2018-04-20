using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Warehouse : IWarehouse
{
    private Dictionary<string, int> ammunitionsQuantities;
    private IAmmunitionFactory ammunitionFactory;

    public Warehouse()
    {
        ammunitionsQuantities = new Dictionary<string, int>();
        ammunitionFactory = new AmmunitionFactory();
    }

    public void AddAmmunition(string ammunition, int quantuty)
    {
        if (ammunitionsQuantities.ContainsKey(ammunition))
        {
            ammunitionsQuantities[ammunition] += quantuty;
        }
        else
        {
            ammunitionsQuantities.Add(ammunition,quantuty);
        }
    }

    public void EquipArmy(IArmy army)
    {
        foreach (var soldier in army.Soldiers)
        {
            this.TryEquipSoldier(soldier);
        }
    }

    public bool TryEquipSoldier(ISoldier soldier)
    {
        var wornOutWeapon = soldier.Weapons.Where(w => w.Value == null).Select(w => w.Key).ToList();
        var isSoldierEquiped = true;

        foreach (var weapon in wornOutWeapon)
        {
            if (ammunitionsQuantities.ContainsKey(weapon) && ammunitionsQuantities[weapon] > 0)
            {
                soldier.Weapons[weapon] = ammunitionFactory.CreateAmmunition(weapon);
                ammunitionsQuantities[weapon]--;
            }
            else
            {
                isSoldierEquiped = false;
            }
        }
        return isSoldierEquiped;

    }
}
   