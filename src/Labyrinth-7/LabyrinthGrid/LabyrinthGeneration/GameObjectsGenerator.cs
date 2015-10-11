using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labyrinth_7.GameObjects;
using Labyrinth_7.GameObjectsFactories;
using Labyrinth_7.RandomProviders;
using Labyrinth_7.ObjectFactories;

namespace Labyrinth_7.LabyrinthGrid.LabyrinthGeneration
{
    public class GameObjectsGenerator : IGameObjectsGenerator
    {
        private IRandom randomGenerator;

        public GameObjectsGenerator() : this(new RandomProvider())
        {
        }

        public GameObjectsGenerator(IRandom random)
        {
            this.randomGenerator = random;
        }

        public void GenerateObjects(Labyrinth labyrinth, Obstacle obstacle, FreeSpace freeSpace)
        {
            for (int i = 0; i < labyrinth.LengthX; i++)
            {
                for (int j = 0; j < labyrinth.LengthY; j++)
                {
                    int randomNumber = this.randomGenerator.Next(2);
                    IGameObject currentObject;

                    if (randomNumber == 1)
                    {
                        currentObject = (Obstacle)obstacle.Clone();
                    }
                    else
                    {
                        currentObject = (FreeSpace)freeSpace.Clone();
                    }

                    labyrinth[i, j] = currentObject;
                }
            }
        }

            public void GenerateObjectsNew(Labyrinth labyrinth, IObjectFactory factory)
        {
            for (int i = 0; i < labyrinth.LengthX; i++)
            {
                for (int j = 0; j < labyrinth.LengthY; j++)
                {
                    int randomNumber = this.randomGenerator.Next(2);
                    IGameObject currentObject;

                    if (randomNumber == 1)
                    {
                        currentObject = factory.GetObstacle();
                    } 
                    else
                    {
                        currentObject = factory.GetFreeSpace();
                    }

                    labyrinth[i, j] = currentObject;
                }
            }

            labyrinth[labyrinth.StartPosition] = factory.GetPlayerCell();



            // bool thereIsWayOut = labyrinth.SolutionChecker(this.StartPosition);

            //if (!thereIsWayOut)
            //{
            //    ObstaclesGenerator(labyrinth);
            //}
        }

    }
}
