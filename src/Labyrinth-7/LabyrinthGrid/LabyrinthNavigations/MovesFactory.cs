using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.LabyrinthGrid.LabyrinthNavigations
{
    class MovesFactory
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


    }
}
