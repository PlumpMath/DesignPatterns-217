using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    public class War
    {
        public void Execute(IEnumerable<Troop> troops)
        {
            foreach (var troop in troops)
            {
                troop.Attack();
            }
        }
    }
}
