using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class FlipCoin
    {
        int headcount = 0;
        int tailcount = 0;
        public void Flip()
        {
            Console.WriteLine("Enter the Number of Flip: ");
            int numberofFlip = Convert.ToInt32(Console.ReadLine());
            if(numberofFlip > 0)
            {
                for(int i = 0; i < numberofFlip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(0,2);
                    if(number == 0)
                    {
                        headcount++;
                    }
                    else
                    {
                        tailcount++;
                    }
                    Console.WriteLine("Headcount:{0} Tailcount:{1}", headcount, tailcount);
                }
            }
        }
    }
}
