﻿namespace Labyrinth_7.LabyrinthGrid.LabyrinthGeneration
{
    using Labyrinth_7.GameObjects;

    public abstract class LabyrinthBuilder
    {
        protected Labyrinth labyrinth;

        protected IGameObjectsGenerator gameObjectsGenerator;

        protected Config detailsConfiguration;

        public LabyrinthBuilder(IGameObjectsGenerator objectsGenerator, Config details)
        {
            this.gameObjectsGenerator = objectsGenerator;
            this.detailsConfiguration = details;
        }

        public Labyrinth Labyrinth
        {
            get
            {
                return this.labyrinth;
            }
        }

        public abstract void InitiateGrid();
        public abstract void AddObjects();
        public abstract void AddPlayer();

        public virtual bool TestIfSolvable()
        {
            var startPosition = this.labyrinth.StartPosition;

            if (this.labyrinth[startPosition.Column + 1, startPosition.Row] is FreeSpace ||
                this.labyrinth[startPosition.Column - 1, startPosition.Row] is FreeSpace ||
                this.labyrinth[startPosition.Column, startPosition.Row + 1] is FreeSpace ||
                this.labyrinth[startPosition.Column, startPosition.Row - 1] is FreeSpace)
            {
                return true;
            }
            else
            {
               return false;
            } 
        }
    }
}
