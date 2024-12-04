using System;
namespace Kashyap
{
    class TypeCasting_UserInput_Constraint
    {
        public static void Main(string[] args)
        {
            Console.Write("What is your name : ");
            string ?name = Console.ReadLine();
            Console.Write("What is you age : ");
            int ?age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your name is {name} and age is {age}");
        }
    }
}
