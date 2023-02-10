using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HearthstoneSpaceGame_CompApp
{
    public class Card
    {
        public string name;
       
        public int attack = 5;
        public int defend = 0;
        public int health = 6;
        public int cost = 3;
        public Image image = null;
    }
}
