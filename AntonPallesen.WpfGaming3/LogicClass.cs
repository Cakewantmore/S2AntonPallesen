using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AntonPallesen.WpfGaming3
{
    class LogicClass
    {
        //Fields
        
        static string path = @"C:\StreamReader\Enemies.txt";
        public static List<string> logicEnemyList(string path)
        {
            List<string> testEnemy = new List<string>();
            
            using (StreamReader reader = new StreamReader(path, Encoding.Default))
            {
                string input = "";
                while((input = reader.ReadLine()) != null)
                {
                    testEnemy.Add(input);
                }
            }
            
            
            
            return testEnemy;
        }

        public static List<EnemyClass> EnemyArray(List<string> numbers)
        {
            List<EnemyClass> newEnemy = new List<EnemyClass>();
            string[] input;
            foreach (var item in numbers)
            {
                input = SplitThings(item);
                //Convert strings to int
                string enemyName = input[0];
                int.TryParse(input[1], out int enemyPower);
                int.TryParse(input[2], out int enemyStamina);
                int.TryParse(input[3], out int enemyExperience);

                //Create box object
                EnemyClass calculatedTest = new EnemyClass(enemyName, enemyPower, enemyStamina, enemyExperience);
                //Add box object to list
                newEnemy.Add(calculatedTest);
            }
            return newEnemy;
        }
        private static string[] SplitThings(string d)
        {
            string[] split = d.Split(',');
            return split;
        }
        public static List<EnemyClass> GetEnemyList()
        {
            List<EnemyClass> newEnemy = new List<EnemyClass>();
            newEnemy = EnemyArray(logicEnemyList(path));
            return newEnemy;       }
    }
}
