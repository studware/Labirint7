namespace TestLabyrinthFunctionalities
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Labyrinth_7.LabyrinthGrid.LabyrinthGeneration;

    [TestClass]
    public class TestLabyrinthBuilder
    {
        [TestMethod]
        public void Building_Small_Labyrinth_With_Default_Settings_Should_Work()
        {
            var smallBuilder = new SmallLabyrinthBuilder();
            var director = new LabyrinthDirector();

            director.Generate(smallBuilder);

            var smallLabyrinth = smallBuilder.Labyrinth;
        }
    }
}
