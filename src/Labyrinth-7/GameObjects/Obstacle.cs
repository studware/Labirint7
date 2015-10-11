namespace Labyrinth_7.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Obstacle : BaseObject, IGameObject, ICloneable
    {
        private const char symbol = 'X';

        public Obstacle():this(symbol)
        {
        }

        public Obstacle(char appearance) : base(appearance)
        {
        }

        //public Obstacle(char appearance, ConsoleColor fore, ConsoleColor back)
        //    : base(appearance, fore, back)
        //{
        //}

        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}

        public override bool IsFree
        {
            get { return false; }
        }
    }
}
