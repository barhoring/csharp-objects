using System;

namespace TreehouseDefense
{
    class Point
    {
        public readonly int x;
        public readonly int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double DistanceTo(int x, int y)
        {
            int xDiff = this.x - x;
            int yDiff = this.y - y;

            int xDiffSquared = xDiff * xDiff;
            int yDiffSquared = yDiff * yDiff;

            return Math.Sqrt((double)(xDiffSquared + yDiffSquared));

        }
    }
}