using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labyrinth_7.GameObjects;

namespace Labyrinth_7.LabyrinthGrid.LabyrinthGeneration
{
    public class GameObjectsGenerator : IGameObjectsGenerator
    {
        private Random randomInt;

        public GameObjectsGenerator() : this(new Random())
        {
        }

        public GameObjectsGenerator(Random rnd)
        {
            this.randomInt = rnd;
        }

        public void GenerateObjects(Labyrinth labyrinth, Obstacle obstacle, FreeSpace freeSpace)
        {
            for (int i = 0; i < labyrinth.LengthX; i++)
            {
                for (int j = 0; j < labyrinth.LengthY; j++)
                {
                    int randomNumber = this.randomInt.Next(2);
                    IGameObject currentObject;

                    if (randomNumber == 1)
                    {
                        currentObject = (Obstacle)obstacle.Clone();
                    } else
                    {
                        currentObject = (FreeSpace)freeSpace.Clone();
                    }

                    labyrinth[i, j] = currentObject;
                }
            }

            // bool thereIsWayOut = labyrinth.SolutionChecker(this.StartPosition);

            //if (!thereIsWayOut)
            //{
            //    ObstaclesGenerator(labyrinth);
            //}
        }
    }
}
