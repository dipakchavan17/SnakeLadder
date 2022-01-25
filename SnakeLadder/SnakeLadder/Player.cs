using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class Player
    {
            public int Start = 0;
            public void GamePlayed()
            {
                Console.WriteLine("Game start now");

                Console.WriteLine("Starting point is " + Start); 
            }
        }
}
