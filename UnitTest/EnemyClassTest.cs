using AntonPallesen.WpfGaming3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class EnemyClassTest
    {
        [TestMethod]
        public void AttackTest()
        {
            EnemyClass enemyTest = new EnemyClass();
            
            
            int maxPower = 10000;
            enemyTest.Power = maxPower;
            Assert.AreEqual(5000, enemyTest.basicAttack(), 5000);

        }

    }
}
