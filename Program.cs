using System;

namespace FindMaximum_Generics
{
   class Program
   {
      static void Main(string[] args)
      { 
         //Welcome Message
         Console.WriteLine("=-=-=-=-=-Welcome to the Find Maximum Problem using Generics-=-=-=-=-=");

        //Calling Class to call a Function
        MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();

        //Maximum Number At First Place
        float outputFloat1 = maximumNumberCheck.MaximumFloatNumber(14.1f, 2.82f, 7.33f);
        Console.WriteLine("Maximum Number of Float at First Place : " + outputFloat1);

        //Maximum Number At Second Place
        float outputFloat2 = maximumNumberCheck.MaximumFloatNumber(4.1f, 28.2f, 12.8f);
        Console.WriteLine("Maximum Number of Float at Second Place : " + outputFloat2);

        //Maximum Number At Third Place
        float outputFloat3 = maximumNumberCheck.MaximumFloatNumber(75.9f, 68.47f, 77.3f);
        Console.WriteLine("Maximum Number of Float at Third Place : " + outputFloat3);

         Console.ReadLine();
      }
    }
}
