using AntonPallesen.WpfGaming3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class DatabaseTest
    {
        [TestMethod]
        public void CheckEnemyDatabase()
        {
            Database databaseTest = new Database();
            List<EnemyClass> testEnemyList = databaseTest.GetEnemies();
            int powerResult = testEnemyList[0].Power;
            
            
            Assert.AreEqual(10000, powerResult);
        }
    }
}
