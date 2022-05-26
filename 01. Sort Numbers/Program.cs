using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int maxNumberfirst = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
            Console.WriteLine(maxNumberfirst);
            int maxSecondNumber = 0;
            if (maxNumberfirst - firstNumber == 0)
            {
                maxSecondNumber = Math.Max(secondNumber, thirdNumber);
                Console.WriteLine(maxSecondNumber);
                if (maxSecondNumber - secondNumber==0)
                {
                    Console.WriteLine(thirdNumber);
                }
                else
                {
                    Console.WriteLine(secondNumber);
                }
            }else if (maxNumberfirst - secondNumber==0)
            {
                maxSecondNumber = Math.Max(firstNumber, thirdNumber);
                Console.WriteLine(maxSecondNumber);
                if (maxSecondNumber - firstNumber == 0)
                {
                    Console.WriteLine(thirdNumber);
                }
                else
                {
                    Console.WriteLine(firstNumber);
                }
            }
            else
            {
                maxSecondNumber = Math.Max(firstNumber, secondNumber);
                Console.WriteLine(maxSecondNumber);
                if (maxSecondNumber - secondNumber == 0)
                {
                    Console.WriteLine(firstNumber);
                }
                else
                {
                    Console.WriteLine(secondNumber);
                }

            }
            

        }
    }
}
