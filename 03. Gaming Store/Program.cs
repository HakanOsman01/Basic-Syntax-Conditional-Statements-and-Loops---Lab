using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string nameOfGame = Console.ReadLine();
            double totalSpentMoney = 0.00;
            while (nameOfGame!="Game Time")
            {
                if(nameOfGame== "OutFall 4")
                {
                    if (currentBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                        
                    }
                    else
                    {
                       
                        currentBalance -= 39.99;
                        totalSpentMoney += 39.99;
                        Console.WriteLine($"Bought {nameOfGame}");
                    }
                }else if(nameOfGame=="CS: OG")
                {
                    if (currentBalance < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 15.99;
                        totalSpentMoney += 15.99;
                        Console.WriteLine($"Bought {nameOfGame}");
                    }
                }else if(nameOfGame== "Zplinter Zell")
                {
                    if (currentBalance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 19.99;
                        totalSpentMoney += 19.99;
                        Console.WriteLine($"Bought {nameOfGame}");
                    }
                }else if(nameOfGame== "Honored 2")
                {
                    if (currentBalance < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 59.99;
                        totalSpentMoney += 59.99;
                        Console.WriteLine($"Bought {nameOfGame}");
                    }

                }else if(nameOfGame== "RoverWatch")
                {
                    if (currentBalance < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 29.99;
                        totalSpentMoney += 29.99;
                        Console.WriteLine($"Bought {nameOfGame}");
                    }
                }else if(nameOfGame=="RoverWatch Origins Edition")
                {
                    if (currentBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBalance -= 39.99;
                        totalSpentMoney += 39.99;
                        Console.WriteLine($"Bought {nameOfGame}");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (currentBalance == 0)
                {
                    break;
                }
                nameOfGame = Console.ReadLine();
            }
            if (currentBalance == 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${totalSpentMoney:f2}. " +
                $"Remaining: ${currentBalance:f2}");
            }
            
        }
    }
}
