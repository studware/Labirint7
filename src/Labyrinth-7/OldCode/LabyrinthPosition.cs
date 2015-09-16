namespace Labyrinth_7.OldCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LabyrinthPosition : IEquatable<LabyrinthPosition>
    {
        public LabyrinthPosition(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        
        public int X { get; set; }

        public int Y { get; set; }

        /// <summary>
        /// returns the position to the right of the current position
        /// </summary>
        public LabyrinthPosition Right
        {
            get
            {
                return new LabyrinthPosition(this.X + 1, this.Y);
            }
        }

        /// <summary>
        /// returns the position bellow the current position
        /// </summary>
        public LabyrinthPosition Down
        {
            get
            {
                return new LabyrinthPosition(this.X, this.Y + 1);
            }
        }

        /// <summary>
        /// returns the position to the left of the current position
        /// </summary>
        public LabyrinthPosition Left
        {
            get
            {
                return new LabyrinthPosition(this.X - 1, this.Y);
            }
        }

        /// <summary>
        /// returns the position above the current position
        /// </summary>
        public LabyrinthPosition Up
        {
            get
            {
                return new LabyrinthPosition(this.X, this.Y - 1);
            }
        }

        public bool Equals(LabyrinthPosition other)
        {
            return (this.X == other.X && 
                    this.Y == other.Y);
        }
    }
}
