using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.LabyrinthGrid.LabyrinthNavigations
{
    class MoveDown : Moves
    {
        public MoveDown(Labyrinth labyrinth)
            : base(labyrinth)
        {
        }

        protected override Position GetNewPosition()
        {
            Position currentPosition = this.labyrinth.CurrentPosition;
            return this.labyrinth.ObjectFactory.GetPosition(currentPosition.Row + 1, currentPosition.Column);
        }
    }
}
