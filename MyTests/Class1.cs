using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyTests
{
    public class Class1
    {
        [Test]
        public void MissionControllerDisplaysFailedMassage
            ()
        {
            var army = new Army();
            var wareHouse = new Warehouse();
            var missionController = new MissionController(army, wareHouse);

            var mission = new Easy(1);
            string result = "";
            for (int i = 0; i < 4; i++)
            {
                result = missionController.PerformMission(mission);
            }
            Assert.IsTrue(result.StartsWith("Mission declined - Suppression of civil rebellion"));
        }
        [Test]
        public void MissionControllerDisplaysSuccessMassage
            ()
        {
            var army = new Army();
            var wareHouse = new Warehouse();
            var missionController = new MissionController(army, wareHouse);

            var mission = new Easy(0);
            string result = missionController.PerformMission(mission);

            Assert.IsTrue(result.StartsWith("Mission completed - Suppression of civil rebellion"));
        }
    }
}
