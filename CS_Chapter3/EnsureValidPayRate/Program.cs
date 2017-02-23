using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        private static double rate;

        static void Main(string[] args)
        {
            string payrateString, rateString;
            double Payrate;
            Console.WriteLine("Enter Payrate");
            payrateString = Console.ReadLine();
            Payrate = Convert.ToDouble(payrateString);
            if (Payrate < 5.65 || Payrate > 50)
            {
                Console.WriteLine("Please enter payrate");
              }
            { 
            if (Payrate < 5.65 || Payrate < 50)
            Console.WriteLine("The weekly rate is:" + Payrate * 40);
            rateString = Console.ReadLine();
            rate = Convert.ToDouble(rateString);
            }
        
        }
    }
}
