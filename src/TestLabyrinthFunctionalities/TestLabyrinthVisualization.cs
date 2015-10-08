namespace TestLabyrinthFunctionalities
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Labyrinth_7.LabyrinthGrid.LabyrinthGeneration;
    //using Labyrinth_7.Graphics;
    using Labyrinth_7.Visualization;

    [TestClass]
    public class TestLabyrinthVisualization
    {
        [TestMethod]
        public void Drawing_A_Small_Labyrinth_Should_Work()
        {
            var smallBuilder = new SmallLabyrinthBuilder();
            var director = new LabyrinthDirector();

            director.Generate(smallBuilder);

            var smallLabyrinth = smallBuilder.Labyrinth;


            var visualizator = ConsoleVisualization.Instance;

            visualizator.DrawLabyrinth(smallLabyrinth);
        }
    }
}