using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DesignPatterns.Adapter
{
    [TestFixture]
    public class TroopsTests
    {
        [Test]
        public void StartWar_Starts_The_War()
        {
            var fighters = new List<IFighter> { new Barbarian(), new Barbarian(), new FightingFarmerAdapter(new Farmer())};
            var troop = new Troops(fighters);

            troop.StartWar();
        }
    }
}
