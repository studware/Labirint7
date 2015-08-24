namespace Labyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Maze
    {
        private uint lengthX;

        private uint lengthY;

        private char[,] mazeData;

        public Maze(uint sizeX, uint sizeY)
        {
            this.LengthX = sizeX;

            this.LengthY = sizeY;

            this.Initialize(this.LengthX, this.LengthY);
        }

        /// <summary>
        /// Creates a square labyrinth
        /// </summary>
        /// <param name="dimensions">Length for the side of the labyrinth</param>
        public Maze(uint dimensions)
        : this(dimensions, dimensions)
        {
        }

        public uint LengthX
        {
            get
            {
                return this.lengthX;
            }

            set
            {
                this.lengthY = value;
            }
        }

        public uint LengthY
        {
            get
            {
                return this.lengthY;
            }

            set
            {
                this.lengthY = value;
            }
        }

        // Added indexers for convinience latter
        public char this[Position position]
        {
            get
            {
                return this.mazeData[position.X, position.Y];
            }

            set
            {
                this.mazeData[position.X, position.Y] = value;
            }
        }

        // Added indexers for convinience latter
        public char this[uint indexX, uint indexY]
        {
            get
            {
                return this.mazeData[indexX, indexY];
            }

            set
            {
                this.mazeData[indexX, indexY] = value;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException("Implement a method to draw the maze content on the console");
        }

        private void Initialize(uint lengthX, uint lengthY)
        {
            throw new NotImplementedException("Implement the Game.LabyrinthGenerator and Game.SolutionChecker logic here");
        }
    }
}
