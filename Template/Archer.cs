using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    public class Archer : Troop
    {
        protected override void Fight()
        {
           Console.WriteLine("Archer shot an arrow");
        }

        protected override void Move()
        {
            Console.WriteLine("Archer moved 15 tiles");
        }
    }
}
