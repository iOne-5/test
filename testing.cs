using System;

namespace Practise1
{
    class Program
    {
        public const double P1 = 3.14;
        static void Main(string[] args)
        {
            string hello = "Hello world!";
            int a = 10;
            int b;
            Console.WriteLine(hello);
            a = 20;
            Console.WriteLine("a = " + a);
            Console.WriteLine("pi = " + P1);
            Console.WriteLine("Enter value for b: ");

            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entered value: " + b);

        }

    }

}
