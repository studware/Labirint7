using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.LabyrinthGrid.LabyrinthStates
{
    class ActiveState:State 
    {
        public ActiveState(Labyrinth labyrinth):base(labyrinth)
        {
        }

        protected override bool SetState(Position position)
        {
            if(0<=position.Column&&position.Column<this.Labyrinth.Columns&&0<=position.Row&&position.Row<this.Labyrinth.Rows)
            {
                return true;
            }

            this.Labyrinth.State = new EndState(this.Labyrinth);
            return true;
        }
    }
}
