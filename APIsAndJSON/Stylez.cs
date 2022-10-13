using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class Stylez
    {
        public static void Style()
        {
            var repeat = true;
            var repeat2 = true;
            while (repeat)
            {

                repeat2 = true;
                RonVSKanyeAPI.KanyeQuote();
                RonVSKanyeAPI.RonQuote();

                while (repeat2)
                {
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.WriteLine("Would you like more quotes?");
                    var answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        Console.Clear();
                        repeat = true;
                        repeat2 = false;
                    }
                    else if (answer == "no")
                    {
                        Console.WriteLine("Ok, see you next time!");
                        Console.WriteLine();
                        repeat = false;
                        repeat2 = false;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Error: Invalid input... Please try again!");
                        repeat2 = true;
                    }
                }
            }
        }
    }
}
