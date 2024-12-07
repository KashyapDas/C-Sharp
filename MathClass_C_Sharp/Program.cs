using System;

namespace Kashyap
{
    class MathClass_C_Sharp
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the 1st number : ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number : ");
            int no2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The maximum between both the number is : {Math.Max(no1,no2)}");
        }
    }
}