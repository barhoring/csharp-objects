namespace TreehouseDefense
{
    class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        // returns true if the player wins, false otherwise
        public bool Play()
        {
            // run until all invaders neutrilized or an invader reachs the end of the path

            int remaniningInvaders = _invaders.Length;

            while(remaniningInvaders > 0){
                //  each tower has oppritunity to fire on invaders
                foreach (Tower tower in towers)
                {
                    tower.FireOnInvadors(_invaders);
                }
                
                // count and move the invaders that are still active
                remaniningInvaders = 0;
                
                foreach(Invader invader in _invaders){
                    if(invader.IsActive){
                        invader.Move();
                        if(invader.HasScored){
                            return false;
                        }
                        remaniningInvaders++;
                    }
                }
            }

            return true;            
        }

    }
}