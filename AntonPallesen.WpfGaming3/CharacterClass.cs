using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AntonPallesen.WpfGaming3
{
    public class CharacterClass : EnemyClass
    {
        Random rnd = new Random();
        
        
        private int maxExperience;
        private int level;
        
        public int MaxExperience { get => maxExperience; set => maxExperience = value; }
        public int Level { get => level; set => level = value; }
        

        public CharacterClass(string name):base(name)//,  int stamina, int experience)
        {
            base.Name = name;
            base.Power = rnd.Next(20, 800);
            base.Stamina = rnd.Next(100, 2000);
            MaxExperience = 1000;
            base.CurrentHealth = Stamina;
        }

        

        private void checkLevelUp()
        {
            if(Experience >= maxExperience)
            {
                level += 1;
                Experience = 0;
                maxExperience = (int)Math.Round(maxExperience * 1.5);
            }
        }
        
        private void getExp(int exp)
        {
            Experience += exp;
            checkLevelUp();
        }
       
    }
}
