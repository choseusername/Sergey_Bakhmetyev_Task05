namespace Task2
{
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
    }
}
