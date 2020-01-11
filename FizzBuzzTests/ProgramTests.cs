using Microsoft.VisualStudio.TestTools.UnitTesting;
using static FizzBuzz.Program;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void CalculateFizzBuzzTestFizzWhenInputDivisibleByThree() => AreEqual("Fizz", CalculateFizzBuzz(3));

        [TestMethod]
        public void CalculateFizzBuzzTestBuzzWhenInputDivisibleByFive() => AreEqual("Buzz", CalculateFizzBuzz(5));

        [TestMethod]
        public void CalculateFizzBuzzTestFizzBuzzWhenInputDivisibleByThreeAndFive() => AreEqual("FizzBuzz", CalculateFizzBuzz(30));
    }
}