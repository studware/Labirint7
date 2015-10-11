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

        protected abstract bool VerifyNewPosition(Position position);

        protected bool MoveToNewPosition(Position position)
        {
            IGameObjectsFactory player = new PlayerPositionFactory();
            bool setNewCell = labyrinth.SetPosition(player.GetInstance(), position.X, position.Y);
            IGameObjectsFactory visitedCell = new VisitedCellFactory();
            bool oldCell=false;
            if(setNewCell)
            {
                oldCell= labyrinth.SetPosition(visitedCell.GetInstance(), labyrinth.CurrentPosition.X, labyrinth.CurrentPosition.Y);
                labyrinth.CurrentPosition=position;
            }
            return oldCell;
        }
    }
}
