using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructs
{
    public class Vote
    {
        public void VoteEligibility()
        {
            Console.WriteLine("Enetr the age of candidate: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age >= 18 )
            {
                Console.WriteLine("Candidate is eligible for vote");
            }
            else
            {
                Console.WriteLine("Candidate is not eligible for vote");
            }
        }
    }
}
