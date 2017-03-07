using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    public class Wizard : Troop
    {
        protected override void Fight()
        {
            Console.WriteLine("Wizard blasted with magic");
        }

        protected override void Move()
        {
            Console.WriteLine("Wizard moved 10 tiles");
        }
    }
}
