namespace Example3.Test
{
    [TestFixture]
    public class Tests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void IsExpressionValid_ValidExpression_ReturnsTrue()
        {
            string expression = "2 + 3 * (4 - 1)";
            bool result = calculator.IsExpressionValid(expression);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsExpressionValid_InvalidExpression_ReturnsFalse()
        {
            string expression = "2 + * 3";
            bool result = calculator.IsExpressionValid(expression);
            Assert.IsFalse(result);
        }

        [Test]
        public void InfixToPostfix_ValidExpression_ReturnsPostfixExpression()
        {
            string infixExpression = "3 + 4 * 2 / (1 - 5)";
            string result = calculator.InfixToPostfix(infixExpression);
            Assert.AreEqual("3 4 2 * 1 5 - / +", result);
        }

        [Test]
        public void CalculatePostfixExpression_ValidExpression_ReturnsResult()
        {
            string postfixExpression = "3 4 2 * 1 5 - / +";
            double result = calculator.CalculatePostfixExpression(postfixExpression);
            Assert.AreEqual(-1.0, result);
        }


        [Test]
        public void CalculatePostfixExpression_DivideByZero_ThrowsException()
        {
            string postfixExpression = "2 0 /";
            Assert.Throws<DivideByZeroException>(() => calculator.CalculatePostfixExpression(postfixExpression));
        }
    }
}