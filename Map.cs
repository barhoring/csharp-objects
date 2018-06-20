namespace TreehouseDefense
{
    class Map
    {
        public readonly int width;
        public readonly int height;

        public Map(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public bool OnMap(Point point)
        {
            return point.x >= 0 && point.x < this.width &&
                   point.y >=0 && point.y < this.height;
        }

    }
}