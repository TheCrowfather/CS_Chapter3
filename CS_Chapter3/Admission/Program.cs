using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            string gradeString, GPAString;
            double grade, GPA;
            Console.WriteLine("Enter numerical GPA ");
            GPAString = Console.ReadLine();
            GPA = Convert.ToDouble(GPAString);
            if (GPA > 3.0 || GPA < 3.0)
            Console.WriteLine("Enter admition test grade");
            gradeString = Console.ReadLine();
            grade = Convert.ToDouble(gradeString);
            if (grade > 60)
            {
                Console.WriteLine("Accepted");
            }
            else
            {
                Console.WriteLine("Not Accepted");
            }
                        
        }
    }
}
