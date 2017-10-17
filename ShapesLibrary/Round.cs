using System;

namespace ShapesLibrary
{
    public class Round
    {
        public Point Center { get; set; }
        private double _radius;
        public double Radius {
            get => _radius;
            set
            {
                if (value < 0.0)
                    throw new Exception("The radius can not be less than 0");
                _radius = value;
            }
        }

        public double LengthCircumcircle => 2 * Math.PI * Radius;
        public virtual double Area => Math.PI * Math.Pow(Radius, 2);

        public Round(Point center, double radius)
        {
            Radius = radius;
            Center = center;
        }

        public override string ToString()
        {
            return string.Format("Coordinate of the center {0}, radius {1}", Center, Radius);
        }
    }
}
