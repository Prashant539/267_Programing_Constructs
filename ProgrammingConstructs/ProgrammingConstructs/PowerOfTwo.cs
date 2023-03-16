using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class PowerOfTwo
    {
        int value = 2;
        public static void PrintPowerOfTwo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("2^" + i + " = " + Math.Pow(2, i));
            }
        }


    }
}
