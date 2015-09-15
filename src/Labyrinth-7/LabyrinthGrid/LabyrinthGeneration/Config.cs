using System;

namespace Labyrinth_7.LabyrinthGrid.LabyrinthGeneration
{
    public class Config
    {
        private const ConsoleColor DefaultForeground = ConsoleColor.White;

        private const ConsoleColor DefaultBackground = ConsoleColor.Black;

        private const string DefaultPlayerNick = "Unknown Wanderer";

        public Config()
        {
            this.PlayerNick = DefaultPlayerNick;

            this.PlayerVisualization = '*';
            this.PlayerForegroundColor = DefaultForeground;
            this.PlayerBackgroundColor = DefaultBackground;

            this.FreeSpaceVisualization = '-';
            this.FreeSpaceForegroundColor = DefaultForeground;
            this.FreeSpaceBackgroundColor = DefaultBackground;

            this.ObstacleVisualization = 'x';
            this.ObstacleForegroundColor = DefaultForeground;
            this.ObstacleBackgroundColor = DefaultBackground;
        }

        public ILabyrinthNav LabyrinthNavigation { get; set; }

        public string PlayerNick { get; set; }
        
        public char PlayerVisualization { get; set; }
        public ConsoleColor PlayerForegroundColor { get; set; }
        public ConsoleColor PlayerBackgroundColor { get; set; }

        public char FreeSpaceVisualization { get; set; }
        public ConsoleColor FreeSpaceForegroundColor { get; set; }
        public ConsoleColor FreeSpaceBackgroundColor { get; set; }

        public char ObstacleVisualization { get; set; }
        public ConsoleColor ObstacleForegroundColor { get; set; }
        public ConsoleColor ObstacleBackgroundColor { get; set; }
    }
}