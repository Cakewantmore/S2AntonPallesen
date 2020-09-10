using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Documents;

namespace AntonPallesen.WpfGaming3
{
    public class Battle
    {
        public int testingBattle(CharacterClass a, EnemyClass b)
        {

            int enemyDamage = b.basicAttack();
            int playerDamage = a.basicAttack();
            Random rnd = new Random();
            int turnOrder = rnd.Next(0, 2);
            if (turnOrder == 0)
            {
                a.CurrentHealth -= enemyDamage;
                b.CurrentHealth -= playerDamage;

                //???
                //if ( a.CurrentHealth <= 0)
                //{
                //    return 0;
                //}
                //else
                //{
                //    
                //    b.CurrentHealth -= playerDamage;
                //    
                //}
            }

            else{

                b.CurrentHealth -= playerDamage;
                a.CurrentHealth -= enemyDamage;
                //???
                //if (b.CurrentHealth <= 0)
                //{
                //    return 0;
                //}
                //else
                //{
                //    a.CurrentHealth -= enemyDamage;
                //    
                //}
            }
            return 0;
        }
        
    }
}
