using Labyrinth_7.GameObjectsFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.LabyrinthGrid.LabyrinthStates
{
    public abstract class State
    {
        protected State(Labyrinth labyrinth)
        {
            this.Labyrinth = labyrinth;
        }
        
        public Labyrinth Labyrinth { get; set; }

        public bool SetLabyrinthCell(Position position)
        {
            bool isState = this.SetState(position); 
            if(isState)
            {
                bool isNextCellFree = this.Labyrinth[position].IsFree;
                if(isNextCellFree)
                {
                    IGameObjectsFactory playerFactory=new PlayerPositionFactory();
                    this.Labyrinth[position] = playerFactory.GetInstance();

                    IGameObjectsFactory visitedFactory = new VisitedCellFactory();
                    this.Labyrinth[this.Labyrinth.CurrentPosition] = visitedFactory.GetInstance();

                    this.Labyrinth.CurrentPosition = position;

                    return true;
                }
            }

            return false;
        }

        protected abstract bool SetState(Position position);

        public abstract void MoveUp();

        public abstract void MoveDown();

        public abstract void MoveLeft();

        public abstract void MoveRight();
    }
}
