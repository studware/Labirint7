using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labyrinth_7.GameMechanics;

namespace Labyrinth_7
{
    public class EntryPoint
    {
        private static void Main()
        {
            var game = Control.Instance;

            game.Visualization.PrintStartMessage();

            var labyrinth = game.Setup.SetupNewLabyrinth();
            game.State.IsInitialized = true;

            Console.WriteLine("Labyrinth is Ready");
            Console.WriteLine();

            game.Visualization.DrawLabyrinth(labyrinth);
        }
    }
}
