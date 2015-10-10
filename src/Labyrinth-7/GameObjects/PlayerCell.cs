namespace Labyrinth_7.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Labyrinth_7.LabyrinthGrid;

    public class PlayerCell : BaseObject, IGameObject 
    {
        private const char defaultAppearance = '*';

        public PlayerCell():base(defaultAppearance)
        {
        }

        public PlayerCell(string nick, ILabyrinthNav navi)
            : base(defaultAppearance)
        {
            this.Nick = nick;
            this.LabyrinthNavigation = navi;
        }

        public PlayerCell(string nick, ILabyrinthNav navi, char appearance)
            : base(appearance)
        {
            this.Nick = nick;
            this.LabyrinthNavigation = navi;
        }

        public PlayerCell(string nick, ILabyrinthNav navi, char appearance, ConsoleColor foreground, ConsoleColor background)
            : base(appearance)//, foreground, background)
        {
            this.Nick = nick;
            this.LabyrinthNavigation = navi;
        }

        public string Nick { get; private set; }

        // Player should use an interface/abstraction to navigate through the labyrinth
        public ILabyrinthNav LabyrinthNavigation { get; set; }
    }
}
