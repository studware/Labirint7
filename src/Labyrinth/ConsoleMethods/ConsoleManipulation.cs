namespace Labyrinth.ConsoleMethods
{
    using System;

    /// <summary>
    /// Since Console is a static class and it cannot be extended using extension methods
    /// This is the closeset thing I could come up with
    /// </summary>
    public static class ConsoleManipulation
    {
        public static void ClearCurrentLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}
