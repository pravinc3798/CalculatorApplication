using CalculatorApplication;

namespace CalculatorTests
{
    public class CalculatorTestsUsingAnnotations
    {
        private Calculator Calculator;

        [SetUp]
        public void Setup()
        {
            Calculator = new Calculator();
        }

        [TestCase(5, 78.5375)]
        [TestCase(0, 0)]
        [TestCase(-5, 0)]
        public void Given_RadiusOfCircle_Returns_AreaOfCircle(double radius, double expectedArea)
        {
            // Act
            double actualArea = Calculator.AreaOfCircle(radius);

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001); // Allowing a small tolerance for floating-point comparison
        }

        [TestCase(4, 6, 24)]
        [TestCase(-4, 6, 0)]
        public void Given_LengthAndWidth_Returns_AreaOfRectangle(double length, double width, double expectedArea)
        {
            // Act
            double actualArea = Calculator.AreaOfRectangle(length, width);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestCase(4, 6, 20)]
        [TestCase(-4, 6, 0)]
        public void Given_LengthAndWidth_Returns_PerimeterOfRectangle(double length, double width, double expectedPerimeter)
        {
            // Act
            double actualPerimeter = Calculator.PerimeterOfRectangle(length, width);

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [TestCase(5, 31.415)]
        [TestCase(0, 0)]
        [TestCase(-5, 0)]
        public void Given_RadiusOfCircle_Returns_CircumferenceOfCircle(double radius, double expectedCircumference)
        {
            // Act
            double actualCircumference = Calculator.CircumferenceOfCircle(radius);

            // Assert
            Assert.AreEqual(expectedCircumference, actualCircumference, 0.001); // Allowing a small tolerance for floating-point comparison
        }
    }
}