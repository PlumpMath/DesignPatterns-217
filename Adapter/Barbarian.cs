using System;

namespace DesignPatterns.Adapter
{
    public class Barbarian : IFighter
    {
        public void Move()
        {
            Console.WriteLine("Barbarian moved 5 feet");
        }

        public void Attack()
        {
            Console.WriteLine("Barbarian attacked with sword");
        }
    }
}