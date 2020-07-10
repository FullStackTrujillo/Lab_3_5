using System;
using System.Text.RegularExpressions;

namespace Lab_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWord = "red";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("The message is spam");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The message is not spam.");

                Console.WriteLine("Program 2");
                string blackListWord2 = "home";
                bool isSpam2 = false;
                string message2 = Console.ReadLine();
                if (message2.Contains(blackListWord2))
                {
                    isSpam2 = true;
                    Console.WriteLine("The message is spam");
                }
                else
                {
                    isSpam = false;
                    Console.WriteLine("The message is not spam.");

                    Console.WriteLine("Program 3");
                    string blackListWord3 = "glass";
                    bool isSpam3 = false;
                    string message3 = Console.ReadLine();
                    if (message3.Contains(blackListWord3))
                    {
                        isSpam3 = true;
                        Console.WriteLine("The message is spam");
                    }
                    else
                    {
                        isSpam = false;
                        Console.WriteLine("The message is not spam.");
                    }
                }
            }
        }
    }
}