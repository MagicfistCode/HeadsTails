using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsTails
{
    public class HeadsTailsGenerator
    {
        //Creating heads or tails method where int "flip" can be changed
        public void HeadsOrTails(int flips)
        {
            //declaring heads and tails variables
            int heads = 0, tails = 0;

            //creating a random class
            var rand = new Random();

            int i = 0;
            //loop will keep going until the number of flips declared is reached
            while (i < flips)
            {
                //creating a headsOrTails variable where it can be either 0 or 1
                int headsOrTails = rand.Next(0, 2);
                //if statement based on what happens if headsOrTails is 0 or 1
                if (headsOrTails == 0)
                {
                    //heads is incremented by 1
                    heads++;
                    //a message saying the user got heads
                    Console.WriteLine("You got heads!");
                    //the user has to enter a key to flip again
                    Console.ReadLine();
                }
                else
                {
                    //tails is incremented by 1
                    tails++;
                    //a message saying the user got tails
                    Console.WriteLine("You got tails!");
                    //the user has to enter a key to flip again
                    Console.ReadLine();
                }
                //i is incremented by 1
                i++;
            }

            //the user receives a message of how many times they got heads or tails
            Console.WriteLine("You got heads " + heads + " times!\n" +
                              "You got tails " + tails + " times!");
        }
    }
}
