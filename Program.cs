using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FindMaximum_Generics
{
   class Program
   {
      static void Main(string[] args)
      {
            //Welcome Message
            Console.WriteLine("=-=-=-=-=-Welcome to the Find Maximum Problem using Generics-=-=-=-=-=");

            //Maximum Integer Number
            GenericMaximum<int> genericMaximumInteger = new GenericMaximum<int>(34, 23, 12);
            int outputInteger1 = genericMaximumInteger.MaxMethod();
            Console.WriteLine("Maximum Integer Number : " + outputInteger1);

            //Maximum Float Number
            GenericMaximum<float> genericMaximumFloat = new GenericMaximum<float>(3.4f, 22.23f, 48.12f);
            float outputFloat1 = genericMaximumFloat.MaxMethod();
            Console.WriteLine("Maximum Float Number : " + outputFloat1);

            //Maximum String Number
            GenericMaximum<string> genericMaximumString = new GenericMaximum<string>("Apple", "Banana", "Peach");
            string outputString1 = genericMaximumString.MaxMethod();
            Console.WriteLine("Maximum String : " + outputString1);

            Console.ReadLine();
      }
   }
}
  
