using Labyrinth_7.GameObjectsFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.LabyrinthGrid.LabyrinthNavigations
{
    public abstract class Moves:IMoves
    {
        protected Labyrinth labyrinth;
        protected GameObjectsFactory gameObjectsFactory;

        public Moves(Labyrinth labyrinth)
        {
            this.labyrinth = labyrinth;
            this.CurrentPosition = labyrinth.StartPosition;
        }

        public Position CurrentPosition { get; protected set; }

        public bool Move()
        {
            Position position = this.GetNewPosition();
            bool moveIsOK = this.VerifyNewPosition(position);
            if(moveIsOK)
            {
                MoveToNewPosition(position);
                return true;
            }

            return false;
        }

        protected abstract Position GetNewPosition();

        protected virtual bool VerifyNewPosition(Position position)
        {
            return this.labyrinth[position].IsFree;
        }

        protected bool MoveToNewPosition(Position position)
        {
            bool setNewCell = labyrinth.SetPosition(labyrinth.ObjectFactory.GetPlayerCell(), position.Column, position.Row);
            bool oldCell=false;
            if(setNewCell)
            {
                oldCell= labyrinth.SetPosition(labyrinth.ObjectFactory.GetVisited(), labyrinth.CurrentPosition.Column, labyrinth.CurrentPosition.Row);
                labyrinth.CurrentPosition=position;
            }
            return oldCell;
        }
    }
}
