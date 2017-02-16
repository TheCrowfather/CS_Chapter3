using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class Program
    {
        static void Main(string[] args)
        {
            string payrateString, hourString;
            double Payrate, Hours;
            Console.WriteLine("Enter Payrate");
            payrateString = Console.ReadLine();
            Payrate = Convert.ToDouble(payrateString);
            Console.WriteLine("Enter Hours Worked");
            hourString = Console.ReadLine();
            Hours = Convert.ToDouble(hourString);
            
            if (Payrate % Hours < 5.65 || Payrate % Hours > 50)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
