using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.LabyrinthGrid.LabyrinthNavigations
{
    class MoveUp:Moves
    {
        public MoveUp(Labyrinth labyrinth)
            : base(labyrinth)
        {
        }

        protected override Position GetNewPosition()
        {
            Position currentPosition = this.labyrinth.CurrentPosition;
            return labyrinth.ObjectFactory.GetPosition(CurrentPosition.Row - 1, currentPosition.Column);
        }
    }
}
