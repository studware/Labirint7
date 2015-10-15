namespace Labyrinth_7.LabyrinthGrid
{
    using GameObjects;
    using System;

    public class LabyrinthNavigation : ILabyrinthNav
    {
        public LabyrinthNavigation(Labyrinth labyrinth)
        {
            this.Labyrinth = labyrinth;
            this.CurrentPosition = labyrinth.StartPosition;
        }

        public LabyrinthNavigation(Labyrinth labyrinth, Position position)
        {
            this.Labyrinth = labyrinth;
            this.CurrentPosition = position;
        }

        public Position CurrentPosition { get; private set; }

        public Labyrinth Labyrinth { get; private set; }

        public bool MoveChecker(Position position)
        {
            Labyrinth Labyrinth = this.Labyrinth;

            if (position.Column >= Labyrinth.Columns || position.Column < 0 ||
                position.Row >= Labyrinth.Rows || position.Row < 0)
            {
                return false;
            }
            else if(Labyrinth[position] is FreeSpace)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MoveDown()
        {
            var nextPosition = (Position)this.CurrentPosition.Clone();
            nextPosition.Column += 1;

            return MoveTo(nextPosition);
        }

        public bool MoveLeft()
        {
            var nextPosition = (Position)this.CurrentPosition.Clone();
            nextPosition.Row -= 1;

            return MoveTo(nextPosition);
        }

        public bool MoveRight()
        {
            var nextPosition = (Position)this.CurrentPosition.Clone();
            nextPosition.Row += 1;

            return false;
           
        }

        public bool MoveUp()
        {
            var nextPosition = (Position)this.CurrentPosition.Clone();
            nextPosition.Column -= 1;

            return MoveTo(nextPosition);
        }

        private bool MoveTo(Position position)
        {
            if(MoveChecker(position))
            {
                this.Labyrinth.SwapPositions(CurrentPosition, position);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
