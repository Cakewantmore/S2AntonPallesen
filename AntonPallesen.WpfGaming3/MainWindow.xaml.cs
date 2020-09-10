using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AntonPallesen.WpfGaming3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //string path = @"C:\StreamReader\Enemies.txt";
        CharacterClass bob = new CharacterClass("");//, 0,0);
       
        List<EnemyClass> enemyList = new List<EnemyClass>();
        Database database = new Database();
        
        Random rnd = new Random();
        Battle battle = new Battle();
        EnemyClass currentEnemy;
        public MainWindow()
        {

            InitializeComponent();
            txtExperience.Text = bob.Experience.ToString();
            txtPower.Text = bob.Power.ToString();
            txtStamina.Text = bob.CurrentHealth.ToString() + " / " + bob.Stamina.ToString();
            progressHealth.Maximum = bob.Stamina;
            progressHealth.Value = bob.CurrentHealth;
            //enemyList = LogicClass.GetEnemyList();
            enemyList = database.GetEnemies();
            
            
            randomEnemy();
            updateEnemyStats();
            updatePlayerStats();
        }

        private void btnPlayer_Click(object sender, RoutedEventArgs e)
        {
            //currentEnemy.CurrentHealth -= 1000;
            //bob.CurrentHealth -= 50;
            battle.testingBattle(bob, currentEnemy);
            updateEnemyStats();
            updatePlayerStats();
            
            //progressHealth.Value = bob.CurrentHealth;
            //progressHealthEnemy.Value = currentEnemy.CurrentHealth;
            //btnPlayer.Visibility = Visibility.Hidden;
        }

        
        private void updatePlayerStats()
        {
            progressHealth.Value = bob.CurrentHealth;
            txtStamina.Text = bob.CurrentHealth.ToString() + " / " + bob.Stamina.ToString();
            progressHealth.Maximum = bob.Stamina;
        }
        private void randomEnemy()
        {
            int oiedns = rnd.Next(0, enemyList.Count);
            currentEnemy = enemyList[oiedns];
            
        }

        private void updateEnemyStats()
        {
            progressHealthEnemy.Value = currentEnemy.CurrentHealth;
            txtEnemyStamina.Text = currentEnemy.CurrentHealth.ToString() + " / " + currentEnemy.Stamina.ToString();
            progressHealthEnemy.Maximum = currentEnemy.Stamina;
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            if (combatCanvas.Visibility == Visibility.Hidden)
            {
                combatCanvas.Visibility = Visibility.Visible;
                createEnemyCanvas.Visibility = Visibility.Hidden;
            }
            else
            {
                combatCanvas.Visibility = Visibility.Hidden;
                createEnemyCanvas.Visibility = Visibility.Visible;
            }
        }

        private void makeEnemyConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            EnemyClass newEnemy = new EnemyClass();
            newEnemy.Name = makeEnemyName.Text;
            try
            {
                newEnemy.Power = int.Parse(makeEnemyPower.Text);
                newEnemy.Stamina = int.Parse(makeEnemyStamina.Text);
                newEnemy.Experience = int.Parse(makeEnemyExperience.Text);
                database.addNew(newEnemy);
            }
            catch(Exception EX)
            {
                MessageBox.Show("Du har lavet en fejl" + EX.Message);
            }
            
        }

        private void makeEnemyName_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (makeEnemyName.Text == "Name")
            {

                makeEnemyName.Text = String.Empty;
            }
            
        }
    }
}
