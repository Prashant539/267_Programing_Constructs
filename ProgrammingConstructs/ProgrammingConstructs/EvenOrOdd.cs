using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class EvenOrOdd
    {
        public void EvenOddPrint()
        {
            Console.WriteLine("Enter the Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int rem;
            rem = number % 2;
            if(rem == 0)
            {
                Console.WriteLine("Enetr Number is Even");
            }
            else
            {
                Console.WriteLine("Enter Number is odd");
            }
        }

    }
}
