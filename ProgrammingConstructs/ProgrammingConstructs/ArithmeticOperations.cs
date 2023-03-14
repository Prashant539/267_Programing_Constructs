using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class ArithmeticOperations
    {
        public static void ArithmeticOperationsPrint()
        {
            Console.WriteLine("Enter the First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number to Perform Operations");
            int options = Convert.ToInt32(Console.ReadLine());
            switch(options)
            {
                case 1:
                    Console.WriteLine("Addition of Two Number: " +(a + b)); 
                    break;
                case 2:
                    Console.WriteLine("Substraction of Two Number: " +(a - b));
                    break;
                case 3:
                    Console.WriteLine("Multipication of Two Number: " +(a * b));
                    break;
                case 4:
                    Console.WriteLine("Division of Two Number: " +(a / b)); 
                    break;

            }

        }
    }
}
