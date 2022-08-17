using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void userCanDrink()
        {
            int age = 17;
            bool userCanDrink = false;

            if (age > 17)
            {
                Assert.AreEqual(userCanDrink, true);
            }
        }

        public void userCantDrink()
        {
            int age = 18;
            bool userCanDrink = false;

            if (age < 17)
            {
                Assert.AreEqual(userCanDrink, false);
            }
        }
    }
}
