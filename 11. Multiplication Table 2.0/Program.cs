using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int beginNumber = int.Parse(Console.ReadLine());
            if (beginNumber > 10)
            {
                Console.WriteLine($"{n} X {beginNumber} = {n * beginNumber}");
            }
            else
            {
                for (int currentNumber = beginNumber; currentNumber <= 10; currentNumber++)
                {
                    Console.WriteLine($"{n} X {currentNumber} = {n * currentNumber}");
                }
            }
            
        }
    }
}
