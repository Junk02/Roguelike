using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    internal class Player
    {
        public string name { private set; get; }

        public Player(string name)
        {
            this.name = name;
        }
    }
}
