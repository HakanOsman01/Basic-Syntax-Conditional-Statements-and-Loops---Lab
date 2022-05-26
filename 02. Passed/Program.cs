using System;

namespace _02._Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            bool isPassed = !(grade >= 3.00);
            if (!isPassed)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
