using System;

namespace TreehouseDefense
{
    class Tower
    {
        private static readonly Random _rand = new Random();
        private static double _accuracy = 0.75;

        private readonly MapLocation _location;
        private const int _range = 1;
        private const int _power = 1;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IssuccessfulShot(){
            return _rand.NextDouble() < _accuracy;
        }

        public void FireOnInvadors(Invader[] invaders)
        {
            foreach(Invader invader in invaders){
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range)){
                    if(this.IssuccessfulShot()){
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("invader was hit");
                        if(invader.IsNeutralized){
                            Console.WriteLine("invader neutralized");
                        }
                        break;
                    }
                    else{
                        Console.WriteLine("missed");
                    }
                }
            }
        }
    } 
}