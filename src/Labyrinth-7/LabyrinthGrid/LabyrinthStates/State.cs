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

        public virtual bool IsFinished
        {
            get
            {
                return false;
            }
        }

        public bool SetLabyrinthCell(Position newPosition)
        {
            bool isState = this.SetState(newPosition); 
            if(isState)
            {
                bool isNextCellFree = this.Labyrinth[newPosition].IsFree;
                if(isNextCellFree)
                {
                    this.Labyrinth[newPosition] = this.Labyrinth.ObjectFactory.GetPlayerCell();
                    this.Labyrinth[this.Labyrinth.CurrentPosition] = this.Labyrinth.ObjectFactory.GetVisited();
                    this.Labyrinth.CurrentPosition = newPosition;

                    return true;
                }
            }

            return false;
        }

        protected abstract bool SetState(Position position);
    }
}
