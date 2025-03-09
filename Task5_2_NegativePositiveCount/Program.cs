namespace Task5_2_NegativePositiveCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Исходные данные
            const int arrayCount = 10;
            int[] array = new int[arrayCount];
            int countPositive = 0;
            int countNegative = 0;
            int countZero = 0;

            for (int i = 0; i < arrayCount; i++)
            {
                Random rnd = new();
                array[i] = rnd.Next(-20, 21);
                Console.Write($"{array[i],-4}");
            }
            Console.WriteLine();
            foreach (int a in array)
            {
                if (a == 0)
                {
                    countZero++;
                }
                else if (a > 0)
                {
                    countPositive++;
                }
                else
                {
                    countNegative++;
                }
            }
            Console.WriteLine($"Массив содержит {countPositive} положительных значений, {countNegative} отрицательных значений и {countZero} нулей.");
            Console.ReadKey();
        }
    }
}
