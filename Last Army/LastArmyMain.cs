using System;
using System.Text;

class LastArmyMain
{
    static void Main()
    {
        var reader = new Reader();
        var writer = new Writer();
        var engine = new Engine(reader,writer);
        engine.Run();

    }
}
