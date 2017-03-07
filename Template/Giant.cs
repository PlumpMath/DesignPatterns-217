using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    public class Giant : Troop
    {
        protected override void Fight()
        {
            Console.WriteLine("Giant punched melee style");
        }

        protected override void Move()
        {
            Console.WriteLine("Giant moved 5 tiles");
        }
    }
}
