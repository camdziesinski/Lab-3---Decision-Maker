using System;

namespace Lab3DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();
            string userGo = "y";
            while (userGo == "y")
            {
                Console.Write($"{userName}, please enter a number between 1 & 100. ");
                int i = int.Parse(Console.ReadLine());
                if (i >= 1 && i <= 100)
                {
                    if (i % 2 == 1)
                    {
                        if (i > 60)
                        {
                            Console.WriteLine($"{i} is odd");
                        }
                        else
                        {
                            Console.WriteLine("that # is Odd");

                        }
                    }
                    else
                    {
                        if (i > 60)
                        {
                            Console.WriteLine($"{i} is even.");
                        }
                        else if (i > 25 && i <= 60)
                        {
                            Console.WriteLine("that # is even");
                        }
                        else
                        {
                            Console.WriteLine("even and less than 25");
                        }
                    }
                }
                userGo = "";
                while (userGo != "y" && userGo != "n")
                {
                    Console.Write($"{userName}, would you like to enter another number? (y/n) ");
                    userGo = Console.ReadLine().ToLower();
                }
            }
            if (userGo == "n")
            {
                Console.WriteLine($"Goodbye {userName}.");

            }

        }
    }
}
