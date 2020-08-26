using System;
using System.Collections.Generic;
using System.Text;

namespace AntonPallesen.WpfGaming3
{
    public class Ability
    {
        private string name;
        private AbilityType type;

        public Ability(string name, AbilityType type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get => name; set => name = value; }
        public AbilityType Type { get => type; set => type = value; }
    }
}
