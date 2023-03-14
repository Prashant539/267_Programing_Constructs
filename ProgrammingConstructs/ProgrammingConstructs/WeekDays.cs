using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class WeekDays
    {
        public static void WeekDaysPrint()
        {
            Console.WriteLine("Enter the Day Number: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            switch(dayNumber)
            {
                case 1:
                    Console.WriteLine("It is Monday");
                    break;
                case 2:
                    Console.WriteLine("It is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("It is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("It is Thrusday");
                    break;
                case 5:
                    Console.WriteLine("It is Friday");
                    break;
                case 6:
                    Console.WriteLine("It is Saturday");
                    break;
                case 7:
                    Console.WriteLine("It is Sunday");
                    break;
                default:
                    Console.WriteLine("Please choose number between 1 to 7");
                    break;
            }
        }
        
    }
}
