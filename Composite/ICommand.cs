using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public interface ICommand
    {
        void Execute();
    }

    public class MoveCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Moved toward defensive structure");
        }
    }
    public class AttackCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Attacked nearest object");
        }
    }

    public class RageAttackCommand : ICommand
    {
        private IList<ICommand> _commands;
        public void Execute()
        {
            Console.WriteLine("Starting Rage Attack");
            foreach (var command in _commands)
            {
                command.Execute();
            }
            Console.WriteLine("Finishing Rage Attack");
        }

        public RageAttackCommand(List<ICommand> commands)
        {
            _commands = commands;
        }
    }
}