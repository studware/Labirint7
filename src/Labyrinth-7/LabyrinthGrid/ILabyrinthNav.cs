namespace Labyrinth_7.LabyrinthGrid
{
    public interface ILabyrinthNav
    {
        Position CurrentPosition { get; }

        Labyrinth Labyrinth { get; }

        bool MoveUp();

        bool MoveRight();

        bool MoveDown();

        bool MoveLeft();

        bool MoveChecker(Position position);
    }
}
