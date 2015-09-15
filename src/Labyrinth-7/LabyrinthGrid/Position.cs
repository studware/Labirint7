namespace Labyrinth_7.LabyrinthGrid
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Position : IEquatable<Position>, ICloneable
    {
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        
        public int X { get; set; }

        public int Y { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public bool Equals(Position other)
        {
            return (this.X == other.X && 
                    this.Y == other.Y);
        }
    }
}
