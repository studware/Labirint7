namespace Labyrinth_7.GameObjects
{
    using System;

    public interface IGameObject
    {
        char Visualization { get; }

        object Clone();

        bool IsFree { get; }

        //ConsoleColor ForegroundColor { get; }

        //ConsoleColor BackgroundColor { get; }
    }
}
