using System;
namespace ProgrammingConstructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Programming");
            Console.WriteLine("Choose any options to perform");
            Console.WriteLine("1:EqualOrNot");
            int options = Convert.ToInt32(Console.ReadLine());
            switch(options)
            {
                case 1:
                    EqualOrNot equalOrNot = new EqualOrNot();
                    equalOrNot.EqualOrNotPrint();
                    break;
            }
           
        }
    }
}
