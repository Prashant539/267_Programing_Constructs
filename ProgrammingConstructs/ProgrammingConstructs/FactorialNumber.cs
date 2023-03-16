using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class FactorialNumber
    {
        int i, fact = 1, number;
        public void PrintFactorialNumber()
        {
            Console.WriteLine("Enter the Number for Factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1 ; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + number + " is " + fact);

        }
    }
}
