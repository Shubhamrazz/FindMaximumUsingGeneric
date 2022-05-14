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

            //Maximum Number At First, Second and Third Place 
            int outputInt1 = maximumNumberCheck.MaximumNumber<int>(434, 57, 12);
            int outputInt2 = maximumNumberCheck.MaximumNumber<int>(344, 734, 712);
            int outputInt3 = maximumNumberCheck.MaximumNumber<int>(343, 344, 1200);

            //Maximum Number At First, Second and Third Place 
            float outputFloat1 = maximumNumberCheck.MaximumNumber<float>(128.9f, 8.9f, 11.75f);
            float outputFloat2 = maximumNumberCheck.MaximumNumber<float>(12.9f, 48.9f, 28.29f);
            float outputFloat3 = maximumNumberCheck.MaximumNumber<float>(1.9f, 4.0f, 4.9f);

            //Maximum Number At First, Second and Third Place 
            string outputString1 = maximumNumberCheck.MaximumNumber<string>("Peach", "Apple", "Banana");
            string outputString2 = maximumNumberCheck.MaximumNumber<string>("Apple", "Peach", "Banana");
            string outputString3 = maximumNumberCheck.MaximumNumber<string>("Apple", "Banana", "Peach");

            //Display Results
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Results Of an Integer : ");
            Console.WriteLine("Integer at First Place : " + outputInt1);
            Console.WriteLine("Integer at Second Place : " + outputInt2);
            Console.WriteLine("Integer at Third Place : " + outputInt3);
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Results Of an Float : ");
            Console.WriteLine("Float at First Place : " + outputFloat1);
            Console.WriteLine("Float at Second Place : " + outputFloat2);
            Console.WriteLine("Float at Third Place : " + outputFloat3);
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Results Of an String : ");
            Console.WriteLine("String at First Place : " + outputString1);
            Console.WriteLine("String at Second Place : " + outputString2);
            Console.WriteLine("String at Third Place : " + outputString3);
            Console.WriteLine("----------------------------------------");

            Console.ReadLine();
      }
   }
}
  
