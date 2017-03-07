using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Barbarian
    {
        List<ICommand> _commands;
        public Barbarian(List<ICommand> commands)
        {
            _commands = commands;
        }

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void PerformCommands()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}
