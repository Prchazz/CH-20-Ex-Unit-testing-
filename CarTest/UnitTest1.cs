using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClass;
namespace CarTest
{
    [TestClass]
    public class UnitTest1

    {
        Car test_car;

        [TestInitialize]

        public void CreateAInstanceOfCar()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);
        }
        [TestMethod]//TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }

        [TestMethod]//TODO: constructor sets gasTankLevel properly
        public void TestInitialGasTank()

        {
            Car test_car = new Car ("Toyota", "Prius", 10, 50);
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }
        [TestMethod]//TODO: gasTankLevel is accurate after driving within tank range
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        public void GasTankLevel()
        {
            Car test_car = new Car ("Toyota", "Prius", 10, 50);
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }

        //[TestMethod]//TODO: can't have more gas than tank size, expect an exception
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void TestGasOverfillException()
        //{
        //    //Car test_car = new Car ("Toyota", "Prius", 10, 50);
        //    //Assert.AreEqual(0, test_car.GasTankLevel, .001);
        //    test_car.AddGas(-10);
        //    Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
        //}
         
    
        


    }
}
