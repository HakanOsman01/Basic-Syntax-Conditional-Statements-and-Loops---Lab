using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int currentNumber = 1; currentNumber <= 10; currentNumber++)
            {
                Console.WriteLine($"{n} X {currentNumber} = {n * currentNumber}");
            }
        }
    }
}
