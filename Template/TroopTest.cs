using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DesignPatterns.Template
{
    [TestFixture]
    public class TroopTest
    {
        [Test]
        public void Archer_Moves_15_Tiles()
        {
            var archer = new Archer();
            archer.Attack();
        }

        [Test]
        public void War_Test()
        {
            var troops = new List<Troop> {new Giant(), new Archer(), new Giant()};
            var war = new War();
            war.Execute(troops);

        }
    }
}
