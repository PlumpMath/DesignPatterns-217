using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class Troops
    {
        private IEnumerable<IFighter> _fighters;

        public Troops(IEnumerable<IFighter> fighters)
        {
            _fighters = fighters;
        }

        public void StartWar()
        {
            foreach (var fighter in _fighters)
            {
                fighter.Move();
                fighter.Attack();
            }
        }
    }
}
