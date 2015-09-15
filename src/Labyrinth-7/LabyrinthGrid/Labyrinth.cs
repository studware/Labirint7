namespace Labyrinth_7.LabyrinthGrid
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Labyrinth_7.GameObjects;

    public class Labyrinth : IEnumerable
    {
        private IGameObject[,] labyrinthGrid;

        private Position startPosition;
        /// <summary>
        /// Creates a square labyrinth
        /// </summary>
        /// <param name="length">Length for the side of the labyrinth</param>
        public Labyrinth(int length)
        {
            this.LengthX = length;
            this.LengthY = length;

            this.labyrinthGrid = new IGameObject[length, length];
        }

        public int LengthY { get; private set; }

        public int LengthX { get; private set; }

        public virtual Position StartPosition
        {
            get
            {
                // Lazy Initialization of startPosition
                if (this.startPosition == null)
                {
                    this.startPosition = new Position(this.LengthX / 2, this.LengthY / 2);
                }

                return this.startPosition;
            }
        }

        // Added indexers for convinience latter
        public IGameObject this[Position position]
        {
            get
            {
                return this.labyrinthGrid[position.X, position.Y];
            }

            set
            {
                this.labyrinthGrid[position.X, position.Y] = value;
            }
        }

        // Added indexers for convinience latter
        public IGameObject this[int indexX, int indexY]
        {
            get
            {
                return this.labyrinthGrid[indexX, indexY];
            }

            set
            {
                this.labyrinthGrid[indexX, indexY] = value;
            }
        }

        public void SwapPositions(Position positionA, Position positionB)
        {
            IGameObject objA = this[positionA];
            IGameObject objB = this[positionB];

            this[positionA] = objB;
            this[positionB] = objA;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.LengthX; i++)
            {
                for (int j = 0; j < this.LengthY; j++)
                {
                    var current = this[i, j];
                    yield return current;
                }
            }
        }
    }
}
