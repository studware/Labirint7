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
            this.Reset();
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

        public bool IsInitialized { get; internal set; }

        public bool Completed { get; internal set; }

        public void Reset()
        {
            this.IsInitialized = false;
            this.Completed = false;
        }
    }
}
