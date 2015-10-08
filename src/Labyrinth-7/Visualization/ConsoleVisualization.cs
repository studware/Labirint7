namespace Labyrinth_7.Visualization
{
    using System;
    using Labyrinth_7.LabyrinthGrid;

    public class ConsoleVisualization:IVisualization
    {
        private string gameStartMessage = "Welcome to 'Labyrinth' game. Your goal is to escape. Use 'T' to view the top \nscoreboard,'R' to start a new game and 'E' to quit the game.\n";

        private static ConsoleVisualization singleton;

        private ConsoleVisualization()
        {
        }

        public static ConsoleVisualization Instance
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new ConsoleVisualization();
                }

                return singleton;
            }
        }

        public void PrintStartMessage()
        {
            Console.WriteLine(gameStartMessage);
            Console.WriteLine();
        }

        public void DrawLabyrinth(Labyrinth labyrinth)
        {
            for (int i = 0; i < labyrinth.LengthY; i++)
            {
                for (int j = 0; j < labyrinth.LengthX; j++)
                {
                    var currentGameObject = labyrinth[i, j];

                    char currentSymbol = currentGameObject.Visualization;
                    Console.BackgroundColor = currentGameObject.BackgroundColor;
                    Console.ForegroundColor = currentGameObject.ForegroundColor;

                    Console.Write(currentSymbol + " ");
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }


        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
