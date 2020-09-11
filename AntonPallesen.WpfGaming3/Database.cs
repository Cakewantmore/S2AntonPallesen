using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;

namespace AntonPallesen.WpfGaming3
{
    public class Database
    {
        private string connectionString = "Data Source=CV-BB-5910;Initial Catalog=S2Game;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private DataSet Execute(string query)
        {
            DataSet resultSet = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(query, new SqlConnection(connectionString))))
            {
                adapter.Fill(resultSet);
            }
            return resultSet;

        }
       public List<EnemyClass> GetEnemies()
        {
            List<EnemyClass> Result = new List<EnemyClass>();
            string allEnemiesQuery = "SELECT * FROM Enemies";

            DataSet resultSet = Execute(allEnemiesQuery);

            DataTable enemyTable = resultSet.Tables[0];
            
            foreach(DataRow enemyRow in enemyTable.Rows)
            {
                string enemyName = (string)enemyRow["Name"];
                int enemyPower = (int)enemyRow["Power"];
                int enemyStamina = (int)enemyRow["Stamina"];
                int enemyExperience = (int)enemyRow["Experience"];
                EnemyClass enemy = new EnemyClass();
                enemy.Name = enemyName;
                enemy.Power = enemyPower;
                enemy.Stamina = enemyStamina;
                enemy.CurrentHealth = enemyStamina;
                enemy.Experience = enemyExperience;
                Result.Add(enemy);
            }
            return Result;
        }

        public void addNew(EnemyClass enemy)
        {
            string addNewEnemyQuery = $"INSERT INTO Enemies (Name, Power, Stamina, Experience) VALUES('{enemy.Name}','{ enemy.Power}',' { enemy.Stamina} ',' { enemy.Experience}')";
            try
            {
                Execute(addNewEnemyQuery);
            }
            catch(Exception EX)
            {
                MessageBox.Show("Du har lavet en fejl" + EX.Message);
            }
        }
        public void deleteEnemy(EnemyClass enemy)
        {
            string deleteNewEnemyQuery = $"DELETE FROM Enemies WHERE Id = {enemy.Id}";
        }
    }
}
