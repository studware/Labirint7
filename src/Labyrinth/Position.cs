namespace Labyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Position
    {
        private uint x;

        private uint y;

        public Position(uint x, uint y)
        {
            this.X = x;
            this.Y = y;
        }
        
        public uint X { get; set; }

        public uint Y { get; set; }
    }
}
