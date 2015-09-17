namespace Labyrinth_7.GameMechanics.PlayerControls
{
    using System;

    public interface IPlayControls
    {
        ConsoleKey Up { get; }

        ConsoleKey Right { get; }

        ConsoleKey Down { get; }

        ConsoleKey Left { get; }

        void PrintControls();
    }
}
