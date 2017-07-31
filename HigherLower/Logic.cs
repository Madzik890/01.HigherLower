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

        public Logic() { }//default constructor

        public void SetUp(uint max_rand)//setting up a logic to game
        {
            this.max_rand = max_rand;
            Random rnd = new Random();
            drawn_int = rnd.Next(1, (int)max_rand);
            drawn = true; won = false;
            rnd = null;
        }

        public void Game()//main function
        {
            while (drawn == true && won == false)
            {
                if (shown_intro == false)
                    ShowIntro();
                CheckNumber();
            }
        }

        private void ShowIntro()//showing intro only once
        {
            Console.WriteLine("--------Game started--------");
            Console.Write("Write number between 1 to " + max_rand.ToString() + " :");

            shown_intro = true;//for not showing intro int other steps
        }

        private void CheckNumber()//main logic function wich checking number
        {
            uint number = new uint();//temp number

            if (uint.TryParse(Console.ReadLine(),out number))//if user wrote a number 
            {
                if (number == drawn_int)//if wrote number is equal to drawn number
                {
                    Console.WriteLine("You won!");//won!
                    won = true;//to end main loop
                }
                else
                if (number > drawn_int)//if wrote number is higher than drawn number
                    Console.WriteLine("Lower");
                else
                if (number < drawn_int)//if wrote number is lower than drawn number
                    Console.WriteLine("Higher");
            }
        }
 
    }
}
