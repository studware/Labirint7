using Labyrinth_7.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.GameObjectsFactories
{
    public abstract class GameObjectsFactory : Labyrinth_7.GameObjectsFactories.IGameObjectsFactory
    {
        private IGameObject gameObjectInstance;

        public IGameObject GetInstance()
        {
            if(this.gameObjectInstance ==null)
            {
                this.gameObjectInstance = this.CreateInstance();
                return this.gameObjectInstance;
            }

            return (IGameObject)this.gameObjectInstance.Clone();
        }

        protected abstract IGameObject CreateInstance();
    }
}
