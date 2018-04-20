

using System;
using System.Linq;
using System.Reflection;

public class AmmunitionFactory : IAmmunitionFactory
{
    public IAmmunition CreateAmmunition(string ammunitionName)
    {
        Type amunitionType = Assembly.GetCallingAssembly().GetTypes().Single(t => t.Name == ammunitionName);

        return (IAmmunition)Activator.CreateInstance(amunitionType);
    }

    //return (IAmmunition) Activator.CreateInstance(amunitionType, ammunitionName);

}