using System;
using System.Collections.Generic;
using System.Text;

namespace textGame
{
    class Hero
    {
        public string Name { get; set; }
        public string AttackPower { get; set; }
        public string SpecialPower { get; set; }
        public int Experience { get; set; }
        public int Health { get; set; }
        public int FullHealth { get; set; }
        public int Damage { get; set; }

        public Hero(string name, int experience, int fullHealth, int damage)
        {
            Name = name;
            Experience = experience;
            Health = fullHealth;
            FullHealth = fullHealth;
            Damage = damage;
        }

      

        public void AttackEnemy(Enemy enemy)
        {
           
            else if (weapon.Durability <= 0)
            {
                Console.WriteLine("My weapon has no more durability, I need a new one");
            }
            else if (Health > 100)
            {
                Console.WriteLine(Name + " attacks " + enemy.Name + " with " + Weapon.Type);
                Experience += 1;
                Enemy.health -=
                Weapon.Durability -= 1;
                if (Weapon.Strenght > 0)
                {
                    enemy.Health -= Weapon.Strenght;
                }
                if (enemy.Health == 0)
                {
                    Console.WriteLine(Name + " defeated " + enemy.Name);
                }
            }
            else
            {
                Console.WriteLine(Name + " doesn't have enought health. He needs a potion of regeneration.");
            }
        }
    }
}
