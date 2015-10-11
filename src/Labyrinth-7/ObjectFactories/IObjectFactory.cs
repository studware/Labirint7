using Labyrinth_7.GameObjects;
using Labyrinth_7.GameObjectsFactories;
using Labyrinth_7.LabyrinthGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.ObjectFactories
{
    public interface IObjectFactory
    {
        IGameObject GetFreeSpace();
        IGameObject GetObstacle();
        IGameObject GetPlayerCell();
        IGameObject GetVisited();
        Position GetPosition(int x, int y);
    }
}
