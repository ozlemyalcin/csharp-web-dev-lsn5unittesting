using System;
using CarNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarTests

{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);//third argument .001 delta => the amount of allowed difference between the expected and actual values.//optioanl sometims//use espically doubles
              // void Assert.AreEqual(double expected, double actual, double delta)

        }

        //TODO: constructor sets gasTankLevel properly

        [TestMethod]
        public void TestGasTankLevel()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }


        [TestMethod]
        public void TestGasTankLevel2()
        {
            Car testObject = new Car("Toyota", "Pirius", 10, 50);
            //What is the functionalitty we are testing?
            //May need to call a method

            double expectedValue = 10;
            double actualValue = testObject.GasTankLevel;

            Assert.AreEqual(expectedValue, actualValue);

        }


        Car test_car;
        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50);
        }

      


        //TODO: gasTankLevel is accurate after driving within tank range

        [TestMethod]
        public void TestGasAfterDriving()
        {
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }



        //TODO: gasTankLevel is accurate after attempting to drive past tank range

        [TestMethod]
        public void TestGasAfterExceedingTankRange()
        {
            double maxDistance = test_car.MilesPerGallon * test_car.GasTankLevel;
            test_car.Drive(maxDistance);
            Assert.IsTrue(test_car.GasTankLevel == 0);

        }


        //TODO: can't have more gas than tank size, expect an exception

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void TestGasOverfillException()
        {
            test_car.AddGas(5);
            Assert.Fail("Should not get here, car cannot have more gas in tank than the size of the tank");
        }





    }
}
