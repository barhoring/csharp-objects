using System;

namespace TreehouseDefense
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);
            try
            {
                Point x = new MapLocation(7, 6, map);    
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TreehouseDefeseException)
            {
                Console.WriteLine("Unhandles TreehouseDefenseException");
            }
            catch (Exception)
            {
                Console.WriteLine("Unhandles Exception");
            }

            // Point y = new MapLocation(7, 6, map); 
            
        }
    }
}
