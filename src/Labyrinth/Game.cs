using System;
using System.Collections.Generic;

namespace Labyrinth
{
    public class Game
    {
        // For now this should be odd nummbers (original value was odd number)
        public const int LabyrinthRowLength = 7;

        // For now this should be odd nummbers (original value was odd number)
        public const int LabyrinthColumnLength = 7;

        //Depends on LabyrinthRowLength
        public static int GameStartRow = LabyrinthRowLength / 2;

        //Depends on LabyrinthColumnLength
        public static int GameStartColumn = LabyrinthColumnLength / 2;

        public static bool gameInitialized = false;

        public static bool labyrinthIsReady = false;

        public static bool gameEndedRecordScore;

        public static int currentRow;

        public static int currentColumn;

        public static int currentMoves;

        public static List<Table> scores = new List<Table>(4);
        protected static void DisplayLabyrinth(char[,] labyrinth)
        {
            for (int row = 0; row < 7; row++)
            {
                char tile1 = labyrinth[row, 0];
                char tile2 = labyrinth[row, 1];
                char tile3 = labyrinth[row, 2];
                char tile4 = labyrinth[row, 3];
                char tile5 = labyrinth[row, 4];
                char tile6 = labyrinth[row, 5];
                char tile7 = labyrinth[row, 6];

                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} ", tile1, tile2, tile3, tile4, tile5, tile6, tile7);
            }
            Console.WriteLine();
        }

        protected static void LabyrinthGenerator(char[,] labyrinth, int row, int col)
        {
            Random randomInt = new Random();

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
//                  labyrinth[i, j] = Convert.ToChar(randomInt.Next(2));
//                  if (labyrinth[i, j] == '0')
//                  {
//                      labyrinth[i, j] = '-';
//                  }
//                  else
//                  {
//                      labyrinth[i, j] = 'x';
//                  }

                    int randomNumber=randomInt.Next(2);

                    if (randomNumber == 0)
                    {
                        labyrinth[i, j] = '-';
                    }
                    else
                    {
                        labyrinth[i, j] = 'x';
                    }
                }
            }
            labyrinth[currentRow, currentColumn] = '*';
        }

        /// <summary>
        /// This method should check if THERE IS ANY PATH OUT of the maze - may be it should be re-written?
        /// 
        /// </summary>
        /// <param name="labyrinth"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        protected static void SolutionChecker(char[,] labyrinth, int row, int col)
        {
            // if start position is surrounded by "x" (player can't move) - return to re-initiate the labyrinth

            if (labyrinth[col + 1, row] == '-' || labyrinth[col, row + 1] == '-' || labyrinth[col - 1, row] == '-' || labyrinth[col, row - 1] == '-')
            {
                labyrinthIsReady = true;
                gameInitialized = true; 
            }

            return;
        }
    }
}