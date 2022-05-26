using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string contry = Console.ReadLine();
            if(contry== "England" || contry == "USA")
            {
                Console.WriteLine("English");
            }else if(contry=="Spain" || contry=="Argentina" || contry== "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
