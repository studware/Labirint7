using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.GameObjects
{
    public class Player : BaseObject
    {
        private const char defaultAppearance = '*';

        public Player(string nick)
            : base(defaultAppearance)
        {
            this.Nick = nick;
        }

        public Player(string nick, char appearance)
            : base(appearance)
        {
            this.Nick = nick;
        }

        public Player(string nick, char appearance, ConsoleColor foreground, ConsoleColor background)
            : base(appearance, foreground, background)
        {
            this.Nick = nick;
        }

        public string Nick { get; private set; }

        // Player should use an interface/abstraction to navigate through the labyrinth
        // public ILabyrinthNav LabyrinthNavigation { get; set; }
    }
}
