using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IWarehouse
{
    void EquipArmy(IArmy army);

    void AddAmmunition(string ammunition, int quantuty);

    bool TryEquipSoldier(ISoldier soldier);
}
