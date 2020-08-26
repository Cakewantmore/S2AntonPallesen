using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AntonPallesen.WpfGaming3
{
    class LogicClass
    {
        //Fields
        
        string path = @"C:\StreamReader\Enemies.txt";
        private static List<string> logicEnemyList(string path)
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
            int lineNumber = 1;
            List<EnemyClass> newEnemy = EnemyArray(testEnemy);
            foreach ( var item in testEnemy)
            {
                lineNumber++;
                
            }
            return testEnemy;
        }
        private static List<EnemyClass> EnemyArray(List<string> numbers)
        {
            List<EnemyClass> newEnemy= new List<EnemyClass>();
            string[] input;
            foreach (var item in numbers)
            {
                input = SplitThings(item);
                //Convert strings to int
                string name = input[0];
                string comment = input[1];
                string howFar = input[2];

                //Create box object
                EnemyClass calculatedTest = new EnemyClass(name, comment, howFar);
                //Add box object to list
                fullGame.Add(calculatedTest);
            }
            return fullGame;
        }
        private static string[] SplitThings(string d)
        {
            string[] split = d.Split(',');
            return split;
        }
    }
}
