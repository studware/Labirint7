namespace Labyrinth_7.LabyrinthGrid
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Position : IEquatable<Position>, ICloneable
    {
        public Position(int row, int column)
        {
            this.Column = column;
            this.Row = row;
        }
        
        public int Column { get; set; }

        public int Row { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public bool Equals(Position other)
        {
            return (this.Column == other.Column && 
                    this.Row == other.Row);
        }
    }
}
