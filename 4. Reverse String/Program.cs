using System;

namespace _4._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string reverseText = string.Empty;
            for(int i = text.Length-1; i >= 0; i--)
            {
                reverseText += text[i];
            }
            Console.WriteLine(reverseText);
        }
    }
}
