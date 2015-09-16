namespace Labyrinth_7.GameMechanics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Labyrinth_7.LabyrinthGrid;
    using Labyrinth_7.LabyrinthGrid.LabyrinthGeneration;

    public class GameSetup
    {
        private static GameSetup singleton;

        private GameSetup()
        {
        }

        public static GameSetup Instance
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new GameSetup();
                }

                return singleton;
            }
        }

        public Labyrinth SetupNewLabyrinth()
        {
            
            Console.Write("Choose 'short', 'advanced' or skip for 'default' setup: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "short")
            {
                return ShortSetup();
            }
            else if (userChoice == "advanced")
            {
                return AdvancedSetup();
            }
            else
            {
                return DefaultSetup();
            }
           
        }

        private Labyrinth DefaultSetup()
        {
            Console.WriteLine("Default Setup");

            var smallBuilder = new SmallLabyrinthBuilder();
            var director = new LabyrinthDirector();

            director.Generate(smallBuilder);

            return smallBuilder.Labyrinth;
        }

        private Labyrinth ShortSetup()
        {
            throw new NotImplementedException("To be implemented");
        }

        private Labyrinth AdvancedSetup()
        {
            throw new NotImplementedException("To be implemented");
        }
    }
}
