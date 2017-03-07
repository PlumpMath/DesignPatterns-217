using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    public abstract class Troop
    {
        protected abstract void Fight();
        protected abstract void Move();

        public void Attack()
        {
            Move();
            Fight();
        }

    }
}
