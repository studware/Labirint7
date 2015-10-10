using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.GameObjects
{
    class VisitedCell:BaseObject, IGameObject,ICloneable
    {
        private const char symbol = '^';

        public VisitedCell():this(symbol)
        {
        }

        public VisitedCell(char appearance):base(appearance)
        {
        }
        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}
    }
}
