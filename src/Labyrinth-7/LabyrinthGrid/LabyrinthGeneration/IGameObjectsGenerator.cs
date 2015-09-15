namespace Labyrinth_7.LabyrinthGrid.LabyrinthGeneration
{
    using Labyrinth_7.GameObjects;

    public interface IGameObjectsGenerator
    {
        void GenerateObjects(Labyrinth labyrinth, Obstacle obstacle, FreeSpace freeSpace);
    }
}
