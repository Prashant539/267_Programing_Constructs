using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class AdmissionEligibility
    {
        public static void AdmissionCriteria()
        {
            Console.WriteLine("Input the marks obtained in Physics: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Mathematics: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int totalMark = p + c + m;
            if (m >= 65 && p >= 55 && c >= 50 && totalMark >= 180)
            {
                Console.WriteLine("Candidate is eligible for admission");
            }
            else if (m == 100) ;
        }
    }
}
