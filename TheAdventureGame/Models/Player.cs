using System;
using System.Collections.Generic;
using System.Text;

namespace TheAdventureGame.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public Weapon Weapon { get; set; }
        public int Health { get; set; }
    }
}
