using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.GameMechanics.PlayerControls
{
    public class KeyBindings : IPlayControls, IGameControls
    {
        public ConsoleKey Up
        {
            get { throw new NotImplementedException(); }
        }

        public ConsoleKey Right
        {
            get { throw new NotImplementedException(); }
        }

        public ConsoleKey Down
        {
            get { throw new NotImplementedException(); }
        }

        public ConsoleKey Left
        {
            get { throw new NotImplementedException(); }
        }

        public void PrintControls()
        {
            throw new NotImplementedException();
        }

        public ConsoleKey Exit
        {
            get { throw new NotImplementedException(); }
        }

        public ConsoleKey Restart
        {
            get { throw new NotImplementedException(); }
        }

        public ConsoleKey Top
        {
            get { throw new NotImplementedException(); }
        }
    }
}
