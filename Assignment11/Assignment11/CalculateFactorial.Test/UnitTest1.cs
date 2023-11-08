namespace CalculateFactorial.Test
{
    [TestFixture]
    public class Tests
    {
        private FactorialCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new FactorialCalculator();
        }

        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(5, 120)]
        public void CalculateFactorial_ValidInput_ReturnsCorrectResult(int input, int expected)
        {
            int result = calculator.CalculateFactorial(input);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-5)]
        public void CalculateFactorial_NegativeInput_ThrowsException(int input)
        {
            Assert.Throws<ArgumentException>(() => calculator.CalculateFactorial(input));
        }
    }
}