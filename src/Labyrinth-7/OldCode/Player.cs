﻿namespace Labyrinth_7.OldCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Responsible for the player current position, and player realated action
    /// </summary>
    public class Player
    {
        public const char PlayerCharacter = '*';

        private LabyrinthPosition currentPosition;

        public Player()
        {
            this.GetInitialPosition();
        }

        public LabyrinthPosition CurrentPosition
        {
            get
            {
                return this.currentPosition;
            }

            set
            {
                /* Maybe movement validation can be implemented through the setter e.g. check the space
                   around and make the turn if clear , else , display invalid turn */
                this.currentPosition = value;
            }
        }

        /* Or the moving logic can be completely implemented here */
        public void MakeTurnTo(LabyrinthPosition nextPosition)
        {
            throw new NotImplementedException("To be implemented");
        }

        private void GetInitialPosition()
        {
            throw new NotImplementedException("Make a reference to the initial position properties");
        }
    }
}
