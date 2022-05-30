namespace Geometric_experience
{
    class Point
    {
        private int X;
        private int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"{X} {Y}";
        }
    }
}
