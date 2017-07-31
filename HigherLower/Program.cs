using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLower
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Write max number of randomize:");
            uint max = 0;
            if(uint.TryParse(Console.ReadLine(),out max))
            {
            Logic game = new Logic();
            game.SetUp(max);
                game.Game();

            game = null;
            }
            Console.ReadKey();
        }
    }
}
