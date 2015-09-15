namespace Labyrinth_7.LabyrinthGrid.LabyrinthGeneration
{
    public class LabyrinthDirector
    {
        public void Generate(LabyrinthBuilder builder)
        {
            bool isSolvable = false;

            while(!isSolvable)
            {
                builder.InitiateGrid();
                builder.AddObjects();
                builder.AddPlayer();

               isSolvable = builder.TestIfSolvable();
            }       
        }
    }
}
