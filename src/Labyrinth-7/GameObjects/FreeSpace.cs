﻿namespace Labyrinth_7.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FreeSpace : BaseObject, IGameObject, ICloneable
    {
        private const char symbol = '-';

        public FreeSpace()
            : this(symbol)
        {
        }

        public FreeSpace(char appearance)
            : base(appearance)
        {
        }

        //public FreeSpace(char appearance, ConsoleColor fore, ConsoleColor back)
        //    : base(appearance, fore, back)
        //{
        //}

        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}

        public override bool IsFree
        {
            get { return true; }
        }
    }
}
