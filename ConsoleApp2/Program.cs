using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string input = "";

            while (true)
            {
                Console.WriteLine("Guess a random number between 1 and 100. Press 'Q' to quit.");
                input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    break;
                }
                int actual = rnd.Next(1, 100);
                if (Convert.ToInt32(input) == actual) {
                    Console.WriteLine("correct");
                } else {
                    Console.WriteLine("You loose sucker. It was {0}", actual);
                }
            }
            Console.WriteLine("Game Over");
            Console.ReadLine();
        }
    }
}
