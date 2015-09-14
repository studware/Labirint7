using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.GameObjects
{
    /// <summary>
    /// Base object type to be used across the labyrinth grid in desired forms
    /// Using ConsoleColor couples this class to the Console but since this is a Console Application this should be somewhat OK
    /// </summary>
    public abstract class BaseObject
    {
        /// <summary>
        /// Default Constructor that sets the background and foreground colors of the object to black and white
        /// </summary>
        /// <param name="appearance"></param>
        public BaseObject(char appearance)
            : this (appearance, ConsoleColor.White, ConsoleColor.Black)
        {
        }

        public BaseObject(char appearance, ConsoleColor foreground, ConsoleColor background)
        {
            this.Visualization = appearance;
            this.ForegroundColor = foreground;
            this.BackgroundColor = background;
        }

        /// <summary>
        /// Determines the object symbol on the labyrinth grid
        /// </summary>
        public char Visualization { get; protected set; }

        /// <summary>
        /// The object foreground color
        /// </summary>
        public ConsoleColor ForegroundColor { get; protected set; }

        /// <summary>
        /// The object backround color
        /// </summary>
        public ConsoleColor BackgroundColor { get; protected set; }
    }
}
