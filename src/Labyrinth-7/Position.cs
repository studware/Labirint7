namespace Labyrinth_7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Position : IEquatable<Position>
    {
        public Position(uint x, uint y)
        {
            this.X = x;
            this.Y = y;
        }
        
        public uint X { get; set; }

        public uint Y { get; set; }

        /// <summary>
        /// returns the position to the right of the current position
        /// </summary>
        public Position Right
        {
            get
            {
                return new Position(this.X + 1, this.Y);
            }
        }

        /// <summary>
        /// returns the position bellow the current position
        /// </summary>
        public Position Down
        {
            get
            {
                return new Position(this.X, this.Y + 1);
            }
        }

        /// <summary>
        /// returns the position to the left of the current position
        /// </summary>
        public Position Left
        {
            get
            {
                return new Position(this.X - 1, this.Y);
            }
        }

        /// <summary>
        /// returns the position above the current position
        /// </summary>
        public Position Up
        {
            get
            {
                return new Position(this.X, this.Y - 1);
            }
        }

        public bool Equals(Position other)
        {
            return (this.X == other.X && 
                    this.Y == other.Y);
        }
    }
}
