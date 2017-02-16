using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            string payrateString;
            double Payrate;
            Console.WriteLine("Enter Payrate");
            payrateString = Console.ReadLine();
            Payrate = Convert.ToDouble(payrateString);
            if (Payrate < 5.65 || Payrate > 50)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
