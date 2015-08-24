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

        private Random randomInt = new Random();

        public Maze(uint sizeX, uint sizeY)
        {
            this.LengthX = sizeX;

            this.LengthY = sizeY;

            this.StartPosition = new Position(LengthX / 2, LengthY / 2);

            this.mazeData = new char[this.LengthX, this.LengthY];
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
                this.lengthX = value;
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

        public Position StartPosition { get; private set; }

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
            throw new NotImplementedException("Implement the Game.DisplayLabyrinth to display the maze content on the console");
        }

        public void GenerateObstacles()
        {
            // Implement the Game.LabyrinthGenerator and Game.SolutionChecker logic here
            for (uint i = 0; i < this.LengthX; i++)
            {
                for (uint j = 0; j < this.LengthY; j++)
                {
                    int randomNumber = this.randomInt.Next(2);

                    if (randomNumber == 0)
                    {
                        this[i, j] = '-';
                    }
                    else
                    {
                        this[i, j] = 'x';
                    }
                }
            }

            this[this.StartPosition] = Player.PlayerCharacter;

            bool thereIsWayOut = this.SolutionChecker(this.StartPosition);

            if (!thereIsWayOut)
            {
                this.GenerateObstacles();
            }
        }

        private bool SolutionChecker(Position current)
        {
            // if start position is surrounded by "x" (player can't move) - return to re-initiate the labyrinth

            if (this[current.Right] == '-' || 
                this[current.Down] == '-' || 
                this[current.Left] == '-' || 
                this[current.Up] == '-')
            {
                return true;
            }

            return false;
        }
    }
}
