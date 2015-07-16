using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public static bool gameInitialized;

        public static bool flag3;

        public static bool flag4;

        public static int currentRow;

        public static int currentColumn;

        public static int currentMoves;

        public static List<Table> scores = new List<Table>(4);
        protected static void DisplayLabyrinth(string[,] labyrinth)
        {
            for (int linee = 0; linee < 7; linee++)
            {
                string s1 = labyrinth[linee, 0];
                string s2 = labyrinth[linee, 1];
                string s3 = labyrinth[linee, 2];
                string s4 = labyrinth[linee, 3];
                string s5 = labyrinth[linee, 4];
                string s6 = labyrinth[linee, 5];
                string s7 = labyrinth[linee, 6];

                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} ", s1, s2, s3, s4, s5, s6, s7);
            }
            Console.WriteLine();
        }

        protected static void LabyrinthGenerator(string[,] labyrinth, int x, int y)
        {
            Random randomInt = new Random();

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    labyrinth[i, j] = Convert.ToString(randomInt.Next(2));
                    if (labyrinth[i, j] == "0")
                    {
                        labyrinth[i, j] = "-";
                    }
                    else
                    {
                        labyrinth[i, j] = "x";
                    }
                }
            }
            labyrinth[currentRow, currentColumn] = "*";
        }

        protected static void SolutionChecker(string[,] labyrinth, int x, int y)
        {
            bool labyrinthIsReady = false;

            // if start position is surrounded by "x" (player can't move)
            if (labyrinth[x + 1, y] == "x" && labyrinth[x, y + 1] == "x" && labyrinth[x - 1, y] == "x" && labyrinth[x, y - 1] == "x")
            {
                return; // retrun to re-initiate the labyrinth
            }

            while (!labyrinthIsReady)
            {
                try
                {
                    if (labyrinth[x + 1, y] == "-")
                    {
                        labyrinth[x + 1, y] = "0";
                        x++;
                    }
                    else if (labyrinth[x, y + 1] == "-")
                    {
                        labyrinth[x, y + 1] = "0";
                        y++;
                    }
                    else if (labyrinth[x - 1, y] == "-")
                    {
                        labyrinth[x - 1, y] = "0";
                        x--;
                    }
                    else if (labyrinth[x, y - 1] == "-")
                    {
                        labyrinth[x, y - 1] = "0";
                        y--;
                    }
                    else
                    {
                        labyrinthIsReady = true;
                    }
                }
                catch (Exception)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (labyrinth[i, j] == "0")
                            {
                                labyrinth[i, j] = "-";
                            }
                        }

                        labyrinthIsReady = true;
                        gameInitialized = true;
                    }
                }
            }
        }
    }
}