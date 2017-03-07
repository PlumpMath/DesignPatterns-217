using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace DesignPatterns.Composite
{
    [TestFixture]
    public class BarbarianTests
    {
        [Test]
        public void Barbarian_Executes_Commands()
        {
            List<ICommand> commands = new List<ICommand>();
            commands.Add(new AttackCommand());
            commands.Add(new MoveCommand());
            var rageCommand = new RageAttackCommand(new List<ICommand> {new MoveCommand(),
                new AttackCommand(), new AttackCommand()});
            commands.Add(rageCommand);
            Barbarian barbarian = new Barbarian(commands);
            barbarian.PerformCommands();
        }
    }
}
