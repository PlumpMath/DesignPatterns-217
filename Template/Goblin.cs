using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    public class Goblin : Troop
    {
        protected override void Fight()
        {
            Console.WriteLine("I attacked with my little hands");
        }

        protected override void Move()
        {
            Console.WriteLine("I moved 20 tiles");
        }
    }
}
