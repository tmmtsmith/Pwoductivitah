using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;

namespace Pwoductivitah
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            while (a == 1)
            {
                Console.WriteLine("Enter the minutes for the timer");
                string ans = Console.ReadLine();

                try
                {
                    Console.Clear();
                    Console.WriteLine("TIMER STARTED");
                    int x = Convert.ToInt16(ans);

                    while (x > 0)
                    {
                        Console.WriteLine("\n" + Convert.ToString(x) + " minute(s) remaining ... ");
                        Thread.Sleep(60000);
                        x--;
                    }

                    Console.Beep(1000, 800);
                    Thread.Sleep(300);
                    Console.Beep(1000, 800);
                    Thread.Sleep(300);
                    Console.Beep(1000, 800);
                }
                catch
                {
                    Console.WriteLine("You must enter a valid number.");
                    a = 1;
                }

                Console.Clear();
                Console.WriteLine("Do you want to exit (Press Y or N)?");
                string rep = Console.ReadLine();

                if (rep.ToLower() == "y")
                {
                    a = 2;
                }

                Console.WriteLine("\n");
            }

        }
    }
}
