using Labyrinth_7.GameMechanics;
using Labyrinth_7.GameObjectsFactories;
using Labyrinth_7.LabyrinthGrid;
using Labyrinth_7.LabyrinthGrid.LabyrinthGeneration;
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
        private const int LabyrinthSize = 7;

        public GameEngine(IVisualization visualization)
        {
            this.visualization = visualization;
        }

        public void InitGame()
        {
            //var game = Control.Instance;

            //this.visualization.PrintStartMessage();

            //var labyrinth = game.Setup.SetupNewLabyrinth();
            //game.State.IsInitialized = true;
            Labyrinth labyrinth = new Labyrinth(LabyrinthSize, LabyrinthSize);
            GameObjectsGenerator generator = new GameObjectsGenerator();
            generator.GenerateObjectsNew(labyrinth, new CreateObstacles(), new CreateFreeSpace());

            this.visualization.PrintMessage("Labyrinth is Ready");
            

            this.visualization.DrawLabyrinth(labyrinth);
        }
        public void Play()
        { }
    }
}
