using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.LabyrinthGrid.LabyrinthStates
{
    class EndState:State
    {
        public EndState(Labyrinth labyrinth):base(labyrinth)
        {
        }

        protected override bool SetState(Position position)
        {
            return false;
        }

        public override bool IsFinished
        {
            get
            {
                return true;
            }
        }
    }
}
