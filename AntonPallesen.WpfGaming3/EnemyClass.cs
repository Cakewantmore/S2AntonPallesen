using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AntonPallesen.WpfGaming3
{
    public class EnemyClass
    {
        Random rnd = new Random();
        private string name;
        private int power;
        private int stamina;
        private int experience;
        private int currentHealth;
        private List<Ability> abilities;

        public string Name { get => name; set => name = value; }
        public int Power { get => power; set => power = value; }
        public int Stamina { get => stamina; set => stamina = value; }
        public int Experience { get => experience; set => experience = value; }
        public int CurrentHealth { get => currentHealth; set => currentHealth = value; }
        public List<Ability> Abilities { get => abilities; set => abilities = value; }

        public EnemyClass(string name, int power, int stamina, int experience)
        {
            Name = name;
            Power = power;
            Stamina = stamina;
            currentHealth = stamina;
            Experience = experience;
            
        }
        public EnemyClass(string name)
        {
            Name = name;
        }
        public EnemyClass()
        {

        }
        //EnemyClass box = new EnemyClass("Box", 10000, 10000, 0);
        //List<EnemyClass> enemies = new List<EnemyClass>();

        public int basicAttack()
        {
            int attackDamage = rnd.Next(0, Power + 1);
            return attackDamage;
        }
    }
}
