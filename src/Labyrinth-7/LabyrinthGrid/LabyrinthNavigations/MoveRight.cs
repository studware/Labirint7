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
            return new Position(currentPosition.X+1, CurrentPosition.Y);
        }

        protected override bool VerifyNewPosition(Position position)
        {
            throw new NotImplementedException();
        }
    }
}
