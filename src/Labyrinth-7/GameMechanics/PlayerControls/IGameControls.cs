namespace Labyrinth_7.GameMechanics.PlayerControls
{
    using System;

    public interface IGameControls
    {
        ConsoleKey Exit { get; }

        ConsoleKey Restart { get; }

        ConsoleKey Top { get; }
    }
}
