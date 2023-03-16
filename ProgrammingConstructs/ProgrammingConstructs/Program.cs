using System;
namespace ProgrammingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Programming");
            Console.WriteLine("Choose any options to perform");
            Console.WriteLine("1:EqualOrNot\n2: EvenOrOdd\n3: VoteEligiblity\n4:LargestNumber\n5:AdmissionEligibility\n6:WeekDays\n7:ArithmeticOperations\n8:PowerofTwo");
            int options = Convert.ToInt32(Console.ReadLine());
            switch(options)
            {
                case 1:
                    EqualOrNot equalOrNot = new EqualOrNot();
                    equalOrNot.EqualOrNotPrint();
                    break;
                case 2:
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.EvenOddPrint();
                    break;
                case 3:
                    Vote vote = new Vote();
                    vote.VoteEligibility();
                    break;
                case 4:
                    LargestNumber.LargestNumberPrint();
                    break;
                case 5:
                    AdmissionEligibility.AdmissionCriteria();
                    break;
                case 6:
                    WeekDays.WeekDaysPrint();
                    break;
                case 7:
                    ArithmeticOperations.ArithmeticOperationsPrint();
                    break;
                case 8:
                    PowerOfTwo.PrintPowerOfTwo();
                    break;
            }
           
        }
    }
}
