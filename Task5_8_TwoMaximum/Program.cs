namespace Task5_8_TwoMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Исходные данные
            const int arrayCount = 5;
            int[] array = new int[arrayCount];
            int fMax = 0;
            int sMax = 0;

            //Формирование массива
            Console.WriteLine("Основной массив:");
            for (int i = 0; i < arrayCount; i++)
            {
                Random rnd = new();
                array[i] = rnd.Next(0, 11);
                if (i == 0)
                {
                    fMax = array[i];
                }
                else if (array[i] > fMax)
                {
                    sMax = fMax;
                    fMax = array[i];
                }
                else if ((i == 1 && array[i] <= fMax) || (array[i] > sMax && array[i] <= fMax))
                {
                    sMax = array[i];
                }
                Console.Write($"{array[i],-3}");
            }
            Console.WriteLine();
            Console.WriteLine($"Первый максимум: {fMax}, Второй максимум: {sMax}");
            Console.ReadKey();
        }
    }
}
