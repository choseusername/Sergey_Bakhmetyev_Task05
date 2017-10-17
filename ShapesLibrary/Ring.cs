using System;

namespace ShapesLibrary
{
    public class Ring : Round
    {
        private double _innerRadius;
        public double InnerRadius
        {
            get => _innerRadius;
            set
            {
                if (value > OuterRadius)
                    throw new Exception("The inner radius of the circle can not be greater than the outer.");
                _innerRadius = value;
            }
        }
        
        // A synonym for the "Radius" property
        public double OuterRadius
        {
            get => Radius;
            set => Radius = value;
        }

        public virtual double Area
        {
            get => base.Area - (Math.PI * Math.Pow(InnerRadius, 2));
        }

        public Ring(Point center, double outerRadius, double innerRadius) :
            base(center, outerRadius)
        {
            InnerRadius = innerRadius;
        }

        public override string ToString()
        {
            return string.Format("Ring. Coordinate of the center {0}," +
                " outer radius {1}, inner radius {2}, area {3}.",
                Center, OuterRadius, InnerRadius, Area);
        }
    }
}
