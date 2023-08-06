using System;

namespace CalculateTheAreaTest
{
    public class Triangle : Shape
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }
        public override double Square()
        {
            double semiPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _firstSide) * (semiPerimeter - _secondSide) * (semiPerimeter - _thirdSide));

        }
        public bool IsRight()
        {
            return ((Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2)) == Math.Pow(_thirdSide, 2)) ||
                    ((Math.Pow(_thirdSide, 2) + Math.Pow(_secondSide, 2)) == Math.Pow(_firstSide, 2)) ||
                    ((Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2)) == Math.Pow(_secondSide, 2));
        }
    }
}
