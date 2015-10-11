namespace Labyrinth_7.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Labyrinth_7.LabyrinthGrid;

    public class PlayerPosition : BaseObject, IGameObject 
    {
        private const char defaultAppearance = '*';

        public PlayerPosition():base(defaultAppearance)
        {
        }

        public PlayerPosition(string nick, ILabyrinthNav navi)
            : base(defaultAppearance)
        {
            this.Nick = nick;
            this.LabyrinthNavigation = navi;
        }

        public PlayerPosition(string nick, ILabyrinthNav navi, char appearance)
            : base(appearance)
        {
            this.Nick = nick;
            this.LabyrinthNavigation = navi;
        }

        public PlayerPosition(string nick, ILabyrinthNav navi, char appearance, ConsoleColor foreground, ConsoleColor background)
            : base(appearance)//, foreground, background)
        {
            this.Nick = nick;
            this.LabyrinthNavigation = navi;
        }

        public string Nick { get; private set; }

        // Player should use an interface/abstraction to navigate through the labyrinth
        public ILabyrinthNav LabyrinthNavigation { get; set; }

        public override bool IsFree
        {
            get { return false; }
        }
    }
}
