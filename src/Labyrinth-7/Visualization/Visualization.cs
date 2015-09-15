using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labyrinth_7.LabyrinthGrid;

namespace Labyrinth_7.Visualization
{
    public class Visualization
    {
        private static Visualization singleton;

        private Visualization()
        {
        }

        public static Visualization Instance
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new Visualization();
                }

                return singleton;
            }
        }

        public void DrawLabyrinth(LabyrinthGrid.Labyrinth labyrinth)
        {
            for (int i = 0; i < labyrinth.LengthY; i++)
            {
                for (int j = 0; j < labyrinth.LengthX; j++)
                {
                    var currentGameObject = labyrinth[i, j];

                    char currentSymbol = currentGameObject.Visualization;
                    Console.BackgroundColor = currentGameObject.BackgroundColor;
                    Console.ForegroundColor = currentGameObject.ForegroundColor;

                    Console.WriteLine(currentSymbol);
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}
