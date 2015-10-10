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

        public abstract void MoveUp();

        public abstract void MoveDown();

        public abstract void MoveLeft();

        public abstract void MoveRight();
    }
}
