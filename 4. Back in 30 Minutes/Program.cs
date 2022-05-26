using System;

namespace _4._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalMinutes = minutes + 30;
            int hoursMinutes = hours * 60 + totalMinutes;
            int hourAfterthertyMinutes = hoursMinutes / 60;
            int minutesAfterThertyMinutes = hoursMinutes % 60;
            if (hourAfterthertyMinutes >= 24)
            {
                hourAfterthertyMinutes -= 24;
            }
            if (minutesAfterThertyMinutes <=9)
            {
                
                Console.WriteLine($"{hourAfterthertyMinutes}:0{minutesAfterThertyMinutes}");
            }
            else
            {
                Console.WriteLine($"{hourAfterthertyMinutes}:{minutesAfterThertyMinutes}");
            }
        }
    }
}
