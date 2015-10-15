using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.LabyrinthGrid.LabyrinthStates
{
    class InitialState:State
    {
        public InitialState(Labyrinth labyrinth):base(labyrinth)
        {
        }

        protected override bool SetState(Position position)
        {
            this.Labyrinth.State = new ActiveState(this.Labyrinth);
            return true;
        }
    }
}
