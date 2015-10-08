namespace Labyrinth_7.Visualization
{
    using Labyrinth_7.LabyrinthGrid;
    using System;

    interface IVisualization
    {
        void PrintStartMessage();
        void DrawLabyrinth(Labyrinth labyrinth);
    }
}
