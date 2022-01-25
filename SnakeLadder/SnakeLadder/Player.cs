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
        public int RolledDice;
        public void GamePlayed()
        {
            Random Random = new Random();
            RolledDice = Random.Next(1, 7);
            Console.WriteLine("player Roll  Dice number is:" + " " + RolledDice);
        }
    }
}
