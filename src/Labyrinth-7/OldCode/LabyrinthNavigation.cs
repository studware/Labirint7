namespace Labyrinth_7.OldCode
{
    using System;

    /// <summary>
    /// Responsible for the methods involving moving through the labyrinth
    /// </summary>
    public class LabyrinthNavigation : Game
    {
        public void TryMoveLeft(Labyrinth labyrinth, ref bool gameInProgress, ref int row, ref int col)
        {
            if (labyrinth[row, col - 1] == '-')
            {
                labyrinth[row, col] = '-';
                Console.SetCursorPosition(2 * col, row + 3);
                Console.Write('-');
                col--;
                labyrinth[row, col] = '*';
                Console.SetCursorPosition(2 * (int)col, (int)row + 3);
                Console.Write('*');

                LabyrinthEngine.currentMoves++;
            }

            else
            {
                Console.WriteLine("Invalid move!");
            }

            if (col == 0)
            {
                LabyrinthEngine.GameEndedCongratAndReset(ref gameInProgress);
            }
        }

        public void TryMoveRight(Labyrinth labyrinth, ref bool gameInProgress, ref int row, ref int col)
        {
            if (labyrinth[row, col + 1] == '-')
            {
                labyrinth[row, col] = '-';
                Console.SetCursorPosition(2* col, row + 3);
                Console.Write('-');
                col++;
                labyrinth[row, col] = '*';
                Console.SetCursorPosition(2* col, row + 3);
                Console.Write('*');

                LabyrinthEngine.currentMoves++;
            }
            else
            {
                Console.WriteLine("Invalid move!");
            }

            if (col == LabyrinthColumnLength - 1)
            {
                LabyrinthEngine.GameEndedCongratAndReset(ref gameInProgress);
            }
        }

        public void TryMoveDown(Labyrinth labyrinth, ref bool gameInProgress, ref int row, ref int col)
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

                LabyrinthEngine.currentMoves++;
            }
            else
            {
                Console.WriteLine("Invalid move!");
            }

            if (row == LabyrinthRowLength - 1)
            {
                LabyrinthEngine.GameEndedCongratAndReset(ref gameInProgress);
            }
        }

        public void TryMoveUp(Labyrinth labyrinth, ref bool gameInProgress, ref int row, ref int col)
        {
            if (labyrinth[row - 1, col] == '-')
            {
                labyrinth[row, col] = '-';
                Console.SetCursorPosition(2 * col, row + 3);
                Console.Write('-');
                row--;
                labyrinth[row, col] = '*';
                Console.SetCursorPosition(2 * col, row + 3);
                Console.Write('*');

                LabyrinthEngine.currentMoves++;
            }
            else
            {
                Console.WriteLine("Invalid move!");
            }

            if (row == 0)
            {
                LabyrinthEngine.GameEndedCongratAndReset(ref gameInProgress);
            }
        }
    }
}
