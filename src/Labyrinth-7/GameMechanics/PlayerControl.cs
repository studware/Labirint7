using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.GameMechanics
{
    abstract class PlayerMoves
    {
        protected abstract bool Check();
        protected abstract void Move();

        public void ExecuteCommand()
        {
            if(this.Check())
            {
                this.Move();
            }
        }
    }
}
