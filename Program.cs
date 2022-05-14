using System;

namespace FindMaximum_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome to Maximum Number");

            //Calling Class to call a Function
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();

            //Find Maximum Integer
            int outputInteger = maximumNumberCheck.MaximumIngerNumber(11,111,1111);

            //Display Output
            Console.WriteLine("Maximum Number of Integer : " + outputInteger);

            Console.ReadLine();

        }
    }
}
