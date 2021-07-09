using System;
using System.Collections.Generic;
using System.Text;

namespace textGame
{
    class Weapon
    {
        public string Type { get; set; }
        public int Strenght { get; set; }
        public int Durability { get; set; }
        public int MaxDurability { get; set; }

        public Weapon(string type, int strenght, durability, double maxDurability)
        {
            Type = type;
            Strenght = strenght;
            Durability = durability;
            MaxDurability = maxDurability;
        }
    }
}
