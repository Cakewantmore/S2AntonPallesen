using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AntonPallesen.WpfGaming3
{
    public class Ability
    {
        Random rnd = new Random();
        private string name;
        
        private string desc;

        public Ability(string name, string desc)
        {
            Name = name;
            Desc = desc;
        }
        public virtual int useAbility(int Power, EnemyClass target)
        {
            return Power + rnd.Next(0, 2000);
        }
        public string Name { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }
    }
}
