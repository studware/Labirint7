using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrinth_7.OldCode
{
    public abstract class Game
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

        protected static void DisplayLabyrinth(Labyrinth labyrinth)
        {
            for (int row = 0; row < labyrinth.LengthX; row++)
            {
                StringBuilder rowBuilder = new StringBuilder(2 * (int)labyrinth.LengthY);
                for (int column = 0; column < labyrinth.LengthY; column++)
                {
                    rowBuilder.Append(labyrinth[row,column]);
                    rowBuilder.Append(" ");
                }

                Console.WriteLine(rowBuilder.ToString());            
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
        /// This method should check if THERE IS ANY PATH OUT of the labyrinth - may be it should be re-written?
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