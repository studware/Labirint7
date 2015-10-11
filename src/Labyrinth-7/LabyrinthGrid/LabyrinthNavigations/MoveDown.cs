using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.LabyrinthGrid.LabyrinthNavigations
{
    class MoveDown:Moves
    {
        public MoveDown(Labyrinth labyrinth)
            : base(labyrinth)
        {
        }

        protected override Position GetNewPosition()
        {
            Position currentPosition = this.labyrinth.CurrentPosition;
            return new Position(currentPosition.X, CurrentPosition.Y + 1);
        }

        protected override bool VerifyNewPosition(Position position)
        {
            throw new NotImplementedException();
        }
    }
}
