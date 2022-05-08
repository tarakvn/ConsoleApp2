using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In do khat code adede random beyne 0 ta 100 tolid mi konad.
            //Random rand = new Random();
            //int adad = rand.Next(0,100);

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Welcome");
                Console.ReadKey();
                goto N;
            } else 
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Go out");
            }
        N:
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Enter your score:");
            int score = int.Parse(Console.ReadLine());
            if (score > 20)
            {
                Console.WriteLine("The score is from 20");
                Console.ReadKey();
                Console.Clear();
                goto N;
            }
            else
            {
                int deducted = 20 - score;
                Console.WriteLine("Your deducted score is: " + deducted);
            }
            Console.ReadKey();
        }
    }
}
