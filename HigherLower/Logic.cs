using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLower
{
    class Logic
    {
        protected uint max_rand = 0;//varible store maximal number to rand
        protected int drawn_int = 0;//varible store drawn number;
        protected bool drawn = false;//varible using to start game
        private bool won = false;//varible using to end game
        private bool shown_intro = false;//varible using to check if intro shown

        public Logic() { }

        public void SetUp(uint max_rand)
        {
            this.max_rand = max_rand;
            Random rnd = new Random();
            drawn_int = rnd.Next(1, (int)max_rand);
            drawn = true; won = false;
            rnd = null;
        }

        public void Game()
        {
            while (drawn == true && won == false)
            {
                if (shown_intro == false)
                    ShowIntro();
                CheckNumber();
            }
        }

        private void ShowIntro()
        {
            Console.WriteLine("--------Game started--------");
            Console.Write("Write number between 1 to " + max_rand.ToString() + " :");

            shown_intro = true;
        }

        private void CheckNumber()
        {
            uint number = new uint();
            if (uint.TryParse(Console.ReadLine(),out number))
            {
                if (number == drawn_int)
                {
                    Console.WriteLine("You won!");
                    won = true;
                }
                else
                if (number >= drawn_int)
                {
                    Console.WriteLine("Lower");
                }
                else
                if (number <= drawn_int)
                {
                    Console.WriteLine("Higher");
                }
            }
        }
 
    }
}
