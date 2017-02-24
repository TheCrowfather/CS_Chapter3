using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            string payrateString, hoursString;
            double Payrate, hours , grosspay;
            Console.WriteLine("Enter hourly Payrate");
            payrateString = Console.ReadLine();
            Payrate = Convert.ToDouble(payrateString);
            Console.WriteLine("Enter hours worked");
            hoursString = Console.ReadLine();
            hours = Convert.ToDouble(hoursString);
            grosspay = Payrate * hours;
            Console.WriteLine("Your grosspay: " + grosspay);
            
            if (grosspay <= 300.00)
            {
                Console.WriteLine("The withholding tax:" + grosspay * .10);
            }
            else
            {
                Console.WriteLine("The witholding tax:" + grosspay * .12);
            }
        }
    }
}
