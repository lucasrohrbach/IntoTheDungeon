using System;
using System.Collections.Generic;
using System.Text;

namespace textGame.Objects
{
    class HealthPotion
    {
        public string PotionName { get; set; }
        public int Effect { get; set; }

        public HealthPotion(string potionName, int effect)
        {
            PotionName = potionName;
            Effect = effect;
        }

        public void DrinkPotion(Hero hero)
        {

        }
    }
}
