using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Hard : Mission
{
    private const string name = "Disposal of terrorists";
    private const double enduranceReq = 80;
    private const double wearLevelDecrament = 70;

    public override string Name => name;
    public override double EnduranceRequired => enduranceReq;
    public override double WearLevelDecrement => wearLevelDecrament;

    public Hard(double scoreToComplete) : base(scoreToComplete)
    {
    }
}
   