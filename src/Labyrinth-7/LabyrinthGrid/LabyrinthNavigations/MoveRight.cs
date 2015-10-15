using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.LabyrinthGrid.LabyrinthNavigations
{
    class MoveRight:Moves
    {
        public MoveRight(Labyrinth labyrinth):base(labyrinth)
        {
        }

        protected override Position GetNewPosition()
        {
            Position currentPosition = this.labyrinth.CurrentPosition;
            return this.labyrinth.ObjectFactory.GetPosition(currentPosition.Row, currentPosition.Column + 1);
        }
    }
}
