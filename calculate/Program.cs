using System;

namespace calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter first number: ");
            string x = Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            string y = Console.ReadLine();
            int i = Convert.ToInt32(x);
            int j = Convert.ToInt32(y);
            Console.WriteLine("Addition = " + (i + j));
            Console.WriteLine("Substraction = " + (i - j));
            Console.WriteLine("Multiplication = " + (i * j));
            Console.WriteLine("Division = " + (i / j));
            Console.WriteLine("___________________________");
            Console.WriteLine("Finding SIMPLE INTEREST !!");
            Console.WriteLine("Enter Principle amount :");
            string p = Console.ReadLine();
            Console.WriteLine("Enter Rate of Interest :");
            string r = Console.ReadLine();
            Console.WriteLine("Enter Number of Years :");
            string n = Console.ReadLine();
            int a = Convert.ToInt32(p);
            int b = Convert.ToInt32(r);
            int c = Convert.ToInt32(n);
            int f = (a * b * c) / 100;
            Console.WriteLine("Simple Interest = " + f);
            Console.WriteLine("Amount = " + (a + f));

        }
    }
}
