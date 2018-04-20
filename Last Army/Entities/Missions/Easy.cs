using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Easy : Mission
{
    private const string name = "Suppression of civil rebellion";
    private const double enduranceReq = 20;
    private const double wearLevelDecrament = 30;

    public override string Name => name;
    public override double EnduranceRequired => enduranceReq;
    public override double WearLevelDecrement => wearLevelDecrament;

    public Easy(double scoreToComplete) : base(scoreToComplete)
    {
    }
}