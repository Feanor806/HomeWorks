namespace Task5_1_EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Исходные данные
            const int arrayCount = 10;
            int[] array = new int[arrayCount];
            int countEven = 0;
            int countOdd = 0;

            for (int i = 0; i < arrayCount; i++)
            {
                Random rnd = new();
                array[i] = rnd.Next(0, 101);
                if (array[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
                Console.Write($"{array[i],-4}");
            }
            Console.WriteLine();
            if (countEven > countOdd)
            {
                Console.WriteLine($"Четных чисел больше");
            }
            else if (countEven == countOdd)
            {
                Console.WriteLine($"Четных и нечетных чисел поровну");
            }
            else
            {
                Console.WriteLine($"Нечетных чисел больше");
            }
            Console.ReadKey();
        }
    }
}
