using Labyrinth_7.GameMechanics;
using Labyrinth_7.Visualization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7
{
    class GameEngine
    {
        private IVisualization visualization;

        public GameEngine(IVisualization visualization)
        {
            this.visualization = visualization;
        }

        public void InitGame()
        {
            var game = Control.Instance;

            this.visualization.PrintStartMessage();

            var labyrinth = game.Setup.SetupNewLabyrinth();
            game.State.IsInitialized = true;

            this.visualization.PrintMessage("Labyrinth is Ready");
            

            this.visualization.DrawLabyrinth(labyrinth);
        }
        public void Play()
        { }
    }
}
