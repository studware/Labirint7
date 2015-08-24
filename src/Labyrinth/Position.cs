namespace Labyrinth
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

        public bool Equals(Position other)
        {
            return (this.X == other.X && 
                    this.Y == other.Y);
        }
    }
}
