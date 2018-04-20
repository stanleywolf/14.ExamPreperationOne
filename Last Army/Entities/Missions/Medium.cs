using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Medium : Mission
{
    private const string name = "Capturing dangerous criminals";
    private const double enduranceReq = 50;
    private const double wearLevelDecrament = 50;

    public override string Name => name;
    public override double EnduranceRequired => enduranceReq;
    public override double WearLevelDecrement => wearLevelDecrament;

    public Medium(double scoreToComplete) : base(scoreToComplete)
    {
    }
}
