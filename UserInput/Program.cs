using System;

namespace Kashyap
{
    class UserInput
    {
        public static void Main(string[] args)
        {
            Console.Write("What is your name ? ");
            string name = Console.ReadLine();
            Console.WriteLine($"My name is {name}");
        }
    }
}