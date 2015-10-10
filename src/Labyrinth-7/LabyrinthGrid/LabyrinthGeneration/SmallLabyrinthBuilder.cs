namespace Labyrinth_7.LabyrinthGrid.LabyrinthGeneration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Labyrinth_7.GameObjects;

    public class SmallLabyrinthBuilder : LabyrinthBuilder
    {
        private const int length = 7;

        public SmallLabyrinthBuilder(IGameObjectsGenerator objectsGenerator, Config details)
            :base (objectsGenerator, details)
        {
        }

        public SmallLabyrinthBuilder() : this(new GameObjectsGenerator(), new Config())
        {
        }

        public override void AddPlayer()
        {
            ILabyrinthNav navi;
            if (this.detailsConfiguration.LabyrinthNavigation != null)
            {
                navi = this.detailsConfiguration.LabyrinthNavigation;
            } 
            else
            {
                navi = new LabyrinthNavigation(this.labyrinth);
            }

            var player = new PlayerCell(
                this.detailsConfiguration.PlayerNick
                , navi
                , this.detailsConfiguration.PlayerVisualization
                , this.detailsConfiguration.PlayerForegroundColor
                , this.detailsConfiguration.PlayerBackgroundColor);

            Position startPosition = this.labyrinth.StartPosition;
            this.labyrinth[startPosition] = player;
        }

        public override void InitiateGrid()
        {
            this.labyrinth = new Labyrinth(length);
        }

        public override void AddObjects()
        {
            var obstacleTemplate = new Obstacle(
                this.detailsConfiguration.ObstacleVisualization);
                //, this.detailsConfiguration.ObstacleForegroundColor
                //, this.detailsConfiguration.ObstacleBackgroundColor);

            var freeSpaceTemplate = new FreeSpace(
                this.detailsConfiguration.FreeSpaceVisualization);
                //, this.detailsConfiguration.FreeSpaceForegroundColor
                //, this.detailsConfiguration.FreeSpaceBackgroundColor);

            this.gameObjectsGenerator.GenerateObjects(this.labyrinth, obstacleTemplate, freeSpaceTemplate);
        }
    }
}
