using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labyrinth_7.GameObjects;

namespace Labyrinth_7.GameObjectsFactories
{
    public class CreateFreeSpace:GameObjectsFactory
    {
        protected override IGameObject CreateInstance()
        {
            return new FreeSpace();
        }
    }
}
