using System;

namespace TreehouseDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public bool HasScored => _pathStep >= _path.Length;
        public bool IsNeutralized => health <= 0;
        public bool IsActive => !(IsNeutralized || HasScored);

        public int health { get; private set; } = 2;

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += 1;
        public void DecreaseHealth(int factor)
        {
            health -= factor;
        }
    }
}