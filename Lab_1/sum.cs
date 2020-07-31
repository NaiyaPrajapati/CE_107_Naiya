using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = n1 + n2;

            Console.WriteLine("Sum:{0}",n3);
        }
    }
}
