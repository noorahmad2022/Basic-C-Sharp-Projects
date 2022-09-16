using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    public class TwentyOneGame :Game , IWalkAway  // to inherent a class
    {
        public void Play()
        {
            Console.WriteLine("Welcome to TwentyOneGame");
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
