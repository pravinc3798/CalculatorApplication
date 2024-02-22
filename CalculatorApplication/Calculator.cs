namespace CalculatorApplication
{
    public class Calculator
    {
        private static double _pi = 3.1415;

        public double AreaOfCircle(double radius)
        {
            if (radius <= 0)
                return 0;

            double area = _pi * Math.Pow(radius, 2);

            return area;
        }

        public double CircumferenceOfCircle(double radius)
        {
            if (radius <= 0)
                return 0;

            double circumference = 2 * _pi * radius;

            return circumference;
        }

        public double AreaOfRectangle(double length, double width)
        {
            if (length <= 0 || width <= 0)
                return 0;

            double area = length * width;

            return area;
        }

        public double PerimeterOfRectangle(double length, double width)
        {
            if (length <= 0 || width <= 0)
                return 0;

            double perimeter = 2 * (length + width);

            return perimeter;
        }
    }
}
