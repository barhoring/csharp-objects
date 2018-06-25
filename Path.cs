namespace TreehouseDefense
{
    class Path
    {
        private readonly MapLocation[] _path;
        public int Length =>_path.Length;
        public Path(MapLocation[] path){
            this._path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < this._path.Length) ? this._path[pathStep] : null;
        }
    }
}