namespace Labyrinth
{
    using System;
    using System.Collections.Generic;
    using ConsoleMethods;

    /// <summary>
    /// This class controls the game Labyrinth using one instance at a time
    /// by the means of Singleton creative design pattern
    /// combined with the "Lazy Initialization" creative design pattern.
    /// </summary>
    public sealed class LabyrinthEngine : Game
    {
        private static readonly LabyrinthEngine gameInstance = new LabyrinthEngine();

        /// <summary>
        /// Explicit static constructor to tell C# compiler not to mark type as beforefieldinit;
        /// this provides for using the "Lazy Initialization" pattern, because
        /// the laziness of type initializers is only guaranteed by .NET when the type isn't marked
        /// with a special flag called "beforefieldinit".
        /// </summary>
        static LabyrinthEngine()
        {
        }

        private LabyrinthEngine()
        {
        }

        public static LabyrinthEngine GameInstance
        {
            get
            {
                return gameInstance;
            }
        }

        public static void Main()
        {           
            currentRow = GameStartRow;
            currentColumn = GameStartColumn;

            char[,] labyrinth = new char[LabyrinthRowLength, LabyrinthColumnLength];

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to \"Labyrinth\" game. Please try to escape. Use 'top' to view the top \nscoreboard,'restart' to start a new game and 'exit' to quit the game.\n ");

                gameInitialized = false;
                gameEndedRecordScore = false;

                while (!gameInitialized)
                {
                    LabyrinthGenerator(labyrinth, currentRow, currentColumn);
                    SolutionChecker(labyrinth, currentRow, currentColumn);
                }

//              Console.SetWindowSize(40, 50);
//              Console.BackgroundColor = ConsoleColor.DarkGray;

                DisplayLabyrinth(labyrinth);

                PlayGame(labyrinth, currentRow, currentColumn);

