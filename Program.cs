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
            Console.WriteLine("Welcome to Maximum Number");

            int[] intArray = { 34, 23, 12, 36 };
            float[] floatArray = { 12.5f, 45.65f, 987.45f, 658.78f };
            string[] stringArray = { "Apple", "Peach", "Banana" };

            // Passing integer input with max number at first place
            ExtendGenericMaximum<int> extendGenericMaximum = new ExtendGenericMaximum<int>(intArray);
            int outputInt = extendGenericMaximum.MaxMethod();

            ExtendGenericMaximum<float> extendGenericMaximum1 = new ExtendGenericMaximum<float>(floatArray);
            float outputFloat = extendGenericMaximum1.MaxMethod();

            ExtendGenericMaximum<string> extendGenericMaximum2 = new ExtendGenericMaximum<string>(stringArray);
            string outputString = extendGenericMaximum2.MaxMethod();

            //Display Output
            Console.WriteLine("Integer Max : " + outputInt);
            Console.WriteLine("Float Max : " + outputFloat);
            Console.WriteLine("String Max : " + outputString);

            Console.ReadLine();
        }
   }
}
  
