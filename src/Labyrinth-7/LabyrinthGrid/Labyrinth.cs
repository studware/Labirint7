namespace Labyrinth_7.LabyrinthGrid
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Labyrinth_7.GameObjects;
    using Labyrinth_7.GameObjectsFactories;
    using Labyrinth_7.RandomProviders;
    using Labyrinth_7.LabyrinthGrid.LabyrinthStates;
    using Labyrinth_7.ObjectFactories;

    public class Labyrinth : IEnumerable
    {
        private IGameObject[,] labyrinthGrid;

        private Position startPosition;
        private Position currentPosition;

        /// <summary>
        /// Creates a square labyrinth
        /// </summary>
        /// <param name="length">Length for the side of the labyrinth</param>
        public Labyrinth(int length)
        {
            this.Columns = length;
            this.Rows = length;

            this.labyrinthGrid = new IGameObject[length, length];
        }

        public Labyrinth(int length, int width, IObjectFactory objectFactory)
        {
            this.Columns = length;
            this.Rows = length;

            this.labyrinthGrid = new IGameObject[length, width];
            this.ObjectFactory = objectFactory;
            this.CurrentPosition = this.StartPosition;
            this.State = new InitialState(this);
        }

        public State State { get; set; }
        public int Rows { get; private set; }

        public int Columns { get; private set; }

        public IObjectFactory ObjectFactory { get; set; }

        public virtual Position StartPosition
        {
            get
            {
                // Lazy Initialization of startPosition
                if (this.startPosition == null)
                {
                    this.startPosition = new Position(this.Columns / 2, this.Rows / 2);
                }

                return this.startPosition;
            }
        }

        public Position CurrentPosition { get; set; }

        // Added indexers for convinience latter
        public IGameObject this[Position position]
        {
            get
            {
                return this.labyrinthGrid[position.Row, position.Column];
            }

            set
            {
                this.labyrinthGrid[position.Column, position.Row] = value;
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
            for (int i = 0; i < this.Columns; i++)
            {
                for (int j = 0; j < this.Rows; j++)
                {
                    var current = this[i, j];
                    yield return current;
                }
            }
        }

        public bool SetPosition(IGameObject gameObject, int x, int y)
        {
            if (x < 0 || x >= this.Rows || y < 0 || y >= this.Columns)
            {
                throw new ArgumentOutOfRangeException("The position is not available in the Labyrinth");
            }

            this.labyrinthGrid[x, y] = gameObject;
            return true;
        }
    }
}
