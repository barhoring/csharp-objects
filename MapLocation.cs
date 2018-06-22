namespace TreehouseDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if(!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + "," + y +  " oops... this point is not on the map");
            }
        }
    }
}