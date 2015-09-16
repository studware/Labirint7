namespace Labyrinth_7.OldCode
{
    using System;

    public class Labyrinth
    {
        // For now this should be odd nummbers (original value was odd number)
        public const int LabyrinthRowLength = 7;

        // For now this should be odd nummbers (original value was odd number)
        public const int LabyrinthColumnLength = 7;

        //Depends on LabyrinthRowLength
        public int GameStartRow = LabyrinthRowLength / 2;

        //Depends on LabyrinthColumnLength
        public static int GameStartColumn = LabyrinthColumnLength / 2;
        
        private int lengthX;

        private int lengthY;

        private char[,] labyrinthData;

        private Random randomInt = new Random();

        public Labyrinth(int sizeX, int sizeY)
        {
            this.LengthX = sizeX;

            this.LengthY = sizeY;

            this.StartPosition = new LabyrinthPosition(LengthX / 2, LengthY / 2);

            this.labyrinthData = new char[this.LengthX, this.LengthY];
        }

        /// <summary>
        /// Creates a square labyrinth
        /// </summary>
        /// <param name="dimensions">Length for the side of the labyrinth</param>
        public Labyrinth(int dimensions)
        : this(dimensions, dimensions)
        {
        }

        public int LengthX
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

        public int LengthY
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

        public LabyrinthPosition StartPosition { get; private set; }

        // Added indexers for convinience latter
        public char this[LabyrinthPosition position]
        {
            get
            {
                return this.labyrinthData[position.X, position.Y];
            }

            set
            {
                this.labyrinthData[position.X, position.Y] = value;
            }
        }

        // Added indexers for convinience latter
        public char this[int indexX, int indexY]
        {
            get
            {
                return this.labyrinthData[indexX, indexY];
            }

            set
            {
                this.labyrinthData[indexX, indexY] = value;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException("Implement the Game.DisplayLabyrinth to display the labyrinth content on the console");
        }

        public void GenerateObstacles()
        {
            // Implement the Game.LabyrinthGenerator and Game.SolutionChecker logic here
            for (int i = 0; i < this.LengthX; i++)
            {
                for (int j = 0; j < this.LengthY; j++)
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

        private bool SolutionChecker(LabyrinthPosition current)
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
