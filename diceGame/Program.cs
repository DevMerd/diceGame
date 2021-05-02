using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace diceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo h;

            int dice1, dice2;
            string name1, name2;

            Console.Write("First player name:");
            name1 = Console.ReadLine();

            Console.Write("Second player name:");
            name2 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Name of first player {0}, name of the second player {1} Welcome !!!\n", name1, name2);

            Random numGen = new Random();
            dice1 = numGen.Next(1, 7);
            dice2 = numGen.Next(1, 7);

            Console.Write("{0}={1}\n{2}={3}\n\n", name1, dice1, name2, dice2);

            if (dice1 == dice2)
            {
                Console.WriteLine("Draw !!! The dice are rolling again...\n");
                Thread.Sleep(1000);

                dice1 = numGen.Next(1, 7);
                dice2 = numGen.Next(1, 7);
                Console.Write("{0}={1}\n{2}={3}\n\n", name1, dice1, name2, dice2);

                if (dice1 > dice2)
                    Console.WriteLine("First Player Won Congratulations");

                else if (dice2 > dice1)
                    Console.WriteLine("Second Player Won Congratulations");
            }
            else if (dice1 > dice2)
                Console.WriteLine("First Player Won Congratulations");
            else
                Console.WriteLine("Second Player Won Congratulations");

            do
            {
                Console.WriteLine("\nPress x for exit !");
                h = Console.ReadKey();
            }
            while (h.KeyChar != 'x');

        }
    }
}
