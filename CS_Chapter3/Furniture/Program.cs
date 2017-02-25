using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = "";

            Console.WriteLine("Enter the letter P,O, or M ");
            letter = Console.ReadLine();
            if (letter.ToUpper().StartsWith("P"))
            {
                Console.WriteLine("Pine Table - $100");
            }
            else if (letter.ToUpper().StartsWith("O"))
            {
                Console.WriteLine("Oak Table - $225");
            }
            else
            {
                Console.WriteLine("Mahogany Table - $310");
            }
        }
    }
}
