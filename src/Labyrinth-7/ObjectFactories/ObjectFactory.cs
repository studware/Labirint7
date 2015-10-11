using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labyrinth_7.GameObjects;
using Labyrinth_7.LabyrinthGrid;
using Labyrinth_7.GameObjectsFactories;

namespace Labyrinth_7.ObjectFactories
{

    class ObjectFactory : IObjectFactory
    {
        public IGameObject GetFreeSpace()
        {
            IGameObjectsFactory freeSpaceFactory = new FreeSpaceFactory();
            return freeSpaceFactory.GetInstance();
        }

        public IGameObject GetObstacle()
        {
            IGameObjectsFactory obstacleFactory = new ObstaclesFactory();
            return obstacleFactory.GetInstance();
        }

        public IGameObject GetPlayerCell()
        {
            IGameObjectsFactory playerPositionFactory = new PlayerPositionFactory();
            return playerPositionFactory.GetInstance();
        }

        public IGameObject GetVisited()
        {
            IGameObjectsFactory visitedFactory = new VisitedCellFactory();
            return visitedFactory.GetInstance();
        }

        public Position GetPosition(int x, int y)
        {
            return new Position(x, y);
        }
    }
}
