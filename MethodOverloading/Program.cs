using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(8, -6));
            Console.WriteLine(Add(8.7m, -9.4m));
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine(Add(5, 7, true));
            Console.WriteLine(Add(8, 23, false));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        
        public static string Add(int num1, int num2, bool dollars)
        {
            var sum = num1 + num2;

            if (dollars)
            {
                return sum == 1 ? $"{sum} dollar" : $"{sum} dollars";
            }
            else return $"{sum}";
        }
    }
}
