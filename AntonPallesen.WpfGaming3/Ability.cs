using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AntonPallesen.WpfGaming3
{
    public class Ability
    {
        private string name;
        private AbilityType type;
        private string desc;

        public Ability(string name, AbilityType type)
        {
            Name = name;
            Type = type;
        }
        public Ability(int Ability1)
        {
            if(Ability1 == 0)
            {
                this.Name = "Fire";

            }
        }
        public string Name { get => name; set => name = value; }
        public AbilityType Type { get => type; set => type = value; }
    }
}
