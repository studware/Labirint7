namespace Labyrinth_7.Visualization
{
    using Labyrinth_7.LabyrinthGrid;
using Labyrinth_7.LabyrinthGrid.LabyrinthNavigations;
using System;

    interface IVisualization
    {
        void PrintStartMessage();
        void DrawLabyrinth(Labyrinth labyrinth);
        void PrintMessage(string message);
        IMoves GetUserCommand(MovesFactory factory);
    }
}
