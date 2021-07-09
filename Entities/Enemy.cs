using System;
using System.Collections.Generic;
using System.Text;


namespace textGame
{
    class Enemy
    {
        public string Name { get; set; }
        public string Angriff { get; set; }
        public string SpecialAttack { get; set; }
        public int SpellSlots { get; set; }
        public int Health { get; set; }
        public int FullHealth { get; set; }
        public int Damage { get; set; }

        public Enemy(string name, int health, int fullHealth, int damage)
        {
            Name = name;
            Health = health;
            FullHealth = fullHealth;
            Damage = damage;
        }

        public void Attack(Hero hero)
        {
            Console.WriteLine(Name + "attacks" + hero.Name + "with his fist");
        }
    }
}


