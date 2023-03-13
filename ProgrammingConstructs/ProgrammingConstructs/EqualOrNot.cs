using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class EqualOrNot
    {
        public void EqualOrNotPrint()
        {
            Console.WriteLine("Enter the First number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if(firstNumber == secondNumber)
            {
                Console.WriteLine("Both Numbers are Equal");
            }
            else
            {
                Console.WriteLine("Numbers are not Equal");
            }
        }
    }
}
