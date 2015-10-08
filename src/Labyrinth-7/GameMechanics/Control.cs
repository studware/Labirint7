namespace Labyrinth_7.GameMechanics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Labyrinth_7.Visualization;

    public class Control
    {
        private static Control singleton;

        private Control()
        {
        }

        public static Control Instance
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new Control();
                }

                return singleton;
            }
        }

        public GameSetup Setup
        {
            get
            {
                return GameSetup.Instance;
            }
        }

        public GameState State
        {
            get
            {
                return GameState.Instance;
            }
        }

        public ConsoleVisualization Visualization
        {
            get
            {
                return ConsoleVisualization.Instance;
            }
        }
    }
}
