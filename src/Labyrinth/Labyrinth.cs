namespace Labyrinth
{
    using System;
    using System.Collections.Generic;

    public class Labyrinth : Game
    {
        private static void Main(string[] args)
        {
            currentRow = GameStartRow;
            currentColumn = GameStartColumn;

            // It seems this is alway true (the main while cycle )
            flag3 = true;

            string[,] labyrinth = new string[LabyrinthRowLength, LabyrinthColumnLength];

            while (flag3)
            {
                Console.WriteLine("Welcome to \"Labyrinth\" game. Please try to escape. Use 'top' to view the top \nscoreboard,'restart' to start a new game and 'exit' to quit the game.\n ");

                gameInitialized = false;
                gameEndedRecordScore = false;

                while (!gameInitialized)
                {
                    LabyrinthGenerator(labyrinth, currentRow, currentColumn);
                    SolutionChecker(labyrinth, currentRow, currentColumn);
                }

                DisplayLabyrinth(labyrinth);

                PlayGame(labyrinth, currentRow, currentColumn);

                if (gameEndedRecordScore) // used for adding score only when game is finished naturally and not by the restart command.
                {
                    Add(scores, currentMoves);
                }
            }
        }

        static void Add(List<Table> scores, int movesCount)
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

        static void PlayGame(string[,] labyrinth, int x, int y)
        {
            // Maybe find better name. This bool swiches to false when the game ends or the user choose restart        
            bool gameContinues = true;
            currentMoves = 0;

            while (gameContinues)
            {
                Console.Write("\nEnter your move (L=left, R=right, D=down, U=up): ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "d":
                    case "D":
                        TryMoveDown(labyrinth, ref gameContinues, ref x, y);
                        DisplayLabyrinth(labyrinth);
                        break;

                    case "u":
                    case "U":
                        TryMoveUp(labyrinth, ref gameContinues, ref x, y);
                        DisplayLabyrinth(labyrinth);
                        break;

                    case "r":
                    case "R":
                        TryMoveRight(labyrinth, ref gameContinues, x, ref y);
                        DisplayLabyrinth(labyrinth);
                        break;

                    case "l":
                    case "L":
                        TryMoveLeft(labyrinth, ref gameContinues, x, ref y);
                        DisplayLabyrinth(labyrinth);
                        break;

                    case "top":
                        PrintTopScores(scores);
                        Console.WriteLine("\n");
                        DisplayLabyrinth(labyrinth);
                        break;

                    case "restart":
                        gameContinues = false;
                        break;

                    case "exit":
                        Console.WriteLine("Good bye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }

        private static void TryMoveLeft(string[,] labyrinth, ref bool gameContinues, int x, ref int y)
        {
            if (labyrinth[x, y - 1] == "-")
            {
                labyrinth[x, y] = "-";
                labyrinth[x, y - 1] = "*";
                y--;
                currentMoves++;
            }
            else
            {
                Console.WriteLine("\nInvalid move! \n ");
            }

            if (y == 0)
            {
                Console.WriteLine("\nCongratulations you escaped with {0} moves.\n", currentMoves);
                gameContinues = false;
                gameEndedRecordScore = true;
            }
        }

        private static void TryMoveRight(string[,] labyrinth, ref bool gameContinues, int x, ref int y)
        {
            if (labyrinth[x, y + 1] == "-")
            {
                labyrinth[x, y] = "-";
                labyrinth[x, y + 1] = "*";
                y++;
                currentMoves++;
            }
            else
            {
                Console.WriteLine("\nInvalid move! \n ");
            }

            if (y == LabyrinthColumnLength - 1)
            {
                Console.WriteLine("\nCongratulations you escaped with {0} moves.\n", currentMoves);
                gameContinues = false;
                gameEndedRecordScore = true;
            }
        }

        private static void TryMoveUp(string[,] labyrinth, ref bool gameContinues, ref int x, int y)
        {
            if (labyrinth[x - 1, y] == "-")
            {
                labyrinth[x, y] = "-";
                labyrinth[x - 1, y] = "*";
                x--;
                currentMoves++;
            }
            else
            {
                Console.WriteLine("\nInvalid move! \n ");
            }

            if (x == 0)
            {
                Console.WriteLine("\nCongratulations you escaped with {0} moves.\n", currentMoves);
                gameContinues = false;
                gameEndedRecordScore = true;
            }
        }

        private static void TryMoveDown(string[,] labyrinth, ref bool gameContinues, ref int x, int y)
        {
            if (labyrinth[x + 1, y] == "-")
            {
                labyrinth[x, y] = "-";
                labyrinth[x + 1, y] = "*";
                x++;
                currentMoves++;
            }
            else
            {
                Console.WriteLine("\nInvalid move! \n ");
            }

            if (x == LabyrinthRowLength - 1)
            {
                Console.WriteLine("\nCongratulations you escaped with {0} moves.\n", currentMoves);
                gameContinues = false;
                gameEndedRecordScore = true;
            }
        }
    }
}