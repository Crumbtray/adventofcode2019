using NUnit.Framework;
using One;

namespace OneTests
{
    public class Tests
    {
        [TestCase(12, 2)]
        [TestCase(14, 2)]
        [TestCase(1969, 654)]
        [TestCase(100756, 33583)]
        public void FuelTests(int mass, int expected)
        {
            var result = Calculator.GetFuel(mass);
            Assert.AreEqual(expected, result);
        }

        [TestCase(14, 2)]
        [TestCase(1969, 966)]
        [TestCase(100756, 50346)]
        public void FuelForFuelTests(int mass, int expected)
        {
            var fuel = Calculator.GetFuel(mass);
            var fuelForFuel = Calculator.GetFinalFuelForFuel(fuel);

            Assert.AreEqual(expected, fuelForFuel);
        }
    }
}