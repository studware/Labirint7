using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7.RandomProviders
{
    public class RandomProvider:IRandom
    {
        private Random randomProvider;

        public RandomProvider():this(new Random())
        {
        }

        public RandomProvider(Random random)
        {
            this.randomProvider = random;
        }

        public int Next(int maxValue)
        {
            return randomProvider.Next(maxValue);
        }
    }
}
