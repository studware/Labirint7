using System;
using Labyrinth_7.GameObjects;

namespace Labyrinth_7.GameObjectsFactories
{
    public interface IGameObjectsFactory
    {
        IGameObject GetInstance();
    }
}
