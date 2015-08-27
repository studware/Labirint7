using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_7
{
  /// <summary>
  /// The 'NavigationContext' class
  /// </summary>
  class NavigationContext
  {
    private NavigationStrategy navigationStrategy;
    public NavigationContext(NavigationStrategy strategy) 
    {
        this.navigationStrategy = strategy;
    }

    public void NavigationContextInterface()
    {
        navigationStrategy.TryMove(Labyrinth labyrinth, ref bool gameInProgress, ref uint row, ref uint col);
    }
  }
}