                if (gameEndedRecordScore) // used for adding score only when game is finished naturally and not by the restart command.
                {
                    AddScore(scores, currentMoves);
                }
            }
        }

        static void AddScore(List<Table> scores, int movesCount)
        {
            if (scores.Count != 0)
            {
                scores.Sort(delegate(Table s1, Table s2) { return s1.moves.CompareTo(s2.moves); });
            }

            if (scores.Count < 5)
            {
                Console.WriteLine("Please enter your nickname");
                string name = Console.ReadLine();
                scores.Add(new Table(movesCount, name));
                PrintTopScores(scores);
            }
            else 
            {
                if (scores[4].moves > movesCount)
                {
                    scores.Remove(scores[4]);
                    Console.WriteLine("Please enter your nickname");
                    string name = Console.ReadLine();
                    scores.Add(new Table(movesCount, name));
                    PrintTopScores(scores);
                }
            }

            gameEndedRecordScore = false;
        }

        static void PrintTopScores(List<Table> scores)
        {
            Console.WriteLine("\n");
            if (scores.Count == 0)
            {
                Console.WriteLine("The scoreboard is empty! ");
            }
            else
            {
                int i = 1;
                scores.Sort(delegate(Table s1, Table s2) { return s1.moves.CompareTo(s2.moves); });
                Console.WriteLine("Top 5: \n");
                scores.ForEach(delegate(Table s)
                {
                    Console.WriteLine(string.Format(i + ". {1} ---> {0} moves", s.moves, s.name));
                    i++;
                });

                Console.WriteLine("\n");
            }
        }

        static void PlayGame(char[,] labyrinth, int row, int col)
        {      
            bool gameInProgress = true;
            currentMoves = 0;
            Console.WriteLine("\nEnter your move (Left Arrow = left, Right Arrow = right, Down Arrow = down, Up Arrow = up)");
            Console.SetCursorPosition(0, 15);

            while (gameInProgress)
            {
                ConsoleKeyInfo userChoice = Console.ReadKey(true);

                // Set currsor position outside of labyrinth and deletes previous turn message if any
                // I think this should be edited latter to not use magic numbers 
                Console.SetCursorPosition(0, 15);
                ConsoleManipulation.ClearCurrentLine();

                switch (userChoice.Key)
                {
                    case ConsoleKey.DownArrow:
                        TryMoveDown(labyrinth, ref gameInProgress, ref row, col);
                        break;

                    case ConsoleKey.UpArrow:
                        TryMoveUp(labyrinth, ref gameInProgress, ref row, col);
                        break;

                    case ConsoleKey.RightArrow:
                        TryMoveRight(labyrinth, ref gameInProgress, row, ref col);
                        break;

                    case ConsoleKey.LeftArrow:
                        TryMoveLeft(labyrinth, ref gameInProgress, row, ref col);
                        break;

                    case ConsoleKey.T:
                        PrintTopScores(scores);
                        Console.WriteLine("\n");
                        DisplayLabyrinth(labyrinth);
                        break;

                    case ConsoleKey.R:
                        gameInProgress = false;
                        break;

                    case ConsoleKey.E:
                        Console.WriteLine("Good bye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }

        private static void TryMoveLeft(char[,] labyrinth, ref bool gameInProgress, int row, ref int col)
        {
            if (labyrinth[row, col - 1] == '-')
            {
                labyrinth[row, col] = '-';
                Console.SetCursorPosition(2*col, row+3);
                Console.Write('-');
                col--;
                labyrinth[row, col] = '*';
                Console.SetCursorPosition(2*col, row+3);
                Console.Write('*');

                currentMoves++;
            }
            else
            {
                Console.WriteLine("Invalid move!");
            }

            if (col == 0)
            {
                GameEndedCongratAndReset(ref gameInProgress);
            }
        }

        private static void TryMoveRight(char[,] labyrinth, ref bool gameInProgress, int row, ref int col)
        {
            if (labyrinth[row, col + 1] == '-')
            {
                labyrinth[row, col] = '-';
                Console.SetCursorPosition(2*col, row + 3);
                Console.Write('-');
                col++;
                labyrinth[row, col] = '*';
                Console.SetCursorPosition(2*col, row + 3);
                Console.Write('*');

                currentMoves++;
            }
            else
            {
                Console.WriteLine("Invalid move!");
            }

            if (col == LabyrinthColumnLength - 1)
            {
                GameEndedCongratAndReset(ref gameInProgress);
            }
        }

        private static void TryMoveUp(char[,] labyrinth, ref bool gameInProgress, ref int row, int col)
        {
            if (labyrinth[row - 1, col] == '-')
            {
                labyrinth[row, col] = '-';
                Console.SetCursorPosition(2*col, row + 3);
                Console.Write('-');
                row--;
                labyrinth[row, col] = '*';
                Console.SetCursorPosition(2 * col, row + 3);
                Console.Write('*');

                currentMoves++;
            }
            else
            {
                Console.WriteLine("Invalid move!");
            }

            if (row == 0)
            {
                GameEndedCongratAndReset(ref gameInProgress);
            }
        }

        private static void TryMoveDown(char[,] labyrinth, ref bool gameInProgress, ref int row, int col)
        {
            if (labyrinth[row + 1, col] == '-')
            {
                labyrinth[row, col] = '-';
                Console.SetCursorPosition(2 * col, row + 3);
                Console.Write('-');
                row++;
                labyrinth[row, col] = '*';
                Console.SetCursorPosition(2 * col, row + 3);
                Console.Write('*');

                currentMoves++;
            }
            else
            {
                Console.WriteLine("Invalid move!");
            }

            if (row == LabyrinthRowLength - 1)
            {
                GameEndedCongratAndReset(ref gameInProgress);
            }
        }
        
        private static void GameEndedCongratAndReset(ref bool gameInProgress)
        {
            Console.SetCursorPosition(0, 15);
            ConsoleManipulation.ClearCurrentLine();
            Console.WriteLine("\nCongratulations you escaped with {0} moves.\n", currentMoves);
            gameInProgress = false;
            gameEndedRecordScore = true;
        }
    }
}