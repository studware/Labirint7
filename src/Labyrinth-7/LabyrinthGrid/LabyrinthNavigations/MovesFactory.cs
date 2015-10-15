using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.LabyrinthGrid.LabyrinthNavigations
{
    public class MovesFactory
    {
        private Labyrinth labyrinth;

        public MovesFactory(Labyrinth labyrinth)
        {
            this.labyrinth = labyrinth;
        }

        public IMoves MoveUp
        {
            get
            {
                return new MoveUp(this.labyrinth);
            }
        }

        public IMoves MoveDown
        {
            get
            {
                return new MoveDown(this.labyrinth);
            }
        }

        public IMoves MoveLeft
        {
            get
            {
                return new MoveLeft(this.labyrinth);
            }
        }
        
        public IMoves MoveRight
        {
            get
            {
                return new MoveRight(this.labyrinth);
            }
        }

    }
}
