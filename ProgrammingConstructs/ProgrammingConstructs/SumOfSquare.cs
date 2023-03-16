using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class SumOfSquare
    {
        int i, n, Sum = 0;
        public void PrintSumOfSquare()
        {
            Console.WriteLine("Enter the input: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}", i*i);
                Sum += i*i;
            }
            Console.WriteLine("The Sum of Square Natural Number upto {0} terms = {1} ",n, Sum);
        }
    }
}
