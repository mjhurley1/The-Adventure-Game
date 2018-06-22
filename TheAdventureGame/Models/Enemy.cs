using System;
using System.Collections.Generic;
using System.Text;

namespace TheAdventureGame.Models
{
    public class Enemy
    {
        public string Name { get; set; }
        public string EnemyClass { get; set; }
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();
        public int Health { get; set; }

    }
}
