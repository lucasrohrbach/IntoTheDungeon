using System;
using System.Collections.Generic;
using System.Xml.Linq;
using textGame;

namespace textGame
{
    class Gameplay
    {
        static void Main(string[] args)
        {
            var enemy = new Enemy("Enemy01", 300, 300, 50);
            var hero = new Hero("Hero01", 0, 1000, 50);
            var weapon = new Weapon("Sword", 40, 40, 40);
            hero.EquipWeapon(weapon);
            hero.AttackEnemy(enemy);
            hero.AttackEnemy(enemy);
           
            Console.WriteLine("XP: " + hero.Experience + " | " + "Health of " + hero.Name + ": " + hero.Health + " | " + "Health of enemy: " + enemy.Health + " | " + "Durability of " + weapon.Type + ": " + weapon.Durability + " | ");
        }
    }
}
