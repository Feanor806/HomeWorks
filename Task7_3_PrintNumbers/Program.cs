using System.Runtime.InteropServices;

namespace Test7_3_PrintNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            PrintNumbers(numbers); // Вывод: 1 2 3 4 5
            PrintNumbers(numbers, true); // Вывод: 5 4 3 2 1
        }

        static void PrintNumbers(int[] numbers, bool reverse = false)
        {
            if (reverse)
            {
                for (int i=0; i<numbers.Length;i++)
                {
                    Console.Write($"{numbers[numbers.Length - 1 - i]} ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
