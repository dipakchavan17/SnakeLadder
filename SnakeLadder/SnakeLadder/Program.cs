﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to snake ladder");
            Player1 player = new Player1();
            player.playGame();
            Console.ReadLine();
        }
    }
}
