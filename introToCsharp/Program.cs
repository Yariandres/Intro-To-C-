using System;

namespace introToCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // int number;
            // float floatingNum;
            double PI;
            PI = 3.14;
            Console.WriteLine(PI);

            double storingPI;
            storingPI = PI;

            decimal deci;
            deci = System.Convert.ToDecimal(PI);
            Console.WriteLine(deci);

            string[] animals = new string[3];
            animals[0] = "deer";
            animals[1] = "moose";
            animals[2] = "boars";
            Console.WriteLine("ARRAY 1: " + animals.Length);


        }

        
    }

    
}
 