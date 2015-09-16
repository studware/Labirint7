namespace Labyrinth_7.OldCode
{
    using ConsoleMethods;
    using System;
    using System.Collections.Generic;

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

            // char[,] labyrinth = new char[LabyrinthRowLength, LabyrinthColumnLength];

            var labyrinth = new Labyrinth(LabyrinthRowLength);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to \"Labyrinth\" game. Your goal is to escape. Use 'T' to view the top \nscoreboard,'R' to start a new game and 'E' to quit the game.\n ");

                gameInitialized = false;
                gameEndedRecordScore = false;

                if (!gameInitialized)
                {
                    labyrinth.GenerateObstacles();
                }

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
            Console.SetCursorPosition(0, 15);
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

        public static void PlayGame(Labyrinth labyrinth, int row, int col)
        {      
            bool gameInProgress = true;
            currentMoves = 0;
            Console.WriteLine("\nEnter your move (Left Arrow = left, Right Arrow = right, Down Arrow = down, Up Arrow = up)");
            Console.SetCursorPosition(0, 15);

            LabyrinthNavigation navigation = new LabyrinthNavigation();

            while (gameInProgress)
            {
                ConsoleKeyInfo userChoice = Console.ReadKey(true);

                // Set currsor position outside of labyrinth and deletes previous turn message if any
                // I think this should be edited latter to not use magic numbers 
                Console.SetCursorPosition(0, 15);
                ConsoleManipulation.ClearCurrentLine();

                switch (userChoice.Key)
                {
                    case ConsoleKey.LeftArrow:
                        navigation.TryMoveLeft(labyrinth, ref gameInProgress, ref row, ref col);
                        break;

                    case ConsoleKey.RightArrow:
                        navigation.TryMoveRight(labyrinth, ref gameInProgress, ref row, ref col);
                        break;

                    case ConsoleKey.DownArrow:
                        navigation.TryMoveDown(labyrinth, ref gameInProgress, ref row, ref col);
                        break;

                    case ConsoleKey.UpArrow:
                        navigation.TryMoveUp(labyrinth, ref gameInProgress, ref row, ref col);
                        break;

                    case ConsoleKey.T:
                        PrintTopScores(scores);
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
      
        public static void GameEndedCongratAndReset(ref bool gameInProgress)
        {
            Console.SetCursorPosition(0, 15);
            ConsoleManipulation.ClearCurrentLine();
            Console.WriteLine("\nCongratulations you escaped with {0} moves.\n", currentMoves);
            gameInProgress = false;
            gameEndedRecordScore = true;
        }

        public void TryMoveLeft(Labyrinth labyrinth, ref bool gameInProgress, ref int row, ref int col)
        {
            throw new NotImplementedException();
        }
    }
}