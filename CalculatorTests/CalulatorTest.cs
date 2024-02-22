using CalculatorApplication;

namespace CalculatorTests
{
    public class CalulatorTest
    {
        public Calculator Calculator = new Calculator();

        [Test]
        public void Given_RadiusOfCircle_Returns_AreaOfCircle()
        {
            // Arrange
            double radius = 5;
            double expectedArea = 78.5375; // Expected area for radius of 5

            // Act
            double actualArea = Calculator.AreaOfCircle(radius);

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001); // Allowing a small tolerance for floating-point comparison
        }

        [Test]
        public void Given_ZeroRadius_Returns_ZeroAreaOfCircle()
        {
            // Arrange
            double radius = 0;
            double expectedArea = 0;

            // Act
            double actualArea = Calculator.AreaOfCircle(radius);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void Given_NegativeRadius_Returns_ZeroAreaOfCircle()
        {
            // Arrange
            double radius = -5;
            double expectedArea = 0;

            // Act
            double actualArea = Calculator.AreaOfCircle(radius);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void Given_LengthAndWidth_Returns_AreaOfRectangle()
        {
            // Arrange
            double length = 4;
            double width = 6;
            double expectedArea = 24;

            // Act
            double actualArea = Calculator.AreaOfRectangle(length, width);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void Given_NegativeLengthOrWidth_Returns_ZeroAreaOfRectangle()
        {
            // Arrange
            double length = -4;
            double width = 6;
            double expectedArea = 0;

            // Act
            double actualArea = Calculator.AreaOfRectangle(length, width);

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void Given_LengthAndWidth_Returns_PerimeterOfRectangle()
        {
            // Arrange
            double length = 4;
            double width = 6;
            double expectedPerimeter = 20;

            // Act
            double actualPerimeter = Calculator.PerimeterOfRectangle(length, width);

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void Given_NegativeLengthOrWidth_Returns_ZeroPerimeterOfRectangle()
        {
            // Arrange
            double length = -4;
            double width = 6;
            double expectedPerimeter = 0;

            // Act
            double actualPerimeter = Calculator.PerimeterOfRectangle(length, width);

            // Assert
            Assert.AreEqual(expectedPerimeter, actualPerimeter);
        }

        [Test]
        public void Given_RadiusOfCircle_Returns_CircumferenceOfCircle()
        {
            // Arrange
            double radius = 5;
            double expectedCircumference = 31.415; // Expected circumference for radius of 5

            // Act
            double actualCircumference = Calculator.CircumferenceOfCircle(radius);

            // Assert
            Assert.AreEqual(expectedCircumference, actualCircumference, 0.001); // Allowing a small tolerance for floating-point comparison
        }

        [Test]
        public void Given_ZeroRadius_Returns_ZeroCircumferenceOfCircle()
        {
            // Arrange
            double radius = 0;
            double expectedCircumference = 0;

            // Act
            double actualCircumference = Calculator.CircumferenceOfCircle(radius);

            // Assert
            Assert.AreEqual(expectedCircumference, actualCircumference);
        }

        [Test]
        public void Given_NegativeRadius_Returns_ZeroCircumferenceOfCircle()
        {
            // Arrange
            double radius = -5;
            double expectedCircumference = 0;

            // Act
            double actualCircumference = Calculator.CircumferenceOfCircle(radius);

            // Assert
            Assert.AreEqual(expectedCircumference, actualCircumference);
        }
    }
}