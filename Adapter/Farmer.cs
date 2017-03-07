using System;

namespace DesignPatterns.Adapter
{
    public class Farmer
    {
        public void Move()
        {
            Console.WriteLine($"{GetType().Name} moved 7 feet!");
        }

        public void FeedThemCows()
        {
            Console.WriteLine("Farmer fed them cows!");
        }
    }
}