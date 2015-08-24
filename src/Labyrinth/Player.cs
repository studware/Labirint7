namespace Labyrinth
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Responsible for the player current position, and player realated action
    /// </summary>
    internal class Player
    {
        public const char PlayerCharacter = '*';

        private Position currentPosition;

        public Player()
        {
            this.GetInitialPosition();
        }

        private void GetInitialPosition()
        {
            throw new NotImplementedException("Make a reference to Game initial position properties");
        }

        /* Maybe movement validation can be implemented through the setter e.g. check the space
        around and make the turn if clear , else , display invalid turn */
        public Position CurrentPosition { get; set; }

        /* Or the moving logic can be completely implemented here */
        public void MakeTurnTo(Position nextPosition)
        {
            throw new NotImplementedException("To be implemented");
        }
    }
}
