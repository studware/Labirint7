using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.GameMechanics
{
    public class GameState
    {
        private static GameState singleton;

        private GameState()
        {
        }

        public static GameState Instance
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new GameState();
                }

                return singleton;
            }
        }

        public bool IsInitialized { get; private set; }
    }
}
