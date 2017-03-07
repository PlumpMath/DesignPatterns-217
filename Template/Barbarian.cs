using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    public class Barbarian : Troop
    {
        protected override void Fight()
        {
            Console.WriteLine("Barbarian attacks with sword");
        }

        protected override void Move()
        {
            Console.WriteLine("Barbarian moved 10 tiles");
        }
    }
}
