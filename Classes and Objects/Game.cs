﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    public abstract class Game
    {
        public List<string> Players{ get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public void listPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
            
        }
    }
}
